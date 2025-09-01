using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SIS_CAB.FORMS
{
    public partial class ForgotPasswordUC : UserControl
    {
        public event EventHandler CancelClicked;

        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SmtpUser = "nellypial.ccsdump@gmail.com";      // <- replace with your Gmail
        private const string SmtpAppPassword = "dakj pxzv kezy jhqh";
        private byte[] email;

        public ForgotPasswordUC()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailInput))
            {
                MessageBox.Show("⚠ Please enter your registered email or username.");
                return;
            }

            try
            {
                int userId = FindUserIdByEmailOrUsername(emailInput, out string resolvedEmail);

                if (userId == -1 || string.IsNullOrEmpty(resolvedEmail))
                {
                    MessageBox.Show("⚠ Email or username not found.");
                    return;
                }

                // generate 6-digit code
                var rnd = new Random();
                string code = rnd.Next(100000, 999999).ToString();

                // expiry in 1 minutes 
                DateTime expiry = DateTime.Now.AddMinutes(1);

                // save to DB
                SaveVerificationCode(userId, code, expiry);

                // send email
                if (SendVerificationEmail(resolvedEmail, code, out string sendError))
                {
                    MessageBox.Show("✅ Verification code sent. Please check your email.");

                    var verifyUC = new VerificationCodeUC(userId, resolvedEmail);
                    verifyUC.Dock = DockStyle.Fill;
                    this.Parent?.Controls.Add(verifyUC);
                    verifyUC.BringToFront();

                    this.Parent?.Controls.Remove(this);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("⚠ Failed to send email:\n" + sendError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nStack: " + ex.StackTrace);
            }
        }

        private int FindUserIdByEmailOrUsername(string emailInput, out string resolvedEmail)
        {
            resolvedEmail = null;

            try
            {
                using (var con = new SqlConnection(DatabaseConnection.connectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(@"
                        SELECT u.user_id,
                               CASE 
                                   WHEN s.email IS NOT NULL THEN s.email
                                   WHEN t.email IS NOT NULL THEN t.email
                                   WHEN a.email IS NOT NULL THEN a.email
                       END AS email
                        FROM user_login u
                        LEFT JOIN student s ON u.user_id = s.user_id
                        LEFT JOIN teacher t ON u.user_id = t.user_id
                        LEFT JOIN Admin a   ON u.user_id = a.user_id
                        WHERE u.username = @input
                           OR (s.email IS NOT NULL AND s.email = @input)
                           OR (t.email IS NOT NULL AND t.email = @input)
                           OR (a.email IS NOT NULL AND a.email = @input)", con))
                    {
                        cmd.Parameters.AddWithValue("@input", emailInput);

                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                resolvedEmail = r["email"] as string;
                                return Convert.ToInt32(r["user_id"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB lookup error: " + ex.Message);
            }

            return -1;
        }

        private bool SendVerificationEmail(string resolvedEmail, string code, out string sendError)
        {
            sendError = null;

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("SIS Support", SmtpUser));
                message.To.Add(MailboxAddress.Parse(email));
                message.Subject = "Password Reset Verification Code";

                message.Body = new TextPart("plain")
                {
                    Text = $"Hello,\n\nYour verification code is: {code}\n\nThis code is valid for 5 minutes.\n\n- SIS Team"
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(SmtpHost, SmtpPort, SecureSocketOptions.StartTls);
                    client.Authenticate(SmtpUser, SmtpAppPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                sendError = ex.Message + "\n\nTips:\n" +
                            "- Make sure 2FA is ON for Gmail\n" +
                            "- Use a Gmail App Password (not your Gmail password)\n" +
                            "- Check if antivirus/firewall is blocking port 587";
                return false;
            }
        }

        private void SaveVerificationCode(int userId, string code, DateTime expiry)
        {
            try
            {
                using (var con = new SqlConnection(DatabaseConnection.connectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(@"
                                                    UPDATE user_login
                                                    SET verification_code = @code,
                                                    verification_expiry = @expiry
                                                    WHERE user_id = @uid", con))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@expiry", expiry);
                        cmd.Parameters.AddWithValue("@uid", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save verification code: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

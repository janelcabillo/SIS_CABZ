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
        public string otpcode;

        public ForgotPasswordUC()
        {
            InitializeComponent();



        }
        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("SIS", "ccs.renno04@gmail.com"));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate("nellypial.ccsdump@gmail.com", "wyyj vpbh txnl yeun");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            using (SqlConnection con = new SqlConnection(DatabaseConnection.connectionString))
            {
                con.Open();
                string query = @"SELECT email FROM student WHERE email=@em
                                 UNION 
                                 SELECT email FROM teacher WHERE email=@em";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@em", email);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Random random = new Random();
                    otpcode = random.Next(100000, 999999).ToString();

                    SendEmail(email, "Your OTP Code", $"Your OTP code is {otpcode}");
                    MessageBox.Show("OTP sent to your email!");
                }
                else
                {
                    MessageBox.Show("Email not found!");
                }
            }
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtverify.Text == otpcode)
            {
                MessageBox.Show("OTP Verified! Please Enter New Password");
                pnl_password.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtnew.Text != txtconfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string newpass = txtnew.Text;
            string email = txtEmail.Text;

            using (SqlConnection con = new SqlConnection(DatabaseConnection.connectionString))
            {
                con.Open();


                string getUserQuery = @"
                    SELECT s.first_name 
                    FROM student s
                    WHERE s.email = @em
                    UNION
                    SELECT t.first_name 
                    FROM teacher t
                    WHERE t.email = @em";

                SqlCommand cmdGet = new SqlCommand(getUserQuery, con);
                cmdGet.Parameters.AddWithValue("@em", email);
                var usernameObj = cmdGet.ExecuteScalar();

                if (usernameObj != null)
                {
                    string username = usernameObj.ToString();


                    string updateQuery = "UPDATE User_Login SET password_hash = @pas WHERE username = @uname";
                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.AddWithValue("@pas", newpass);
                    cmdUpdate.Parameters.AddWithValue("@uname", username);

                    int rows = cmdUpdate.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password Updated Successfully!");
                        LoginForm form1 = new LoginForm();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password in User_Login!");
                    }
                }
                else
                {
                    MessageBox.Show("No matching user found for this email!");
                }
            }
        }
    }
}

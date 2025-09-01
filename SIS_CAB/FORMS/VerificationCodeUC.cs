using Microsoft.Data.SqlClient;
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
    public partial class VerificationCodeUC : UserControl
    {
        private readonly int _userId;
        private readonly string _email;
        private int _timeLeftSeconds = 60; // 1 minute
        private System.Windows.Forms.Timer _timer;
        private int totalSeconds;

        public VerificationCodeUC(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email ?? throw new ArgumentNullException(nameof(email));
            this.Load += VerificationCodeUC_Load;
        }

        private void VerificationCodeUC_Load(object sender, EventArgs e)
        {
            DateTime expiry;
            using (var con = new SqlConnection(DatabaseConnection.connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT verification_expiry FROM user_login WHERE user_id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", _userId);
                    var result = cmd.ExecuteScalar();
                    expiry = result != null && result != DBNull.Value ? Convert.ToDateTime(result) : DateTime.Now;
                }
            }

            _timeLeftSeconds = (int)(expiry - DateTime.Now).TotalSeconds;
            if (_timeLeftSeconds <= 0) _timeLeftSeconds = 0;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            lblCountdown.Text = $"Time left: {FormatTime(_timeLeftSeconds)}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeLeftSeconds--;
            lblCountdown.Text = $"Time left: {FormatTime(_timeLeftSeconds)}";

            if (_timeLeftSeconds <= 0)
            {
                _timer.Stop();
                _timer.Tick -= Timer_Tick; // unsubscribe handler
                _timer.Dispose();          // release resources
                _timer = null;

                MessageBox.Show("Verification expired. Please request a new code.");
                GoToForgotPassword();
            }
        }

        private object FormatTime(int timeLeftSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string entered = txtCode.Text.Trim();
            if (string.IsNullOrEmpty(entered))
            {
                MessageBox.Show("Please enter the verification code.");
                return;
            }

            try
            {
                using (var con = new SqlConnection(DatabaseConnection.connectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT verification_code, verification_expiry FROM user_login WHERE user_id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", _userId);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (!r.Read())
                            {
                                MessageBox.Show("User not found.");
                                return;
                            }

                            string dbCode = r["verification_code"] as string;
                            DateTime? expiry = r["verification_expiry"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(r["verification_expiry"]);

                            if (string.IsNullOrEmpty(dbCode) || !expiry.HasValue || DateTime.Now > expiry.Value)
                            {
                                MessageBox.Show("Code expired or not available. Request a new code.");
                                return;
                            }

                            if (!dbCode.Equals(entered, StringComparison.Ordinal))
                            {
                                MessageBox.Show("Invalid verification code.");
                                return;
                            }
                        }
                    }

                    // Clear code in DB to prevent reuse
                    using (var clear = new SqlCommand(
                        "UPDATE user_login SET verification_code=NULL, verification_expiry=NULL WHERE user_id=@id", con))
                    {
                        clear.Parameters.AddWithValue("@id", _userId);
                        clear.ExecuteNonQuery();
                    }
                }

                _timer?.Stop();

                // Move to ResetPasswordUC (ensure ResetPasswordUC has matching constructor)
                var resetUC = new ResetPasswordUC(_userId, _email);
                resetUC.Dock = DockStyle.Fill;
                if (this.Parent != null)
                {
                    var parent = this.Parent;
                    parent.Controls.Add(resetUC);
                    resetUC.BringToFront();
                    this.Hide(); // instead of removing & disposing
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nStack: " + ex.StackTrace);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _timer?.Stop();
            GoToForgotPassword();
        }

        private void GoToForgotPassword()
        {
            var forgot = new ForgotPasswordUC();
            forgot.Dock = DockStyle.Fill;
            this.Parent?.Controls.Add(forgot);
            forgot.BringToFront();
            this.Parent?.Controls.Remove(this);
            this.Dispose();
        }
    }
}

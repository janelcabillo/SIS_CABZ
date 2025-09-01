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

namespace SIS_CAB.FORMS
{
    public partial class ResetPasswordUC : UserControl
    {
        private readonly int _userId;
        private readonly string _email;
        public ResetPasswordUC(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("⚠ Please fill both password fields.");
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("⚠ Passwords do not match.");
                return;
            }

            try
            {
                // Hash password before saving
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPass);

                using (var con = new SqlConnection(DatabaseConnection.connectionString))
                {
                    con.Open();

                    using (var cmd = new SqlCommand(
                        "UPDATE user_login SET password_hash=@p WHERE user_id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@id", _userId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("✅ Password updated successfully. Please login again.");

                            // Go back to login form
                            var login = new LoginForm();
                            login.Show();

                            Form parentForm = this.FindForm();
                            parentForm?.Close();
                        }
                        else
                        {
                            MessageBox.Show("⚠ Error: user not found or password not updated.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }
        private string HashPassword(string newPass)
        {
            return BCrypt.Net.BCrypt.HashPassword(newPass);
        }
    }
}

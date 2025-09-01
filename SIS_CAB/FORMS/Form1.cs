using SIS_CAB.FORMS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SIS_CAB
{
    public partial class LoginForm : Form
    {
        private ForgotPasswordUC forgotpassUC;
        private VerificationCodeUC verificationCodeUC;
        private ResetPasswordUC resetpassUC;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    connection.Open();

                    // Get user info including failed attempts and lockout status
                    string query = @"SELECT user_id, role_id, password_hash, failed_attempts, lockout_until 
                 FROM user_login WHERE username = @username";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["user_id"]);
                        int roleID = Convert.ToInt32(reader["role_id"]);
                        string dbPassword = reader["password_hash"].ToString();
                        int failedAttempts = reader["failed_attempts"] == DBNull.Value ? 0 : Convert.ToInt32(reader["failed_attempts"]);
                        DateTime? lockoutUntil = reader["lockout_until"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["lockout_until"]);

                        reader.Close();

                        // Check lockout
                        if (lockoutUntil.HasValue && lockoutUntil > DateTime.Now)
                        {
                            MessageBox.Show($"Account locked. Try again at {lockoutUntil}");
                            return;
                        }

                        if (dbPassword == password) // ? Correct password
                        {
                            // Reset failed attempts
                            string resetQuery = "UPDATE user_login SET failed_attempts = 0, lockout_until = NULL WHERE user_id = @id";
                            SqlCommand resetCmd = new SqlCommand(resetQuery, connection);
                            resetCmd.Parameters.AddWithValue("@id", userId);
                            resetCmd.ExecuteNonQuery();

                            // Redirect based on role
                            switch (roleID)
                            {
                                case 1:
                                    Admin admin = new Admin(username);
                                    admin.Show();
                                    this.Hide();
                                    break;
                                case 2:
                                    Student student = new Student(username);
                                    student.Show();
                                    this.Hide();
                                    break;
                                case 3:
                                    Teacher teacher = new Teacher(username);
                                    teacher.Show();
                                    this.Hide();
                                    break;
                                default:
                                    MessageBox.Show("Unknown user role.");
                                    break;
                            }
                        }
                        else // ? Wrong password
                        {
                            failedAttempts++;

                            if (failedAttempts >= 3)
                            {
                                // Lock user for 24 hours
                                DateTime lockoutTime = DateTime.Now.AddHours(24);
                                string lockQuery = "UPDATE user_login SET failed_attempts = @fa, lockout_until = @lu WHERE user_id = @id";
                                SqlCommand lockCmd = new SqlCommand(lockQuery, connection);
                                lockCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                lockCmd.Parameters.AddWithValue("@lu", lockoutTime);
                                lockCmd.Parameters.AddWithValue("@id", userId);
                                lockCmd.ExecuteNonQuery();

                                MessageBox.Show("Too many failed attempts. Account locked for 24 hours.");
                            }
                            else
                            {
                                // Just update attempts
                                string updateQuery = "UPDATE user_login SET failed_attempts = @fa WHERE user_id = @id";
                                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                                updateCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                updateCmd.Parameters.AddWithValue("@id", userId);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show($"Invalid password. Attempts left: {3 - failedAttempts}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelWelcome.Visible = false;

            // Show forgot password control inside the panel
            forgotpassUC.Visible = true;
            forgotpassUC.BringToFront();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            forgotpassUC = new ForgotPasswordUC();
            this.Controls.Add(forgotpassUC);
            forgotpassUC.Visible = false;
            forgotpassUC.Location = new System.Drawing.Point(287, 54);

            // Subscribe to cancel event
            forgotpassUC.CancelClicked += ForgotpassUC_CancelClicked;
        }

        private void ForgotpassUC_CancelClicked(object? sender, EventArgs e)
        {
            forgotpassUC.Visible = false;
            panelWelcome.Visible = true;
        }
    }
}

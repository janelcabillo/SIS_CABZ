using SIS_CAB.FORMS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SIS_CAB
{
    public partial class LoginForm : Form
    {
        private ForgotPasswordUC forgotpassUC;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // ?? Validate inputs first
            List<string> missingFields = new List<string>();
            if (string.IsNullOrEmpty(username)) missingFields.Add("Username");
            if (string.IsNullOrEmpty(password)) missingFields.Add("Password");

            if (missingFields.Count > 0)
            {
                string message = "Please enter the following required fields:\n- " + string.Join("\n- ", missingFields);
                MessageBox.Show(message);
                return;
            }

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

                        // Check if account is locked
                        if (lockoutUntil.HasValue && lockoutUntil > DateTime.Now)
                        {
                            MessageBox.Show($"Account locked. Try again at {lockoutUntil}");
                            return;
                        }

                        // Check password
                        if (dbPassword == password)
                        {
                            // Reset failed attempts
                            string resetQuery = "UPDATE user_login SET failed_attempts = 0, lockout_until = NULL WHERE user_id = @id";
                            SqlCommand resetCmd = new SqlCommand(resetQuery, connection);
                            resetCmd.Parameters.AddWithValue("@id", userId);
                            resetCmd.ExecuteNonQuery();

                            Logger.Log(userId, "Login", $"User {username} logged in");

                            // Redirect based on role
                            switch (roleID)
                            {
                                case 1:
                                    Admin admin = new Admin(userId, username);
                                    admin.Show();
                                    this.Hide();
                                    break;
                                case 2:
                                    Teacher teacher = new Teacher(userId, username);
                                    teacher.Show();
                                    this.Hide();
                                    break;
                                case 3:
                                    Student student = new Student(userId, username);
                                    student.Show();
                                    this.Hide();
                                    break;
                                default:
                                    MessageBox.Show("Unknown user role.");
                                    break;
                            }
                        }
                        else
                        {
                            // Wrong password handling
                            failedAttempts++;
                            if (failedAttempts >= 3)
                            {
                                DateTime lockoutTime = DateTime.Now.AddMinutes(1);
                                string lockQuery = "UPDATE user_login SET failed_attempts = @fa, lockout_until = @lu WHERE user_id = @id";
                                SqlCommand lockCmd = new SqlCommand(lockQuery, connection);
                                lockCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                lockCmd.Parameters.AddWithValue("@lu", lockoutTime);
                                lockCmd.Parameters.AddWithValue("@id", userId);
                                lockCmd.ExecuteNonQuery();

                                MessageBox.Show("Too many failed attempts. Account locked for 1 mins.");
                            }
                            else
                            {
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
            foreach (Control c in panelWelcome.Controls)
            {
                if (c != forgotpassUC) c.Visible = false; // hide other controls
            }

            forgotpassUC.Visible = true;
            forgotpassUC.BringToFront();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            forgotpassUC = new ForgotPasswordUC();
            panelWelcome.Controls.Add(forgotpassUC); // Add inside the panel, not the form
            forgotpassUC.Dock = DockStyle.Fill;      // Fill the panel completely
            forgotpassUC.Visible = false;
        }

      
    }
}

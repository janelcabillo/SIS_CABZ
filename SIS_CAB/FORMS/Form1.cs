using SIS_CAB.FORMS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SIS_CAB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Logger.Log("Login", $"User {username} logged in");
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT role_id FROM user_login WHERE username = @username AND password_hash = @password_hash";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password_hash", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int roleID = Convert.ToInt32(result);
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
                                MessageBox.Show("Unknown user.");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password! Pleaase try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

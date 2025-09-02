using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using SIS_CAB.FORMS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIS_CAB.USERCONTROLS
{
    public partial class StudentUC : UserControl
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private bool isUpdateMode = false;
        private int selectedStudentId = -1;
        public StudentUC(int userId, string username)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInUser = username;
            LoadStudents();
        }
        private void LoadStudentsWithSearch(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                string query = @"
            SELECT student_id, first_name, last_name, date_of_birth, gender,
                   email, phone, address, enrollment_date, status, user_id
            FROM student
            WHERE 
                student_id LIKE @search OR
                first_name LIKE @search OR
                last_name LIKE @search OR
                CONVERT(VARCHAR, date_of_birth, 23) LIKE @search OR
                gender LIKE @search OR
                email LIKE @search OR
                phone LIKE @search OR
                address LIKE @search OR
                CONVERT(VARCHAR, enrollment_date, 23) LIKE @search OR
                status LIKE @search
            ORDER BY student_id DESC
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter with wildcard for LIKE
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStudent.DataSource = dt;
                }
            }
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                string query = "SELECT * From Student WHERE status = 'Active' Order by student_id desc";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudent.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            dtpEnrollDate.Value = DateTime.Today;
        }

        private void StudentUC_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            cmbStatus.Visible = true;
            lblStatus.Visible = true;
            if (!panelAddStudent.Visible)
            {
                lblAddStudent.Text = "Add Student";  // title for add mode
                panelAddStudent.Visible = true;
                panelAddStudent.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errors.Add("First Name is required.");
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errors.Add("Last Name is required.");
            if (cmbGender.SelectedItem == null || string.IsNullOrWhiteSpace(cmbGender.SelectedItem?.ToString()))
                errors.Add("Gender is required.");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errors.Add("Email is required.");
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                errors.Add("Phone number is required.");
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                errors.Add("Address is required.");
            if (cmbStatus.SelectedItem == null || string.IsNullOrWhiteSpace(cmbStatus.SelectedItem?.ToString()))
                errors.Add("Status is required.");

            // if there are any errors, show them all at once
            if (errors.Count > 0)
            {
                MessageBox.Show(
                    "Please do check the following:\n\n" + string.Join("\n", errors),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();

                if (isUpdateMode && selectedStudentId > 0)
                {
                    // first get the linked user_id from the student table
                    int userId = -1;
                    using (SqlCommand cmdGetUserId = new SqlCommand("SELECT user_id FROM student WHERE student_id = @id", connection))
                    {
                        cmdGetUserId.Parameters.AddWithValue("@id", selectedStudentId);
                        object obj = cmdGetUserId.ExecuteScalar();
                        if (obj != null)
                            userId = Convert.ToInt32(obj);
                    }

                    // UPDATE student table
                    string updateQuery = @"UPDATE student SET  
                        first_name = @first_name,
                        last_name = @last_name,
                        date_of_birth = @dob,
                        gender = @gender,
                        email = @email,
                        phone = @phone,
                        address = @address,
                        enrollment_date = @enroll
                       WHERE student_id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@enroll", dtpEnrollDate.Value.Date);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@id", selectedStudentId);

                        cmd.ExecuteNonQuery();
                    }

                    // UPDATE user_login table (username & password)
                    if (userId > 0)
                    {
                        string updateUserQuery = @"UPDATE user_login 
                                   SET username = @username, 
                                       password_hash = @password_hash
                                   WHERE user_id = @user_id";
                        using (SqlCommand cmdUser = new SqlCommand(updateUserQuery, connection))
                        {
                            cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                            cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                            cmdUser.Parameters.AddWithValue("@user_id", userId);
                            cmdUser.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Student updated successfully!");
                    Logger.Log(_loggedInUserId, "Update Student", $"User {_loggedInUser} updated student {firstName} {lastName}.");
                }
                else
                {
                    // 1. Insert into user_login & get new user_id
                    string insertUserQuery = @"INSERT INTO user_login(username, password_hash, role_id) 
                                       VALUES (@username, @password_hash, @role_id); 
                                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newUserId;
                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, connection))
                    {
                        cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@role_id", 3);

                        newUserId = (int)cmdUser.ExecuteScalar();
                    }

                    // 2. Insert into student (student_id will be auto-generated by DB)
                    string insertStudentQuery = @"INSERT INTO student 
                                          (first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, user_id) 
                                          VALUES (@first_name, @last_name, @dob, @gender, @email, @phone, @address, @enrollment, @status, @user_id)";

                    using (SqlCommand cmdStudent = new SqlCommand(insertStudentQuery, connection))
                    {
                        cmdStudent.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmdStudent.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@enrollment", dtpEnrollDate.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmdStudent.Parameters.AddWithValue("@user_id", newUserId);

                        cmdStudent.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.Log(_loggedInUserId, "Add Student", $"User {_loggedInUser} added student {firstName} {lastName}.");
                    }
                }

                // this will reset form
                ClearFields();
                panelAddStudent.Visible = false;
                isUpdateMode = false;
                selectedStudentId = -1;

                // reload the data
                LoadStudents();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAddStudent.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            dtpEnrollDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbStatus.Visible = false;
            lblStatus.Visible = false;

            if (dgvStudent.SelectedRows.Count > 0)
            {
                // get selected student's ID
                selectedStudentId = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["student_id"].Value);

                // load data into form fields
                txtFirstName.Text = dgvStudent.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dgvStudent.SelectedRows[0].Cells["last_name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["date_of_birth"].Value);
                cmbGender.SelectedItem = dgvStudent.SelectedRows[0].Cells["gender"].Value.ToString();
                txtEmail.Text = dgvStudent.SelectedRows[0].Cells["email"].Value.ToString();
                txtPhone.Text = dgvStudent.SelectedRows[0].Cells["phone"].Value.ToString();
                txtAddress.Text = dgvStudent.SelectedRows[0].Cells["address"].Value.ToString();
                dtpEnrollDate.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["enrollment_date"].Value);
                cmbStatus.SelectedItem = dgvStudent.SelectedRows[0].Cells["status"].Value.ToString();

                // this enable update mode
                isUpdateMode = true;

                // change label text to "Update Student"
                lblAddStudent.Text = "Update Student";

                // shows the panel
                panelAddStudent.Visible = true;
                panelAddStudent.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow != null)
            {
                string firstName = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                string lastName = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                string studentId = dgvStudent.CurrentRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete student {firstName} {lastName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "UPDATE Student SET status = 'Inactive' WHERE student_id = @id";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadStudents();
                    MessageBox.Show($"Student {firstName} {lastName} marked as inactive successfully.");
                    Logger.Log(_loggedInUserId, "Deactivate Student", $"User {_loggedInUser} deactivated student {firstName} {lastName}.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudentsWithSearch(txtSearch.Text.Trim());
        }
    }
}

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

namespace SIS_CAB.FORMS
{
    public partial class TeacherUC : UserControl
    {
        private bool isUpdateMode = false;
        private int selectedTeacherId = -1;
        public TeacherUC()
        {
            InitializeComponent();
            LoadTeachers();
        }
        private void LoadTeachers(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                string query = @"
                    SELECT teacher_id, first_name, last_name, email, phone,
                           hire_date, department, specialization, status
                    FROM teacher
                    WHERE 
                        first_name LIKE @search OR
                        last_name LIKE @search OR
                        email LIKE @search OR
                        phone LIKE @search OR
                        CONVERT(NVARCHAR, hire_date, 23) LIKE @search OR
                        department LIKE @search OR
                        specialization LIKE @search OR
                        status LIKE @search
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTeacher.DataSource = dt; // your DataGridView
                }
            }
        }
        private void LoadTeachers()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                string query = "SELECT * From Teacher Order by teacher_id desc";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTeacher.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpHireDate.Value = DateTime.Today;
        }

        private void TeacherUC_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!panelAddTeacher.Visible)
            {
                lblAddTeacher.Text = "Add Teacher";  // 🔹 Title for Add mode
                panelAddTeacher.Visible = true;
                panelAddTeacher.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errors.Add("First Name is required.");
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errors.Add("Last Name is required.");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errors.Add("Email is required.");
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                errors.Add("Phone number is required.");
            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
                errors.Add("Department is required.");
            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
                errors.Add("Specialization is required.");
            if (cmbStatus.SelectedItem == null || string.IsNullOrWhiteSpace(cmbStatus.SelectedItem?.ToString()))
                errors.Add("Status is required.");

            // If there are any errors, show them all at once
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

                if (isUpdateMode && selectedTeacherId > 0)
                {
                    // 1. Get the linked user_id for this teacher
                    int userId = -1;
                    using (SqlCommand cmdGetUserId = new SqlCommand("SELECT user_id FROM teacher WHERE teacher_id = @id", connection))
                    {
                        cmdGetUserId.Parameters.AddWithValue("@id", selectedTeacherId);
                        object obj = cmdGetUserId.ExecuteScalar();
                        if (obj != null)
                            userId = Convert.ToInt32(obj);
                    }

                    // 2. Update teacher table
                    string updateQuery = @"UPDATE teacher SET  
                                            first_name = @first_name,
                                            last_name = @last_name,
                                            email = @email,
                                            phone = @phone,
                                            hire_date = @hire_date,
                                            department = @department,
                                            specialization = @specialization,
                                            status = @status
                                           WHERE teacher_id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@hire_date", dtpHireDate.Value.Date);
                        cmd.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@id", selectedTeacherId);

                        cmd.ExecuteNonQuery();
                    }

                    // 3. Update linked user_login table (if exists)
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

                    MessageBox.Show("Teacher updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmdUser.Parameters.AddWithValue("@role_id", 3); // Teacher role

                        newUserId = (int)cmdUser.ExecuteScalar();
                    }

                    // 2. Insert into teacher (teacher_id auto-generated by DB)
                    string insertTeacherQuery = @"INSERT INTO teacher 
                              (first_name, last_name, email, phone, hire_date, department, specialization, status, user_id) 
                              VALUES (@first_name, @last_name, @email, @phone, @hire_date, @department, @specialization, @status, @user_id)";

                    using (SqlCommand cmdTeacher = new SqlCommand(insertTeacherQuery, connection))
                    {
                        cmdTeacher.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@hire_date", dtpHireDate.Value.Date);
                        cmdTeacher.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmdTeacher.Parameters.AddWithValue("@user_id", newUserId);

                        cmdTeacher.ExecuteNonQuery();
                        MessageBox.Show("Teacher added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Reset form
                ClearFields();
                panelAddTeacher.Visible = false;
                isUpdateMode = false;
                selectedTeacherId = -1;

                // Reload teacher list
                LoadTeachers();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAddTeacher.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpHireDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                selectedTeacherId = Convert.ToInt32(dgvTeacher.SelectedRows[0].Cells["teacher_id"].Value);

                // Load data
                txtFirstName.Text = dgvTeacher.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dgvTeacher.SelectedRows[0].Cells["last_name"].Value.ToString();
                txtEmail.Text = dgvTeacher.SelectedRows[0].Cells["email"].Value.ToString();
                txtPhone.Text = dgvTeacher.SelectedRows[0].Cells["phone"].Value.ToString();
                dtpHireDate.Value = Convert.ToDateTime(dgvTeacher.SelectedRows[0].Cells["hire_date"].Value);
                txtDepartment.Text = dgvTeacher.SelectedRows[0].Cells["department"].Value.ToString();
                txtSpecialization.Text = dgvTeacher.SelectedRows[0].Cells["specialization"].Value.ToString();
                cmbStatus.SelectedItem = dgvTeacher.SelectedRows[0].Cells["status"].Value.ToString();

                // Update mode
                isUpdateMode = true;

                // 🔹 Change label text to "Update Teacher"
                lblAddTeacher.Text = "Update Teacher";

                // Show panel
                panelAddTeacher.Visible = true;
                panelAddTeacher.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a teacher to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                int teacherId = Convert.ToInt32(dgvTeacher.SelectedRows[0].Cells["teacher_id"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this teacher?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
                    {
                        connection.Open();

                        // Get linked user_id (optional step if you want to remove from user_login too)
                        int userId = -1;
                        string getUserIdQuery = "SELECT user_id FROM teacher WHERE teacher_id = @teacher_id";
                        using (SqlCommand cmdUserId = new SqlCommand(getUserIdQuery, connection))
                        {
                            cmdUserId.Parameters.AddWithValue("@teacher_id", teacherId);
                            object obj = cmdUserId.ExecuteScalar();
                            if (obj != null) userId = Convert.ToInt32(obj);
                        }

                        // Delete teacher record
                        string deleteTeacherQuery = "DELETE FROM teacher WHERE teacher_id = @teacher_id";
                        using (SqlCommand cmd = new SqlCommand(deleteTeacherQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                            cmd.ExecuteNonQuery();
                        }

                        // If linked, delete user_login record too
                        if (userId > 0)
                        {
                            string deleteUserQuery = "DELETE FROM user_login WHERE user_id = @user_id";
                            using (SqlCommand cmdUser = new SqlCommand(deleteUserQuery, connection))
                            {
                                cmdUser.Parameters.AddWithValue("@user_id", userId);
                                cmdUser.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Teacher deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachers();
                }
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTeachers(txtSearch.Text.Trim());
        }
    }
}

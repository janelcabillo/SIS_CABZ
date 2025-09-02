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
    public partial class Student : Form
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private string userStudent;
        public Student(int userId, string username)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInUser = username;
            this.userStudent = username;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            lblWelcomeStudent.Text = $"Welcome {userStudent}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Logger.Log(_loggedInUserId, "Logout", $"User {_loggedInUser} logged out.");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}

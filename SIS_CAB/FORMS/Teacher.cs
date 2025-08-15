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
    public partial class Teacher : Form
    {
        private string userTeacher;
        public Teacher(string teacher)
        {
            InitializeComponent();
            this.userTeacher = teacher;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            lblWelcomeTeacher.Text = $"Welcome {userTeacher}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}

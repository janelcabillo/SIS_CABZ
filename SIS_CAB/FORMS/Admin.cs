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
using SIS_CAB.USERCONTROLS;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SIS_CAB.FORMS
{
    public partial class Admin : Form
    {
        private string _loggedInUser;
        private string userAdmin;

        private StudentUC studentUC;
        private TeacherUC teacherUC;
        private DashboardUC dashboardUC;
        private LogsUC logsUC;
        public Admin(string username)
        {
            InitializeComponent();
            _loggedInUser = username;
            this.userAdmin = username;

            StudentUC studentUC = new StudentUC(_loggedInUser);
            studentUC.Visible = false;
            this.Controls.Add(studentUC);

            TeacherUC teacherUC = new TeacherUC(_loggedInUser);
            teacherUC.Visible = false;
            this.Controls.Add(teacherUC);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardUC dashboardUC = new DashboardUC();
            dashboardUC.Dock = DockStyle.Fill;
            dashboardUC.Margin = new Padding(0);
            dashboardUC.Padding = new Padding(0);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(dashboardUC);

            dashboardUC.LoadChart();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentUC studentUC = new StudentUC(_loggedInUser);
            studentUC.Dock = DockStyle.Fill;
            studentUC.Margin = new Padding(0);
            studentUC.Padding = new Padding(0);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(studentUC);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherUC teacherUC = new TeacherUC(_loggedInUser);
            teacherUC.Dock = DockStyle.Fill;
            teacherUC.Margin = new Padding(0);
            teacherUC.Padding = new Padding(0);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(teacherUC);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome {userAdmin}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Logger.Log("Logout", $"User {_loggedInUser} logged out");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LogsUC logsUC = new LogsUC();
            logsUC.Dock = DockStyle.Fill;
            logsUC.Margin = new Padding(0);
            logsUC.Padding = new Padding(0);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(logsUC);
        }
    }
}

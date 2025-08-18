namespace SIS_CAB.FORMS
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            lblWelcomeAdmin = new Label();
            btnDashboard = new Button();
            btnStudent = new Button();
            btnTeacher = new Button();
            btnSubject = new Button();
            btnLogs = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            panelContainer = new Panel();
            pbAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.BackColor = Color.Transparent;
            lblWelcomeAdmin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.Location = new Point(22, 84);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(122, 18);
            lblWelcomeAdmin.TabIndex = 0;
            lblWelcomeAdmin.Text = "Welcome Admin!";
            lblWelcomeAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(12, 117);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(141, 32);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStudent
            // 
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(12, 188);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(141, 32);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(12, 226);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(141, 32);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSubject
            // 
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(12, 264);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(141, 31);
            btnSubject.TabIndex = 4;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Location = new Point(12, 301);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(141, 31);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(12, 338);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(141, 32);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 406);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 32);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelContainer
            // 
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Location = new Point(159, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(629, 426);
            panelContainer.TabIndex = 8;
            // 
            // pbAdmin
            // 
            pbAdmin.Image = (Image)resources.GetObject("pbAdmin.Image");
            pbAdmin.Location = new Point(2, 12);
            pbAdmin.Name = "pbAdmin";
            pbAdmin.Size = new Size(151, 69);
            pbAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdmin.TabIndex = 11;
            pbAdmin.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(pbAdmin);
            Controls.Add(panelContainer);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnLogs);
            Controls.Add(btnSubject);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Controls.Add(btnDashboard);
            Controls.Add(lblWelcomeAdmin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pbAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeAdmin;
        private Button btnDashboard;
        private Button btnStudent;
        private Button btnTeacher;
        private Button btnSubject;
        private Button btnLogs;
        private Button btnReports;
        private Button btnLogout;
        private Panel panelContainer;
        private PictureBox pbAdmin;
    }
}
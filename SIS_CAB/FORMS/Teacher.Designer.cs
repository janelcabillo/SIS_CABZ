namespace SIS_CAB.FORMS
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            lblWelcomeTeacher = new Label();
            btnLogout = new Button();
            pbPPStudent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPPStudent).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.BackColor = Color.Transparent;
            lblWelcomeTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(30, 91);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(138, 18);
            lblWelcomeTeacher.TabIndex = 2;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 449);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(158, 41);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbPPStudent
            // 
            pbPPStudent.Image = (Image)resources.GetObject("pbPPStudent.Image");
            pbPPStudent.Location = new Point(49, 12);
            pbPPStudent.Name = "pbPPStudent";
            pbPPStudent.Size = new Size(81, 65);
            pbPPStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pbPPStudent.TabIndex = 11;
            pbPPStudent.TabStop = false;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(929, 502);
            Controls.Add(pbPPStudent);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeTeacher);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            ((System.ComponentModel.ISupportInitialize)pbPPStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeTeacher;
        private Button btnLogout;
        private PictureBox pbPPStudent;
    }
}
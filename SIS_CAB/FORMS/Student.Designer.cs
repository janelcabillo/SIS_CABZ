namespace SIS_CAB.FORMS
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            lblWelcomeStudent = new Label();
            btnLogout = new Button();
            pbStudent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStudent).BeginInit();
            SuspendLayout();
            // 
            // lblWelcomeStudent
            // 
            lblWelcomeStudent.AutoSize = true;
            lblWelcomeStudent.BackColor = Color.Transparent;
            lblWelcomeStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.Location = new Point(12, 89);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(136, 18);
            lblWelcomeStudent.TabIndex = 1;
            lblWelcomeStudent.Text = "Welcome Student!";
            lblWelcomeStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 406);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 32);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbStudent
            // 
            pbStudent.Image = (Image)resources.GetObject("pbStudent.Image");
            pbStudent.Location = new Point(-3, 12);
            pbStudent.Name = "pbStudent";
            pbStudent.Size = new Size(151, 69);
            pbStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pbStudent.TabIndex = 12;
            pbStudent.TabStop = false;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(pbStudent);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeStudent;
        private Button btnLogout;
        private PictureBox pbStudent;
    }
}
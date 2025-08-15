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
            lblWelcomeTeacher = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.BackColor = Color.Transparent;
            lblWelcomeTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(12, 88);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(138, 18);
            lblWelcomeTeacher.TabIndex = 2;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 406);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 32);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeTeacher);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeTeacher;
        private Button btnLogout;
    }
}
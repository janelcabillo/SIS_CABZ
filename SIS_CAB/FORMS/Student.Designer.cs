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
            lblWelcomeStudent = new Label();
            btnLogout = new Button();
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
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeStudent;
        private Button btnLogout;
    }
}
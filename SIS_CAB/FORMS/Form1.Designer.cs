namespace SIS_CAB
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pbSIS = new PictureBox();
            panel1 = new Panel();
            lblWelcome = new Label();
            lblLogin = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSIS).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbSIS
            // 
            pbSIS.Image = (Image)resources.GetObject("pbSIS.Image");
            pbSIS.Location = new Point(-81, -7);
            pbSIS.Name = "pbSIS";
            pbSIS.Size = new Size(553, 465);
            pbSIS.SizeMode = PictureBoxSizeMode.Zoom;
            pbSIS.TabIndex = 0;
            pbSIS.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(463, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 393);
            panel1.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.RoyalBlue;
            lblWelcome.Location = new Point(23, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(257, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to SIS";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(83, 78);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(130, 28);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login now!";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(42, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username:";
            txtUsername.Size = new Size(219, 25);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(42, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password:";
            txtPassword.Size = new Size(219, 25);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(83, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pbSIS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbSIS).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSIS;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLogin;
        private Label lblWelcome;
        private Button btnLogin;
    }
}

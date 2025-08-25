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
            panel1 = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLogin = new Label();
            lblWelcome = new Label();
            linklblForgotPass = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linklblForgotPass);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(273, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 393);
            panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(131, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(58, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password:";
            txtPassword.Size = new Size(276, 25);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(58, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username:";
            txtUsername.Size = new Size(276, 25);
            txtUsername.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(131, 91);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(130, 28);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login now!";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.RoyalBlue;
            lblWelcome.Location = new Point(58, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(276, 42);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to SIS";
            // 
            // linklblForgotPass
            // 
            linklblForgotPass.AutoSize = true;
            linklblForgotPass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklblForgotPass.Location = new Point(206, 229);
            linklblForgotPass.Name = "linklblForgotPass";
            linklblForgotPass.Size = new Size(128, 17);
            linklblForgotPass.TabIndex = 5;
            linklblForgotPass.TabStop = true;
            linklblForgotPass.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(929, 502);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLogin;
        private Label lblWelcome;
        private Button btnLogin;
        private LinkLabel linklblForgotPass;
    }
}

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
            panelWelcome = new Panel();
            linklblForgotPass = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLogin = new Label();
            lblWelcome = new Label();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // panelWelcome
            // 
            panelWelcome.BorderStyle = BorderStyle.Fixed3D;
            panelWelcome.Controls.Add(linklblForgotPass);
            panelWelcome.Controls.Add(btnLogin);
            panelWelcome.Controls.Add(txtPassword);
            panelWelcome.Controls.Add(txtUsername);
            panelWelcome.Controls.Add(lblLogin);
            panelWelcome.Controls.Add(lblWelcome);
            panelWelcome.Location = new Point(239, 41);
            panelWelcome.Margin = new Padding(3, 2, 3, 2);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(346, 296);
            panelWelcome.TabIndex = 1;
            // 
            // linklblForgotPass
            // 
            linklblForgotPass.AutoSize = true;
            linklblForgotPass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklblForgotPass.Location = new Point(180, 172);
            linklblForgotPass.Name = "linklblForgotPass";
            linklblForgotPass.Size = new Size(108, 15);
            linklblForgotPass.TabIndex = 5;
            linklblForgotPass.TabStop = true;
            linklblForgotPass.Text = "Forgot Password?";
            linklblForgotPass.LinkClicked += linklblForgotPass_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(115, 218);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(51, 151);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password:";
            txtPassword.Size = new Size(242, 21);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(51, 116);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username:";
            txtUsername.Size = new Size(242, 21);
            txtUsername.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(115, 68);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 23);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login now!";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.RoyalBlue;
            lblWelcome.Location = new Point(51, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(220, 33);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to SIS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(813, 376);
            Controls.Add(panelWelcome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelWelcome;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLogin;
        private Label lblWelcome;
        private Button btnLogin;
        private LinkLabel linklblForgotPass;
    }
}

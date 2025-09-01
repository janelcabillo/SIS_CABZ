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
            panelWelcome.Location = new Point(273, 55);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(407, 394);
            panelWelcome.TabIndex = 1;
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
            linklblForgotPass.LinkClicked += linklblForgotPass_LinkClicked;
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
            lblWelcome.Location = new Point(58, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(276, 42);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to SIS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(929, 501);
            Controls.Add(panelWelcome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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

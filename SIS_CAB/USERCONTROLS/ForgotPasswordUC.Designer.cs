namespace SIS_CAB.FORMS
{
    partial class ForgotPasswordUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblForgotPass = new Label();
            txtEmail = new TextBox();
            btnSendCode = new Button();
            btnCancel = new Button();
            btnverify = new Button();
            txtverify = new TextBox();
            pnl_password = new Panel();
            btnSubmit = new Button();
            txtconfirm = new TextBox();
            txtnew = new TextBox();
            label1 = new Label();
            pnl_password.SuspendLayout();
            SuspendLayout();
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPass.ForeColor = Color.Black;
            lblForgotPass.Location = new Point(77, 39);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(238, 32);
            lblForgotPass.TabIndex = 1;
            lblForgotPass.Text = "Forgot Password?";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(42, 98);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(309, 28);
            txtEmail.TabIndex = 2;
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.RoyalBlue;
            btnSendCode.FlatStyle = FlatStyle.Popup;
            btnSendCode.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendCode.Location = new Point(42, 134);
            btnSendCode.Margin = new Padding(3, 4, 3, 4);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(309, 40);
            btnSendCode.TabIndex = 3;
            btnSendCode.Text = "Send Code";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(42, 304);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(309, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnverify
            // 
            btnverify.BackColor = Color.RoyalBlue;
            btnverify.FlatStyle = FlatStyle.Popup;
            btnverify.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnverify.Location = new Point(42, 238);
            btnverify.Margin = new Padding(3, 4, 3, 4);
            btnverify.Name = "btnverify";
            btnverify.Size = new Size(309, 40);
            btnverify.TabIndex = 6;
            btnverify.Text = "Verify";
            btnverify.UseVisualStyleBackColor = false;
            btnverify.Click += btnverify_Click;
            // 
            // txtverify
            // 
            txtverify.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtverify.Location = new Point(42, 202);
            txtverify.Margin = new Padding(3, 4, 3, 4);
            txtverify.Name = "txtverify";
            txtverify.PlaceholderText = "xxxxxx";
            txtverify.Size = new Size(309, 28);
            txtverify.TabIndex = 5;
            // 
            // pnl_password
            // 
            pnl_password.Controls.Add(btnSubmit);
            pnl_password.Controls.Add(txtconfirm);
            pnl_password.Controls.Add(txtnew);
            pnl_password.Controls.Add(label1);
            pnl_password.Location = new Point(0, 0);
            pnl_password.Margin = new Padding(3, 4, 3, 4);
            pnl_password.Name = "pnl_password";
            pnl_password.Size = new Size(395, 528);
            pnl_password.TabIndex = 7;
            pnl_password.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RoyalBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(42, 270);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(309, 45);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Verify";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtconfirm
            // 
            txtconfirm.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfirm.Location = new Point(42, 202);
            txtconfirm.Margin = new Padding(3, 4, 3, 4);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.PlaceholderText = "Confirm Password:";
            txtconfirm.Size = new Size(309, 28);
            txtconfirm.TabIndex = 10;
            txtconfirm.UseSystemPasswordChar = true;
            // 
            // txtnew
            // 
            txtnew.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnew.Location = new Point(42, 146);
            txtnew.Margin = new Padding(3, 4, 3, 4);
            txtnew.Name = "txtnew";
            txtnew.PlaceholderText = "New Password:";
            txtnew.Size = new Size(309, 28);
            txtnew.TabIndex = 8;
            txtnew.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 71);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 7;
            label1.Text = "Create New Password";
            // 
            // ForgotPasswordUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(pnl_password);
            Controls.Add(btnverify);
            Controls.Add(txtverify);
            Controls.Add(btnCancel);
            Controls.Add(btnSendCode);
            Controls.Add(txtEmail);
            Controls.Add(lblForgotPass);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForgotPasswordUC";
            Size = new Size(395, 528);
            pnl_password.ResumeLayout(false);
            pnl_password.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForgotPass;
        private TextBox txtEmail;
        private Button btnSendCode;
        private Button btnCancel;
        private Button btnverify;
        private TextBox txtverify;
        private Panel pnl_password;
        private Button btnSubmit;
        private TextBox txtconfirm;
        private TextBox txtnew;
        private Label label1;
    }
}

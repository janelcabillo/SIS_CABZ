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
            lblEnterEmail = new Label();
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
            // lblEnterEmail
            // 
            lblEnterEmail.AutoSize = true;
            lblEnterEmail.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterEmail.ForeColor = Color.Black;
            lblEnterEmail.Location = new Point(85, 37);
            lblEnterEmail.Name = "lblEnterEmail";
            lblEnterEmail.Size = new Size(167, 33);
            lblEnterEmail.TabIndex = 1;
            lblEnterEmail.Text = "Enter Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(49, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(246, 29);
            txtEmail.TabIndex = 2;
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.RoyalBlue;
            btnSendCode.FlatStyle = FlatStyle.Popup;
            btnSendCode.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendCode.Location = new Point(49, 117);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(246, 40);
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
            btnCancel.Location = new Point(49, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(246, 40);
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
            btnverify.Location = new Point(49, 202);
            btnverify.Name = "btnverify";
            btnverify.Size = new Size(246, 40);
            btnverify.TabIndex = 6;
            btnverify.Text = "Verify";
            btnverify.UseVisualStyleBackColor = false;
            btnverify.Click += btnverify_Click;
            // 
            // txtverify
            // 
            txtverify.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtverify.Location = new Point(49, 167);
            txtverify.Name = "txtverify";
            txtverify.PlaceholderText = "Verify";
            txtverify.Size = new Size(246, 29);
            txtverify.TabIndex = 5;
            // 
            // pnl_password
            // 
            pnl_password.Controls.Add(btnSubmit);
            pnl_password.Controls.Add(txtconfirm);
            pnl_password.Controls.Add(txtnew);
            pnl_password.Controls.Add(label1);
            pnl_password.Location = new Point(40, 13);
            pnl_password.Name = "pnl_password";
            pnl_password.Size = new Size(255, 344);
            pnl_password.TabIndex = 7;
            pnl_password.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.RoyalBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(3, 172);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(246, 40);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Verify";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtconfirm
            // 
            txtconfirm.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfirm.Location = new Point(3, 126);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.PlaceholderText = "Verify";
            txtconfirm.Size = new Size(246, 29);
            txtconfirm.TabIndex = 10;
            // 
            // txtnew
            // 
            txtnew.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnew.Location = new Point(4, 76);
            txtnew.Name = "txtnew";
            txtnew.PlaceholderText = "Email:";
            txtnew.Size = new Size(246, 29);
            txtnew.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 7;
            label1.Text = "PASSWORD";
            // 
            // ForgotPasswordUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(pnl_password);
            Controls.Add(btnverify);
            Controls.Add(txtverify);
            Controls.Add(btnCancel);
            Controls.Add(btnSendCode);
            Controls.Add(txtEmail);
            Controls.Add(lblEnterEmail);
            Name = "ForgotPasswordUC";
            Size = new Size(346, 396);
            pnl_password.ResumeLayout(false);
            pnl_password.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterEmail;
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

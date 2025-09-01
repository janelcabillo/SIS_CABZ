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
            txtEmail.Location = new Point(49, 105);
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
            btnSendCode.Location = new Point(49, 162);
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
            btnCancel.Location = new Point(49, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(246, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ForgotPasswordUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(btnCancel);
            Controls.Add(btnSendCode);
            Controls.Add(txtEmail);
            Controls.Add(lblEnterEmail);
            Name = "ForgotPasswordUC";
            Size = new Size(346, 296);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterEmail;
        private TextBox txtEmail;
        private Button btnSendCode;
        private Button btnCancel;
    }
}

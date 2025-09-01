namespace SIS_CAB.FORMS
{
    partial class ResetPasswordUC
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
            lblCreateNewPass = new Label();
            txtNewPass = new TextBox();
            txtConfirmPass = new TextBox();
            btnReset = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCreateNewPass
            // 
            lblCreateNewPass.AutoSize = true;
            lblCreateNewPass.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNewPass.ForeColor = Color.Black;
            lblCreateNewPass.Location = new Point(37, 24);
            lblCreateNewPass.Name = "lblCreateNewPass";
            lblCreateNewPass.Size = new Size(267, 30);
            lblCreateNewPass.TabIndex = 3;
            lblCreateNewPass.Text = "Create New Password";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(47, 75);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PlaceholderText = "New Password:";
            txtNewPass.Size = new Size(246, 29);
            txtNewPass.TabIndex = 4;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(47, 120);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm Password:";
            txtConfirmPass.Size = new Size(246, 29);
            txtConfirmPass.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.RoyalBlue;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(47, 176);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(246, 40);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(47, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(246, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // ResetPasswordUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(btnCancel);
            Controls.Add(btnReset);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(lblCreateNewPass);
            Name = "ResetPasswordUC";
            Size = new Size(346, 296);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateNewPass;
        private TextBox txtNewPass;
        private TextBox txtConfirmPass;
        private Button btnReset;
        private Button btnCancel;
    }
}

namespace SIS_CAB.FORMS
{
    partial class VerificationCodeUC
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
            components = new System.ComponentModel.Container();
            lblVC = new Label();
            txtCode = new TextBox();
            btnVerify = new Button();
            btnCancel = new Button();
            lblCountdown = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblVC
            // 
            lblVC.AutoSize = true;
            lblVC.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVC.ForeColor = Color.Black;
            lblVC.Location = new Point(49, 40);
            lblVC.Name = "lblVC";
            lblVC.Size = new Size(243, 33);
            lblVC.TabIndex = 2;
            lblVC.Text = "Verification Code";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(49, 96);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "xxxxxx";
            txtCode.Size = new Size(246, 29);
            txtCode.TabIndex = 3;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.RoyalBlue;
            btnVerify.FlatStyle = FlatStyle.Popup;
            btnVerify.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerify.Location = new Point(49, 168);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(246, 40);
            btnVerify.TabIndex = 4;
            btnVerify.Text = "Veify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(49, 214);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(246, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountdown.Location = new Point(49, 137);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(75, 15);
            lblCountdown.TabIndex = 6;
            lblCountdown.Text = "CountDown:";
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick_1;
            // 
            // VerificationCodeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(lblCountdown);
            Controls.Add(btnCancel);
            Controls.Add(btnVerify);
            Controls.Add(txtCode);
            Controls.Add(lblVC);
            Name = "VerificationCodeUC";
            Size = new Size(346, 296);
            Load += VerificationCodeUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVC;
        private TextBox txtCode;
        private Button btnVerify;
        private Button btnCancel;
        private Label lblCountdown;
        private System.Windows.Forms.Timer Timer;
    }
}

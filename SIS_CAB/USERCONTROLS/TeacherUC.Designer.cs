namespace SIS_CAB.FORMS
{
    partial class TeacherUC
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
            dgvTeacher = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelAddTeacher = new Panel();
            txtSpecialization = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpHireDate = new DateTimePicker();
            lblHireDate = new Label();
            txtDepartment = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            lblAddTeacher = new Label();
            txtFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            panelAddTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(3, 3);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.Size = new Size(623, 315);
            dgvTeacher.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(26, 333);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(128, 37);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(253, 333);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 37);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(475, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 37);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelAddTeacher
            // 
            panelAddTeacher.BackColor = Color.Gray;
            panelAddTeacher.BorderStyle = BorderStyle.Fixed3D;
            panelAddTeacher.Controls.Add(txtSpecialization);
            panelAddTeacher.Controls.Add(btnCancel);
            panelAddTeacher.Controls.Add(btnSave);
            panelAddTeacher.Controls.Add(cmbStatus);
            panelAddTeacher.Controls.Add(lblStatus);
            panelAddTeacher.Controls.Add(dtpHireDate);
            panelAddTeacher.Controls.Add(lblHireDate);
            panelAddTeacher.Controls.Add(txtDepartment);
            panelAddTeacher.Controls.Add(txtPhone);
            panelAddTeacher.Controls.Add(txtEmail);
            panelAddTeacher.Controls.Add(txtLastName);
            panelAddTeacher.Controls.Add(lblAddTeacher);
            panelAddTeacher.Controls.Add(txtFirstName);
            panelAddTeacher.Location = new Point(346, 0);
            panelAddTeacher.Name = "panelAddTeacher";
            panelAddTeacher.Size = new Size(283, 384);
            panelAddTeacher.TabIndex = 5;
            panelAddTeacher.Visible = false;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(20, 240);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(238, 22);
            txtSpecialization.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(154, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 37);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(20, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 37);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(87, 268);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(171, 24);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(20, 276);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 16);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(87, 175);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(171, 22);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(20, 181);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(61, 16);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "HireDate:";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(20, 212);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(238, 22);
            txtDepartment.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(20, 138);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(238, 22);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(20, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(238, 22);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(20, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(238, 22);
            txtLastName.TabIndex = 2;
            // 
            // lblAddTeacher
            // 
            lblAddTeacher.Dock = DockStyle.Top;
            lblAddTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher.Location = new Point(0, 0);
            lblAddTeacher.Name = "lblAddTeacher";
            lblAddTeacher.Size = new Size(279, 37);
            lblAddTeacher.TabIndex = 1;
            lblAddTeacher.Text = "Add Teacher";
            lblAddTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(20, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(238, 22);
            txtFirstName.TabIndex = 0;
            // 
            // TeacherUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panelAddTeacher);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvTeacher);
            Name = "TeacherUC";
            Size = new Size(629, 384);
            Load += TeacherUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            panelAddTeacher.ResumeLayout(false);
            panelAddTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTeacher;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelAddTeacher;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private DateTimePicker dtpHireDate;
        private Label lblHireDate;
        private TextBox txtDepartment;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label lblAddTeacher;
        private TextBox txtFirstName;
        private TextBox txtSpecialization;
    }
}

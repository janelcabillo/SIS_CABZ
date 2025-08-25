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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherUC));
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
            txtSearch = new TextBox();
            pbSearchTeacher = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            panelAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchTeacher).BeginInit();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(3, 44);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.Size = new Size(722, 362);
            dgvTeacher.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(26, 423);
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
            btnUpdate.Location = new Point(306, 423);
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
            btnDelete.Location = new Point(572, 423);
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
            panelAddTeacher.Location = new Point(338, 0);
            panelAddTeacher.Name = "panelAddTeacher";
            panelAddTeacher.Size = new Size(390, 475);
            panelAddTeacher.TabIndex = 5;
            panelAddTeacher.Visible = false;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(211, 245);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(149, 25);
            txtSpecialization.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(223, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 57);
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
            btnSave.Location = new Point(31, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 57);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(91, 298);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(269, 25);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(31, 301);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(106, 190);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(254, 25);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(31, 196);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(69, 17);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "HireDate:";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(31, 245);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(149, 25);
            txtDepartment.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(211, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(149, 25);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(31, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(149, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(211, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(149, 25);
            txtLastName.TabIndex = 2;
            // 
            // lblAddTeacher
            // 
            lblAddTeacher.Dock = DockStyle.Top;
            lblAddTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher.Location = new Point(0, 0);
            lblAddTeacher.Name = "lblAddTeacher";
            lblAddTeacher.Size = new Size(386, 37);
            lblAddTeacher.TabIndex = 1;
            lblAddTeacher.Text = "Add Teacher";
            lblAddTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(31, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(149, 25);
            txtFirstName.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(59, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearchTeacher
            // 
            pbSearchTeacher.Image = (Image)resources.GetObject("pbSearchTeacher.Image");
            pbSearchTeacher.Location = new Point(26, 11);
            pbSearchTeacher.Name = "pbSearchTeacher";
            pbSearchTeacher.Size = new Size(27, 27);
            pbSearchTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchTeacher.TabIndex = 7;
            pbSearchTeacher.TabStop = false;
            // 
            // TeacherUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(pbSearchTeacher);
            Controls.Add(txtSearch);
            Controls.Add(panelAddTeacher);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvTeacher);
            Name = "TeacherUC";
            Size = new Size(728, 478);
            Load += TeacherUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            panelAddTeacher.ResumeLayout(false);
            panelAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtSearch;
        private PictureBox pbSearchTeacher;
    }
}

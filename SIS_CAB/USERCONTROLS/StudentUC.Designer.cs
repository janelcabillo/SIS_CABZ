namespace SIS_CAB.USERCONTROLS
{
    partial class StudentUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUC));
            dgvStudent = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelAddStudent = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollDate = new Label();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lblGender = new Label();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            lblAddStudent = new Label();
            txtFirstName = new TextBox();
            txtSearch = new TextBox();
            pbSearchStudent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(3, 44);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(623, 315);
            dgvStudent.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(26, 376);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(128, 37);
            btnAddNew.TabIndex = 1;
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
            btnUpdate.Location = new Point(260, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 37);
            btnUpdate.TabIndex = 2;
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
            btnDelete.Location = new Point(474, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelAddStudent
            // 
            panelAddStudent.BackColor = Color.Gray;
            panelAddStudent.BorderStyle = BorderStyle.Fixed3D;
            panelAddStudent.Controls.Add(btnCancel);
            panelAddStudent.Controls.Add(btnSave);
            panelAddStudent.Controls.Add(cmbStatus);
            panelAddStudent.Controls.Add(lblStatus);
            panelAddStudent.Controls.Add(dtpEnrollDate);
            panelAddStudent.Controls.Add(lblEnrollDate);
            panelAddStudent.Controls.Add(txtAddress);
            panelAddStudent.Controls.Add(cmbGender);
            panelAddStudent.Controls.Add(lblGender);
            panelAddStudent.Controls.Add(dtpDOB);
            panelAddStudent.Controls.Add(lblDOB);
            panelAddStudent.Controls.Add(txtPhone);
            panelAddStudent.Controls.Add(txtEmail);
            panelAddStudent.Controls.Add(txtLastName);
            panelAddStudent.Controls.Add(lblAddStudent);
            panelAddStudent.Controls.Add(txtFirstName);
            panelAddStudent.Location = new Point(346, 44);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(283, 382);
            panelAddStudent.TabIndex = 4;
            panelAddStudent.Visible = false;
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
            cmbStatus.Location = new Point(95, 270);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(163, 24);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(20, 278);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 16);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(95, 242);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(163, 22);
            dtpEnrollDate.TabIndex = 11;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(20, 247);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(71, 16);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "EnrollDate:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(20, 213);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(238, 22);
            txtAddress.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(95, 127);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(163, 24);
            cmbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(20, 135);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(53, 16);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(95, 99);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(163, 22);
            dtpDOB.TabIndex = 6;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(20, 105);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(65, 16);
            lblDOB.TabIndex = 5;
            lblDOB.Text = "DateBirth:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(20, 185);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(238, 22);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(20, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(238, 22);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(20, 71);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(238, 22);
            txtLastName.TabIndex = 2;
            // 
            // lblAddStudent
            // 
            lblAddStudent.Dock = DockStyle.Top;
            lblAddStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStudent.Location = new Point(0, 0);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(279, 40);
            lblAddStudent.TabIndex = 1;
            lblAddStudent.Text = "Add Student";
            lblAddStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(20, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(238, 22);
            txtFirstName.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(406, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearchStudent
            // 
            pbSearchStudent.Image = (Image)resources.GetObject("pbSearchStudent.Image");
            pbSearchStudent.Location = new Point(373, 11);
            pbSearchStudent.Name = "pbSearchStudent";
            pbSearchStudent.Size = new Size(27, 27);
            pbSearchStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchStudent.TabIndex = 6;
            pbSearchStudent.TabStop = false;
            // 
            // StudentUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(pbSearchStudent);
            Controls.Add(txtSearch);
            Controls.Add(panelAddStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvStudent);
            Name = "StudentUC";
            Size = new Size(629, 426);
            Load += StudentUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            panelAddStudent.ResumeLayout(false);
            panelAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelAddStudent;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label lblAddStudent;
        private TextBox txtFirstName;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private ComboBox cmbGender;
        private Label lblGender;
        private TextBox txtAddress;
        private Label lblStatus;
        private DateTimePicker dtpEnrollDate;
        private Label lblEnrollDate;
        private ComboBox cmbStatus;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtSearch;
        private PictureBox pbSearchStudent;
    }
}

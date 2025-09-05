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
            dgvStudent.Location = new Point(3, 33);
            dgvStudent.Margin = new Padding(3, 2, 3, 2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(632, 272);
            dgvStudent.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.Black;
            btnAddNew.Location = new Point(23, 317);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(92, 28);
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
            btnUpdate.Location = new Point(137, 317);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 28);
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
            btnDelete.Location = new Point(249, 317);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 28);
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
            panelAddStudent.Location = new Point(296, 0);
            panelAddStudent.Margin = new Padding(3, 2, 3, 2);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(342, 357);
            panelAddStudent.TabIndex = 4;
            panelAddStudent.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(195, 292);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 43);
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
            btnSave.Location = new Point(27, 292);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 43);
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
            cmbStatus.Location = new Point(93, 232);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(223, 23);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(27, 235);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(102, 190);
            dtpEnrollDate.Margin = new Padding(3, 2, 3, 2);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(213, 21);
            dtpEnrollDate.TabIndex = 11;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(27, 196);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(68, 15);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "EnrollDate:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(27, 151);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(131, 21);
            txtAddress.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(242, 151);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(73, 23);
            cmbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(185, 153);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(93, 80);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(223, 21);
            dtpDOB.TabIndex = 6;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(27, 86);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(54, 14);
            lblDOB.TabIndex = 5;
            lblDOB.Text = "DateBirth:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(185, 113);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(131, 21);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(27, 113);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(131, 21);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(185, 53);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(131, 21);
            txtLastName.TabIndex = 2;
            // 
            // lblAddStudent
            // 
            lblAddStudent.Dock = DockStyle.Top;
            lblAddStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStudent.Location = new Point(0, 0);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(338, 30);
            lblAddStudent.TabIndex = 1;
            lblAddStudent.Text = "Add Student";
            lblAddStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(27, 53);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(131, 21);
            txtFirstName.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(53, 5);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearchStudent
            // 
            pbSearchStudent.Image = (Image)resources.GetObject("pbSearchStudent.Image");
            pbSearchStudent.Location = new Point(24, 5);
            pbSearchStudent.Margin = new Padding(3, 2, 3, 2);
            pbSearchStudent.Name = "pbSearchStudent";
            pbSearchStudent.Size = new Size(23, 23);
            pbSearchStudent.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchStudent.TabIndex = 6;
            pbSearchStudent.TabStop = false;
            // 
            // StudentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(pbSearchStudent);
            Controls.Add(txtSearch);
            Controls.Add(panelAddStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentUC";
            Size = new Size(637, 358);
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

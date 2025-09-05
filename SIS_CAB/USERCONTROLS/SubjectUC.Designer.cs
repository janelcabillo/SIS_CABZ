namespace SIS_CAB.FORMS
{
    partial class SubjectUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectUC));
            dgvSubject = new DataGridView();
            txtSearch = new TextBox();
            pbSearchSubject = new PictureBox();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelAddStudent = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            lblAddSubject = new Label();
            txtCourseName = new TextBox();
            lblSubjectName = new Label();
            lblCourseCode = new Label();
            txtCourseCode = new TextBox();
            lblUnits = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchSubject).BeginInit();
            panelAddStudent.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(3, 33);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(632, 272);
            dgvSubject.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(53, 5);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(176, 23);
            txtSearch.TabIndex = 6;
            // 
            // pbSearchSubject
            // 
            pbSearchSubject.Image = (Image)resources.GetObject("pbSearchSubject.Image");
            pbSearchSubject.Location = new Point(24, 5);
            pbSearchSubject.Margin = new Padding(3, 2, 3, 2);
            pbSearchSubject.Name = "pbSearchSubject";
            pbSearchSubject.Size = new Size(23, 23);
            pbSearchSubject.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchSubject.TabIndex = 7;
            pbSearchSubject.TabStop = false;
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
            btnAddNew.Size = new Size(112, 28);
            btnAddNew.TabIndex = 8;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(268, 317);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 28);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(502, 317);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 28);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panelAddStudent
            // 
            panelAddStudent.BackColor = Color.Gray;
            panelAddStudent.BorderStyle = BorderStyle.Fixed3D;
            panelAddStudent.Controls.Add(lblUnits);
            panelAddStudent.Controls.Add(txtCourseCode);
            panelAddStudent.Controls.Add(lblCourseCode);
            panelAddStudent.Controls.Add(lblSubjectName);
            panelAddStudent.Controls.Add(txtCourseName);
            panelAddStudent.Controls.Add(btnCancel);
            panelAddStudent.Controls.Add(btnSave);
            panelAddStudent.Controls.Add(lblAddSubject);
            panelAddStudent.Location = new Point(296, 0);
            panelAddStudent.Margin = new Padding(3, 2, 3, 2);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(342, 357);
            panelAddStudent.TabIndex = 11;
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
            // 
            // lblAddSubject
            // 
            lblAddSubject.Dock = DockStyle.Top;
            lblAddSubject.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject.Location = new Point(0, 0);
            lblAddSubject.Name = "lblAddSubject";
            lblAddSubject.Size = new Size(338, 30);
            lblAddSubject.TabIndex = 1;
            lblAddSubject.Text = "Add Subject";
            lblAddSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(123, 64);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(192, 21);
            txtCourseName.TabIndex = 16;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(27, 66);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(93, 16);
            lblSubjectName.TabIndex = 17;
            lblSubjectName.Text = "Subject Name:";
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseCode.Location = new Point(27, 119);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(89, 16);
            lblCourseCode.TabIndex = 18;
            lblCourseCode.Text = "Subject Code:";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseCode.Location = new Point(124, 117);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(192, 21);
            txtCourseCode.TabIndex = 19;
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(27, 171);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(41, 16);
            lblUnits.TabIndex = 20;
            lblUnits.Text = "Units:";
            // 
            // SubjectUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panelAddStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearchSubject);
            Controls.Add(txtSearch);
            Controls.Add(dgvSubject);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubjectUC";
            Size = new Size(637, 358);
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchSubject).EndInit();
            panelAddStudent.ResumeLayout(false);
            panelAddStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubject;
        private TextBox txtSearch;
        private PictureBox pbSearchSubject;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelAddStudent;
        private Button btnCancel;
        private Button btnSave;
        private Label lblAddSubject;
        private Label lblUnits;
        private TextBox txtCourseCode;
        private Label lblCourseCode;
        private Label lblSubjectName;
        private TextBox txtCourseName;
    }
}

namespace SIS_CAB.USERCONTROLS
{
    partial class LogsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsUC));
            dgvLogs = new DataGridView();
            txtSearch = new TextBox();
            pbSearchLogs = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(3, 44);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(722, 431);
            dgvLogs.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(59, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearchLogs
            // 
            pbSearchLogs.Image = (Image)resources.GetObject("pbSearchLogs.Image");
            pbSearchLogs.Location = new Point(26, 11);
            pbSearchLogs.Name = "pbSearchLogs";
            pbSearchLogs.Size = new Size(27, 27);
            pbSearchLogs.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchLogs.TabIndex = 8;
            pbSearchLogs.TabStop = false;
            // 
            // LogsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(pbSearchLogs);
            Controls.Add(txtSearch);
            Controls.Add(dgvLogs);
            Name = "LogsUC";
            Size = new Size(728, 478);
            Load += LogsUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private TextBox txtSearch;
        private PictureBox pbSearchLogs;
    }
}

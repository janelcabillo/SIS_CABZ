using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SIS_CAB.FORMS;

namespace SIS_CAB.USERCONTROLS
{
    public partial class LogsUC : UserControl
    {
        public LogsUC()
        {
            InitializeComponent();
        }

        private void LogsUC_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
        private void LoadLogs()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                conn.Open();
                string query = "SELECT action_date AS [Date & Time], " +
                               "action_type AS [Action], " +
                               "description AS [Details] " +
                               "FROM logs ORDER BY action_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLogs.DataSource = dt; // dgvLogs should be inside LogsUC
            }
        }
    }
}

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
                string query = @"
            SELECT 
                l.action_date AS [Date & Time],
                r.role AS [Role],
                u.username AS [Username],
                l.action_type AS [Action],
                l.description AS [Details]
            FROM logs l
            LEFT JOIN user_login u ON l.user_id = u.user_id
            LEFT JOIN Role r ON u.role_id = r.role_id
            ORDER BY l.action_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLogs.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLogsWithSearch(txtSearch.Text.Trim());
        }
        private void LoadLogsWithSearch(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                l.action_date AS [Date & Time],
                r.role AS [Role],
                u.username AS [Username],
                l.action_type AS [Action],
                l.description AS [Details]
            FROM logs l
            LEFT JOIN user_login u ON l.user_id = u.user_id
            LEFT JOIN Role r ON u.role_id = r.role_id
            WHERE
                CONVERT(VARCHAR, l.action_date, 120) LIKE @search OR
                CONVERT(VARCHAR, l.action_date, 101) LIKE @search OR
                r.role LIKE @search OR
                u.username LIKE @search OR
                l.action_type LIKE @search OR
                l.description LIKE @search
            ORDER BY l.action_date DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLogs.DataSource = dt;
                }
            }
        }
    }
}

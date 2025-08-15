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
using System.Windows.Forms.DataVisualization.Charting;

namespace SIS_CAB.FORMS
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void chartDashboard_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
        public void LoadChart()
        {
            int StudentCount = 0;
            int TeacherCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
                {
                    connection.Open();

                    SqlCommand cmdStudent = new SqlCommand("SELECT COUNT(*) FROM student", connection);
                    StudentCount = (int)cmdStudent.ExecuteScalar();

                    SqlCommand cmdTeacher = new SqlCommand("SELECT COUNT(*) FROM teacher", connection);
                    TeacherCount = (int)cmdTeacher.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data" + ex.Message);
            }
            chartDashboard.Series.Clear();

            Series pieSeries = new Series("Counts");
            pieSeries.ChartType = SeriesChartType.Pie;
            pieSeries.IsValueShownAsLabel = true;
            pieSeries.Points.AddXY("Students", StudentCount);
            pieSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard.Series.Add(pieSeries);
        }
    }
}

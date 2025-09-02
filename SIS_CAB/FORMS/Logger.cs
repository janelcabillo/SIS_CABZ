using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace SIS_CAB.FORMS
{
    internal class Logger
    {
        private static string connectionString = DatabaseConnection.connectionString;

        public static void Log(int? userId, string actionType, string description)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertLog = "INSERT INTO logs (action_date, action_type, description, user_id) " +
                                       "VALUES (@date, @action, @description, @userId)";

                    using (SqlCommand cmd = new SqlCommand(insertLog, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@action", actionType);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@userId", (object)userId ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving log: " + ex.Message);
            }
        }
    }
}

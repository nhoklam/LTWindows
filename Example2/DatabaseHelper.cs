using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Example
{
    public class DatabaseHelper
    {
        // Thay Server=. bằng Server=D20915 (lấy từ hình ảnh của bạn)
        private static string strConnect = "Server=D20915;Database=QuanLyToaNha_DB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(strConnect);
        }

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public static void ExecuteQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
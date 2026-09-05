using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace KrishiSetuPro.Helpers
{
    /// <summary>
    /// Central place for all database access using ADO.NET (SqlConnection / SqlCommand).
    /// </summary>
    public static class DBHelper
    {
        private static string ConnStr
        {
            get { return ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString; }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                cn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}

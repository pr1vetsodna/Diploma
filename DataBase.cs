using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DiplomaWinForms
{
    public static class DataBase
    {
        public static DataSet ds = new DataSet();
        public static DataTable tablesNames = new DataTable();
        static SqlConnectionStringBuilder build = new SqlConnectionStringBuilder()
        {
            DataSource = ConfigurationManager.AppSettings["ServerName"],
            InitialCatalog = ConfigurationManager.AppSettings["CatalogName"],
            IntegratedSecurity = true,
            Encrypt = false,
        };
        static readonly SqlConnection conn = new SqlConnection(build.ConnectionString);
        public static SqlConnection GetConnection()
        {
            return conn;
        }
        public static void OpenConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                msg.Error(ex.ToString());
            }
        }
        public static void CloseConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            catch (SqlException ex)
            {
                msg.Error(ex.ToString());
            }
        }

        public static void RefreshDS()
        {
            ds.Reset();
            OpenConnection();
            try
            {
                SqlDataReader reader = Cmd("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE'").ExecuteReader();
                List<string> tables = new List<string>();
                while (reader.Read())
                    tables.Add(reader.GetString(0));
                foreach (string table in tables)
                    Adapter($"select * from {table}").Fill(ds, table);

            }
            catch (Exception ex)
            {
                msg.Error(ex.ToString());
            }
        }

        public static SqlDataAdapter Adapter(string sqlExpression)
        {
            try
            {
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, conn);
                CloseConnection();
                return adapter;
            }
            catch (SqlException ex)
            {
                msg.Error(ex.ToString());
                return null;
            }
        }

        public static SqlCommand Cmd(string sqlExpression)
        {
            return new SqlCommand(sqlExpression, conn);
        }
    }
}

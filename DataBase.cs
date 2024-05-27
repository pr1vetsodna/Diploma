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
            MultipleActiveResultSets = true,
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
                while (reader.Read())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter($"select * from {reader.GetString(0)}", conn);
                    adapter.Fill(ds, reader.GetString(0));
                }
                reader.Close();

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

        class Control
        {
            static void Insert(DataTable Table, string Arguments, string Values)
            {
                OpenConnection();
                try
                {
                    Cmd($"INSERT INTO {Table.TableName} ({Arguments}) values ({Values})").ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    msg.Error("Не удалось добавить данные!\n\n" + ex.Message);
                }
                CloseConnection();
            }
        }
    }
}

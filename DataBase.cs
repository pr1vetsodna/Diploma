using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace DiplomaWinForms
{
    public static class DataBase
    {
        public static DataSet ds = new DataSet();
        public static DataSet tablesNames = new DataSet();
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
                msg.Error("Не удалось подключиться к базе данных!\n\n" + ex.ToString());
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
                msg.Error("Не удалось закрыть соединение с базой данных!\n\n" + ex.ToString());
            }
        }

        public static void RefreshDS()
        {
            ds.Reset();
            tablesNames.Reset();
            OpenConnection();
            try
            {
                SqlDataReader tableReader = Cmd("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE'").ExecuteReader();
                while (tableReader.Read())
                {
                    string tableName = tableReader.GetString(0);
                    SqlDataAdapter adapterTable = new SqlDataAdapter($"SELECT * FROM {tableName}", conn);
                    SqlDataAdapter adapterColumns = new SqlDataAdapter($"SELECT c.name AS 'column', c.is_identity as auto_inc FROM sys.columns c INNER JOIN sys.tables t ON c.object_id = t.object_id WHERE t.name = '{tableName}'", conn);
                    adapterColumns.Fill(tablesNames, tableName);
                    adapterTable.Fill(ds, tableName);
                }
                tableReader.Close();
            }
            catch (Exception ex)
            {
                msg.Error("Ошибка при обновлении базы данных!\n\n" + ex.ToString());
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

        public static class Control
        {
            public static void Insert(DataTable Table, List<string> Arguments, List<string> Values)
            {
                string queryArg = null, queryVal = null;
                for (int i = 0; i < Arguments.Count; i++)
                    if (!Convert.ToBoolean(tablesNames.Tables[Table.TableName].Rows[i]["auto_inc"]))
                    {
                        queryArg += Arguments[i] + ", ";
                        queryVal += Values[i] + ", ";
                    }
                queryArg = queryArg.Remove(queryArg.Length - 2);
                queryVal = queryVal.Remove(queryVal.Length - 2);
                OpenConnection();
                try
                {
                    Cmd($"INSERT INTO {Table.TableName} ({queryArg}) values ({queryVal})").ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    msg.Error("Не удалось добавить данные!\n\n" + ex.Message);
                }
                CloseConnection();
                RefreshDS();
            }
            public static void Update(DataTable Table, List<string> Arguments, List<string> Values)
            {
                string query = null;
                for (int i = 0; i < Arguments.Count; i++)
                    if (!Convert.ToBoolean(tablesNames.Tables[Table.TableName].Rows[i]["auto_inc"]))
                        query += $"{Arguments[i]} = {Values[i]}, ";
                query = query.Remove(query.Length - 2);
                string ID = Values[0];
                OpenConnection();
                try
                {
                    Cmd($"UPDATE {Table.TableName} SET {query} WHERE ID = {ID}").ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    msg.Error("Не удалось обновить данные!\n\n" + ex.Message);
                }
                CloseConnection();
                RefreshDS();
            }
            public static void Delete (DataTable Table, string ID)
            {
                OpenConnection();
                try
                {
                    Cmd($"DELETE FROM {Table.TableName} WHERE ID = {ID}").ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    msg.Error("Не удалось удалить строку!\n\n" + ex.Message);
                }
                CloseConnection();
                RefreshDS();
            }
        }
    }
}
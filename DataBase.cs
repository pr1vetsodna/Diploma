﻿using System;
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
                msg.Error("Не удалось подключиться к базе данных!\n\n"+ex.ToString());
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
                msg.Error("Не удалось закрыть соединение с базой данных!\n\n"+ex.ToString());
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

        public static class Control
        {
            public static void Insert(DataTable Table, List<string> Arguments, List<string> Values)
            {
                OpenConnection();
                try
                {
                    string queryArg = null, queryVal = null;
                    foreach (string arg in Arguments)
                        queryArg += arg + ", ";
                    foreach (string val in Values)
                        queryVal += val + ", ";
                    Cmd($"INSERT INTO {Table.TableName} ({queryArg.Remove(queryArg.Length -2)}) values ({queryVal.Remove(queryVal.Length-2)})").ExecuteNonQuery();
                    RefreshDS();
                }
                catch(Exception ex)
                {
                    msg.Error("Не удалось добавить данные!\n\n" + ex.Message);
                }
                CloseConnection();
            }
            public static void Update(DataTable Table, List<string> Arguments, List<string> Values)
            {
                //OpenConnection();
                //try
                //{

                //    Cmd($"UPDATE {Table.TableName}");
                //}
            }

        }
    }
}

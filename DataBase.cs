using System;
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
        public static void OpenConnection(SqlConnection conn)
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
            try
            {
                ds.Clear();
                tablesNames.Clear();
                Adapter("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE'").Fill(tablesNames);
                foreach (DataRow table in tablesNames.Rows)
                    Adapter($"select * from {table[0].ToString()}").Fill(ds, table[0].ToString());
            }
            catch (Exception ex)
            {
                msg.Error(ex.ToString());
            }
            //db.TablesName().Fill(db.tablesNames);
            //for (int table = 0; table < db.tablesNames.Rows.Count; table++)
            //{
            //    listBoxTables.Items.Add(db.tablesNames.Rows[table][0].ToString());
            //    db.Adapter($"select * from {db.tablesNames.Rows[table][0]}").Fill(db.ds, db.tablesNames.Rows[table][0].ToString());

            //    List<Control> controls = new List<Control>(); // Инициализируем массив
            //                                                  //listBoxTables.Items.Add(ds.Tables[table].TableName);

            //    for (int column = 0; column < db.ds.Tables[table].Columns.Count; column++)
            //    {
            //        controls.Add(arg.Label(db.ds.Tables[table].Columns[column].ToString()));
            //        controls.Add(arg.Field(db.ds.Tables[table].Columns[column].ToString(), db.ds.Tables[table].Columns[column].DataType));
            //    }
            //    tableControls.Add(controls);
            //}
        }

        public static SqlDataAdapter Adapter(string sqlExpression)
        {
            try
            {
                OpenConnection(conn);
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

        public static SqlDataReader Reader(string sqlExpression)
        {
            OpenConnection(conn);
            SqlCommand cmd = new SqlCommand(sqlExpression, conn);
            CloseConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return reader;
            else return null;
        }

        public static void cmd(string sqlExpression)
        {
            OpenConnection(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(sqlExpression, GetConnection());
            }
            catch (SqlException ex)
            {
                msg.Error(ex.ToString());
            }
            CloseConnection();


        }
    }
}

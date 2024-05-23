using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace DiplomaWinForms
{
    public class DataBase
    {
        Messages msg = new Messages();
        static SqlConnectionStringBuilder build = new SqlConnectionStringBuilder()
        {
            DataSource = "KOMPUTER\\SQLEXPRESS",
            InitialCatalog = "PhoneBook",
            IntegratedSecurity = true,
            Encrypt = false,
        };

        SqlConnection conn = new SqlConnection(build.ConnectionString);

        SqlConnection GetConnection() {
            return conn;
        }

        public void OpenConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch (Exception ex)
            {
                msg.Error(ex.ToString());
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            catch (Exception ex)
            {
                msg.Error(ex.ToString());
            }
        }
        
        public SqlDataAdapter Adapter(string sqlExpression)
        {
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, conn);
            CloseConnection();
            return adapter;
        }

        public SqlDataReader Reader(string sqlExpression)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sqlExpression, conn);
            CloseConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return reader;
            else return null;
        }
        public SqlDataAdapter TablesName()
        {
            return Adapter("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE'");
        }
    }
}

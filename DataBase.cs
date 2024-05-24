using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DiplomaWinForms
{
    public class DataBase
    {
        public DataSet ds = new DataSet();
        public DataTable tablesNames = new DataTable();
        Messages msg = new Messages();
        static SqlConnectionStringBuilder build = new SqlConnectionStringBuilder()
        {
            DataSource = "KOMPUTER\\SQLEXPRESS",
            InitialCatalog = "PhoneBook",
            IntegratedSecurity = true,
            Encrypt = false,
        };

        public SqlConnection conn = new SqlConnection(build.ConnectionString);

        public SqlConnection GetConnection() {
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

        public void RefreshDS()
        {
            try
            {
                tablesNames.Clear();
                ds.Clear();
                Adapter("SELECT table_name FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE'").Fill(tablesNames);
                foreach (DataRow table in tablesNames.Rows)
                    Adapter($"select * from {table[0].ToString()}").Fill(ds, table[0].ToString());
            } catch (Exception ex)
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
    }
}

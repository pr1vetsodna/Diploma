using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWinForms
{
    public partial class Main : Form
    {
        string currentTable;
        Messages messages = new Messages();
        DataSet ds = new DataSet();
        DataBase db = new DataBase();
        int[] controls;
        bool isChangingTable;
        public Main()
        {
            InitializeComponent();
        }

        Control Arguments(string ArgName, Type type)
        {
            tableLayoutPanelArguments.RowCount++;
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleRight;
            label.AutoSize = true;
            label.Dock = DockStyle.Right;
            label.Text = ArgName + type.ToString();
            if (type != typeof(string))
            {
                if (type == typeof(DateTime))
                {
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Dock = DockStyle.Fill;
                    dtp.Name = ArgName;
                    return dtp;
                }
                if (type == typeof(int) || type == typeof(Int64))
                {
                    NumericUpDown numeric = new NumericUpDown();
                    numeric.Dock = DockStyle.Fill;
                    numeric.Name = ArgName;
                    numeric.Maximum = Int64.MaxValue;
                    return numeric;
                }
                
            }
            else
            {

                TextBox textBox = new TextBox();
                textBox.Dock = DockStyle.Fill;
                textBox.Name = ArgName;
                return textBox;
            }
            return label;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.TablesName().Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                db.Adapter($"select * from {dt.Rows[i][0]}").Fill(ds, dt.Rows[i][0].ToString());
                listBoxTables.Items.Add(dt.Rows[i][0]);
                Control[] controls = new Control[ds.Tables[i].Columns.Count*2];
            }
            if (listBoxTables.Items.Count > 0)
                listBoxTables.SelectedIndex = 0;
        }

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO {currentTable} (";
            for (int i = 0; i < dataGridViewMain.Columns.Count; i++)
                query = $"{query}{dataGridViewMain.Columns[i].Name}, ";
            query = query.Remove(query.Length - 2);
            query = query + ") values (";
            messages.Error(query);
        }
        private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            if (!isChangingTable)
            {
                foreach (DataGridViewColumn column in dataGridViewMain.Columns)
                    messages.Error(column.Name);
            }
        }
    }
}

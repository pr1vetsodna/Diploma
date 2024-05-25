using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.CodeDom;
using Label = System.Windows.Forms.Label;

namespace DiplomaWinForms
{
    public partial class Main : Form
    {
        Messages msg = new Messages();
        public DataBase db = new DataBase();
        bool isChangingTable;
        string currentTable;
        List<List<List<Control>>> Tables = new List<List<List<Control>>>();
        List<List<Control>> Rows = new List<List<Control>>();

        public Main()
        {
            InitializeComponent();
        }

        private List<List<List<Control>>> pages = new List<List<List<Control>>>();

        class Row
        {
            public List<Control> Add(string Name, Type Type)
            {
                List<Control> list = new List<Control>
                {
                    CreateLabel(Name),
                    CreateControl(Name, Type)
                };
                return list;
            }
            static Label CreateLabel(string Name)
            {
                Label label = new Label();
                label.Name = "label" + Name;
                label.AutoSize = true;
                label.Anchor = AnchorStyles.Right;
                if (Name != null)
                    label.Text = Name;
                else
                    label.Text = "null";
                return label;
            }

            static Control CreateControl(string Name, Type Type)
            {
                Control control = new Control();
                if (Type == typeof(DateTime))
                    control = new DateTimePicker();
                else if (Type == typeof(int) || Type == typeof(Int64))
                {
                    control = new NumericUpDown();
                    if (control is NumericUpDown numeric)
                        numeric.Maximum = Int64.MaxValue;
                }
                else
                    control = new TextBox();
                control.Name = "control" + Name;
                control.Dock = DockStyle.Fill;
                control.Width = 100;
                return control;
            }
        }

        void RefreshUI()
        {

            listBoxTables.Items.Clear();
            db.RefreshDS();
            pages.Clear();
            int maxWidthLabel = 0, maxWidthField = 0;

            for (int table = 0; table < db.tablesNames.Rows.Count; table++)
            {
                listBoxTables.Items.Add(db.tablesNames.Rows[table][0].ToString());
                List<List<Control>> rows = new List<List<Control>>();
                foreach (DataColumn column in db.ds.Tables[table].Columns)
                {
                    Row row = new Row();
                    rows.Add(row.Add(column.ColumnName, column.DataType));
                    if (rows.Count >0)
                    {
                        if (rows[rows.Count - 1][0].Width > maxWidthLabel)
                            maxWidthLabel = rows[rows.Count - 1][0].Width;
                        if (rows[rows.Count - 1][1].Width > maxWidthField)
                            maxWidthField = rows[rows.Count - 1][1].Width;
                    }
                }
                pages.Add(rows);
            }
            //TableLayoutPanelLeft.Width = maxWidthField + maxWidthLabel;
            if (listBoxTables.Items.Count > 0)
                listBoxTables.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }



        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //isChangingTable = true;
            //currentTable = listBoxTables.SelectedItem.ToString();
            //tableLayoutPanelArguments.Controls.Clear();
            //tableLayoutPanelArguments.RowStyles.Clear();
            //tableLayoutPanelArguments.RowCount = 1;
            //tableLayoutPanelArguments.RowCount += db.ds.Tables[currentTable].Columns.Count;
            //for (int i = 0; i < tableLayoutPanelArguments.RowCount; i++)
            //    tableLayoutPanelArguments.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //tableLayoutPanelArguments.Controls.AddRange(pages[listBoxTables.SelectedIndex][db.ds.Tables[currentTable].Columns.].ToArray());
            //dataGridViewMain.DataSource = db.ds.Tables[currentTable];
            //isChangingTable = false;
            //Console.WriteLine($"Строк в панели: {tableLayoutPanelArguments.RowCount}\n" +
            //    $"Количество полей: {tableLayoutPanelArguments.Controls.Count / 2}");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO {currentTable} (";
            foreach (DataColumn col in db.ds.Tables[currentTable].Columns)
                query = $"{query}{col.ColumnName}, ";
            query = query.Remove(query.Length - 2);
            query += ") values (";
            foreach (DataColumn column in db.ds.Tables[currentTable].Columns)
                if (tableLayoutPanelArguments.Controls[column.ColumnName].GetType() != typeof(System.Windows.Forms.Label))
                {
                    if (column.DataType == typeof(string))
                        query += $"'{tableLayoutPanelArguments.Controls[column.ColumnName].Text}', ";
                    else
                        query += $"{tableLayoutPanelArguments.Controls[column.ColumnName].Text}, ";
                }
            query = query.Remove(query.Length - 2);
            query += ")";
            if (msg.Question("Скопировать запрос?", query))
                Clipboard.SetText(query);
            db.cmd(query);
            RefreshUI();

        }
        private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            if (!isChangingTable && dataGridViewMain.CurrentRow != null)
                foreach (DataColumn col in db.ds.Tables[currentTable].Columns)
                    if (dataGridViewMain.CurrentRow.Cells[col.ColumnName].Value != DBNull.Value)
                        tableLayoutPanelArguments.Controls["control" + col.ColumnName].Text = dataGridViewMain.CurrentRow.Cells[col.ColumnName].Value.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
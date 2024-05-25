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

namespace DiplomaWinForms
{
    public partial class Main : Form
    {
        List<List<Control>> fields = new List<List<Control>>();
        Messages msg = new Messages();
        public DataBase db = new DataBase();
        bool isChangingTable;
        string currentTable;
        public Main()
        {
            InitializeComponent();
        }

        public class Argument
        {
            public string Name { get; set; }
            public Type Type { get; set; }
            public System.Windows.Forms.Label CreateLabel()
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                label.Name = "label" + Name;
                label.Text = Name;
                label.AutoSize = true;
                label.Anchor = AnchorStyles.Right;
                return label;
            }
            public Control CreateField()
            {
                Control control = null;
                if (Type == typeof(DateTime))
                    control = new DateTimePicker();
                else if (Type == typeof(int) || Type == typeof(Int64))
                    control = new NumericUpDown();
                else
                    control = new TextBox();
                control.Name = "control" + Name;
                control.Dock = DockStyle.Fill;
                return control;
            }
        }


        void RefreshUI()
        {
            listBoxTables.Items.Clear();
            db.RefreshDS();
            int maxWidthLabel = 0, maxWidthField = 0;
            for (int table = 0; table < db.tablesNames.Rows.Count; table++)
            {
                listBoxTables.Items.Add(db.tablesNames.Rows[table][0].ToString());
                List<Control> field = new List<Control>();
                for (int column = 0; column < db.ds.Tables[table].Columns.Count; column++)
                {
                    Argument argument = new Argument
                    {
                        Name = db.ds.Tables[table].Columns[column].ToString(),
                        Type = db.ds.Tables[table].Columns[column].DataType
                    };
                    System.Windows.Forms.Label label = argument.CreateLabel();
                    Control control = argument.CreateField();
                    if (label.Width > maxWidthLabel)
                        maxWidthLabel = label.Width;
                    if (control.Width > maxWidthField)
                        maxWidthField = control.Width;
                    field.Add(label);
                    field.Add(control);

                }
                fields.Add(field);
            }
            TableLayoutPanelLeft.Width = maxWidthLabel + maxWidthField + tableLayoutPanelArguments.Margin.Right;
            if (listBoxTables.Items.Count > 0)
                listBoxTables.SelectedIndex = 0;


            //foreach (List<Control> field in fields)
            //{
            //    foreach (Control control in field)
            //    {
            //        if (control is Label)
            //        {
            //            if (control.Width > maxWidthLabel)
            //                maxWidthLabel = control.Width;
            //        } else
            //            if (control.Width > maxWidthField)
            //                maxWidthField = control.Width;
            //    }
            //}


        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }



        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChangingTable = true;
            currentTable = listBoxTables.SelectedItem.ToString();
            tableLayoutPanelArguments.Controls.Clear();
            tableLayoutPanelArguments.RowStyles.Clear();
            tableLayoutPanelArguments.RowCount = 1;
            tableLayoutPanelArguments.RowCount += db.ds.Tables[currentTable].Columns.Count;
            for (int i = 0; i < tableLayoutPanelArguments.RowCount; i++)
                tableLayoutPanelArguments.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelArguments.Controls.AddRange(fields[listBoxTables.SelectedIndex].ToArray());
            dataGridViewMain.DataSource = db.ds.Tables[currentTable];
            isChangingTable = false;
            Console.WriteLine($"Строк в панели: {tableLayoutPanelArguments.RowCount}\n" +
                $"Количество полей: {tableLayoutPanelArguments.Controls.Count / 2}");
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
                        tableLayoutPanelArguments.Controls[col.ColumnName].Text = dataGridViewMain.CurrentRow.Cells[col.ColumnName].Value.ToString();
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
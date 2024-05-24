using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
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

        class arguments
        {
            public Control Label(string ArgName)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Anchor = AnchorStyles.Right;
                if (ArgName != null)
                    label.Text = ArgName;
                else
                    label.Text = "null";
                return label;
            }
            public Control Field(string ArgName, Type type)
            {

                if (type == typeof(DateTime))
                {
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Dock = DockStyle.Fill;
                    dtp.Name = ArgName;
                    return dtp;
                }
                else if (type == typeof(int) || type == typeof(Int64))
                {
                    NumericUpDown numeric = new NumericUpDown();
                    numeric.Dock = DockStyle.Fill;
                    numeric.Name = ArgName;
                    numeric.Maximum = Int64.MaxValue;
                    return numeric;
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Dock = DockStyle.Fill;
                    textBox.Name = ArgName;
                    return textBox;
                }
            }
            //public Control Add(string ArgName, Type type)
            //{
            //    TableLayoutPanel tlp = new TableLayoutPanel();
            //    tlp.ColumnCount = 2;
            //    tlp.RowCount = 1;
            //    tlp.Dock = DockStyle.Top;
            //    tlp.AutoSize = true;
            //    tlp.Controls.Add(Label(ArgName));
            //    tlp.Controls.Add(Field(ArgName, type));
            //    return tlp;
            //}
        }

        void RefreshUI()
        {
            arguments arg = new arguments();
            listBoxTables.Items.Clear();
            db.RefreshDS();
            int maxWidthLabel = 0, maxWidthField = 0;
            for (int table = 0; table < db.tablesNames.Rows.Count; table++)
            {
                listBoxTables.Items.Add(db.tablesNames.Rows[table][0].ToString());
                List<Control> field = new List<Control>();
                for (int column = 0; column < db.ds.Tables[table].Columns.Count; column++)
                {
                    Label label = (Label)arg.Label(db.ds.Tables[table].Columns[column].ToString());
                    Control control = arg.Field(db.ds.Tables[table].Columns[column].ToString(), db.ds.Tables[table].Columns[column].DataType);
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
            tableLayoutPanelArguments.RowCount = 0;
            foreach (DataColumn column in db.ds.Tables[currentTable].Columns)
            {
                tableLayoutPanelArguments.RowCount++;
                tableLayoutPanelArguments.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            tableLayoutPanelArguments.RowCount++;
            tableLayoutPanelArguments.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelArguments.Controls.AddRange(fields[listBoxTables.SelectedIndex].ToArray());
            dataGridViewMain.DataSource = db.ds.Tables[currentTable];
            isChangingTable = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO {currentTable} (";
            foreach (DataColumn col in db.ds.Tables[currentTable].Columns)
                query = $"{query}{col.ColumnName}, ";
            query = query.Remove(query.Length - 2);
            query += ") values (";
            msg.Error(query);
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

        private void tableLayoutPanelArguments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }
    }
}
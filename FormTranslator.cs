using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWinForms
{
    public partial class FormTranslator : MetroForm
    {
        bool isChangingTable;
        string currentTable;
        static public List<Page> Pages = new List<Page>();
        public class Page
        {
            public string Name;
            public List<Row> Rows = new List<Row>();
            public class Row
            {
                public string Name;
                public Type Type;
                public bool IsIdentity;
                public List<Control> Controls = new List<Control>();
                public void Add()
                {
                    MetroLabel label = new MetroLabel()
                    {
                        Name = "label" + Name,
                        AutoSize = true,
                        Anchor = AnchorStyles.Right
                    };
                    if (!string.IsNullOrEmpty(Name))
                        label.Text = Name;
                    else
                        label.Text = "НЕИЗВЕСТНО";
                    Control field = new MetroUserControl();
                    if (Type == typeof(DateTime))
                        field = new MetroDateTime();
                    else if (Type == typeof(int) || Type == typeof(Int64))
                        field = new NumericUpDown()
                        {
                            Maximum = Int64.MaxValue
                        };
                    else
                        field = new MetroTextBox();
                    field.Name = "control" + Name;
                    field.Width = 200;
                    Controls.Add(label);
                    Controls.Add(field);
                }
            }
            public List<string> GetArguments()
            {
                List<string> arguments = new List<string>();
                foreach (Row row in Rows)
                    arguments.Add(row.Name);
                return arguments;
            }
            public List<string> GetValues()
            {
                List<string> values = new List<string>();
                foreach (Row row in Rows)
                    if (row.Type == typeof(string))
                        values.Add($"'{row.Controls[1].Text}'");
                    else if (row.Controls[1] is MetroDateTime)
                        values.Add($"'{Convert.ToDateTime(row.Controls[1].Text):yyyyMMdd}'");
                    else values.Add(row.Controls[1].Text);
                return values;
            }
        }
        void RefreshUI()
        {
            DataBase.RefreshDS();
            listBoxTables.Items.Clear();
            Pages.Clear();
            int maxWidthLabel = 0, maxWidthField = 0, maxMarginField = 0;
                listBoxTables.Items.Add("Принятые заказы");
                Page page = new Page();
                page.Name = "ordersattempt";
                for (int i = 0; i < DataBase.ds.Tables["ordersattempt"].Columns.Count; i++)
                {
                    Page.Row row = new Page.Row()
                    {
                        Name = DataBase.ds.Tables["ordersattempt"].Columns[i].ColumnName,
                        Type = DataBase.ds.Tables["ordersattempt"].Columns[i].DataType,
                        IsIdentity = Convert.ToBoolean(DataBase.tablesNames.Tables["ordersattempt"].Rows[i]["auto_inc"])
                    };
                    row.Add();
                    if (row.Controls.Count > 0)
                    {
                        if (row.Controls[0].Width > maxWidthLabel)
                            maxWidthLabel = row.Controls[0].Width;
                        if (row.Controls[1].Width > maxWidthField)
                            maxWidthField = row.Controls[1].Width;
                        if (row.Controls[1].Margin.All > maxMarginField)
                            maxMarginField = row.Controls[1].Margin.All;
                    }
                    page.Rows.Add(row);
                }
                Pages.Add(page);
            TableLayoutPanelLeft.Width = maxWidthField + maxWidthLabel + maxMarginField;
            if (listBoxTables.Items.Count > 0)
                listBoxTables.SelectedIndex = 0;
        }
        public FormTranslator()
        {
            InitializeComponent();
        }

        private void FormTranslator_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChangingTable = true;
            currentTable = Pages[listBoxTables.SelectedIndex].Name;
            tableLayoutPanelArguments.Controls.Clear();
            tableLayoutPanelArguments.RowStyles.Clear();
            tableLayoutPanelArguments.RowCount = 1;
            tableLayoutPanelArguments.RowCount += DataBase.ds.Tables[currentTable].Columns.Count;
            for (int row = 0; row < Pages[listBoxTables.SelectedIndex].Rows.Count; row++)
                tableLayoutPanelArguments.Controls.AddRange(Pages[listBoxTables.SelectedIndex].Rows[row].Controls.ToArray());
            dataGridViewMain.DataSource = DataBase.ds.Tables[currentTable];
            isChangingTable = false;
            Console.WriteLine($"Строк в панели: {tableLayoutPanelArguments.RowCount}\n" +
                $"Количество полей: {Pages[listBoxTables.SelectedIndex].Rows.Count}");
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelArguments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

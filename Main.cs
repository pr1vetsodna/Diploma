﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace DiplomaWinForms
{
    public partial class Main : Form
    {
        bool isChangingTable;
        public Main()
        {
            InitializeComponent();
        }

        static public List<Page> Pages = new List<Page>();
        public string currentTable;
        public class Page
        {
            public string Name;
            public List<Row> Rows = new List<Row>();
            public class Row
            {
                public string Name;
                public Type Type;
                public List<Control> Controls = new List<Control>();
                public void Add()
                {
                    Label label = new Label()
                    {
                        Name = "label" + Name,
                        AutoSize = true,
                        Anchor = AnchorStyles.Right
                    };
                    if (Name != null)
                        label.Text = Name;
                    else
                        label.Text = "НЕИЗВЕСТНО";
                    Control field = new Control();
                    if (Type == typeof(DateTime))
                        field = new DateTimePicker();
                    else if (Type == typeof(int) || Type == typeof(Int64))
                        field = new NumericUpDown()
                        {
                            Maximum = Int64.MaxValue
                        };
                    else
                        field = new TextBox();
                    field.Name = "control" + Name;
                    field.Dock = DockStyle.Fill;
                    Controls.Add(label);
                    Controls.Add(field);
                }
            }
            public string GetValues()
            {
                string values = null;
                for (int row = 0; row < Rows.Count; row++)
                {
                    if (Rows[row].Type == typeof(string))
                        values += $"'{Rows[row].Controls[1].Text}'";
                    else
                        values += Rows[row].Controls[1].Text;
                    values += ", ";
                }
                
                return values.Remove(values.Length - 2);
            }
            public string GetArguments()
            {
                string arguments = null;
                for (int row = 0; row < Rows.Count; row++)
                    arguments += Rows[row].Controls[0].Text + ", ";
                return arguments.Remove(arguments.Length - 2);
            }
        }


        void RefreshUI()
        {
            DataBase.RefreshDS();
            listBoxTables.Items.Clear();
            Pages.Clear();
            int maxWidthLabel = 0, maxWidthField = 0, maxMarginField = 0;
            foreach (DataTable table in DataBase.ds.Tables)
            {
                listBoxTables.Items.Add(table.TableName);
                Page page = new Page();
                page.Name = table.TableName;
                foreach (DataColumn column in DataBase.ds.Tables[table.TableName].Columns)
                {
                    Page.Row row = new Page.Row()
                    {
                        Name = column.ColumnName,
                        Type = column.DataType
                    };
                    row.Add();
                    if (row.Controls.Count > 0)
                    {
                        if (row.Controls[0].Width > maxWidthLabel)
                            maxWidthLabel = row.Controls[0].Width;
                        if (row.Controls[1].Width > maxWidthField)
                            maxWidthField = row.Controls[1].Width;
                        if (row.Controls[1].Margin.Right > maxMarginField)
                            maxMarginField = row.Controls[1].Margin.Right;
                    }
                    page.Rows.Add(row);
                }
                Pages.Add(page);
            }
            TableLayoutPanelLeft.Width = maxWidthField + maxWidthLabel + maxMarginField;
            if (listBoxTables.Items.Count > 0)
                listBoxTables.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
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
                $"Количество полей: {tableLayoutPanelArguments.Controls.Count / 2}");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataBase.Control.Insert(DataBase.ds.Tables[currentTable], Pages[listBoxTables.SelectedIndex].GetArguments(), Pages[listBoxTables.SelectedIndex].GetValues());
        }
        private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            if (!isChangingTable && dataGridViewMain.CurrentRow != null)
                foreach (DataColumn col in DataBase.ds.Tables[currentTable].Columns)
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
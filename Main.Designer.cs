﻿namespace DiplomaWinForms
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new MetroFramework.Controls.MetroButton();
            this.buttonMod = new MetroFramework.Controls.MetroButton();
            this.buttonDel = new MetroFramework.Controls.MetroButton();
            this.buttonSearch = new MetroFramework.Controls.MetroButton();
            this.buttonUpd = new MetroFramework.Controls.MetroButton();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.TableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelArguments = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.dataGridViewMain = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanelControl.SuspendLayout();
            this.TableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelArguments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelControl
            // 
            this.tableLayoutPanelControl.AutoSize = true;
            this.tableLayoutPanelControl.ColumnCount = 2;
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelControl.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanelControl.Controls.Add(this.buttonMod, 0, 1);
            this.tableLayoutPanelControl.Controls.Add(this.buttonDel, 0, 2);
            this.tableLayoutPanelControl.Controls.Add(this.buttonSearch, 1, 1);
            this.tableLayoutPanelControl.Controls.Add(this.buttonUpd, 1, 2);
            this.tableLayoutPanelControl.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelControl.Location = new System.Drawing.Point(3, 209);
            this.tableLayoutPanelControl.Name = "tableLayoutPanelControl";
            this.tableLayoutPanelControl.RowCount = 3;
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelControl.Size = new System.Drawing.Size(222, 87);
            this.tableLayoutPanelControl.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseSelectable = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMod.Location = new System.Drawing.Point(3, 32);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(105, 23);
            this.buttonMod.TabIndex = 7;
            this.buttonMod.Text = "Изменить";
            this.buttonMod.UseSelectable = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDel.Location = new System.Drawing.Point(3, 61);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(105, 23);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseSelectable = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(114, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseSelectable = true;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpd.Location = new System.Drawing.Point(114, 61);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(105, 23);
            this.buttonUpd.TabIndex = 10;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseSelectable = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // textBoxSearch
            // 
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.CustomButton.Visible = false;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(114, 3);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(105, 23);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            // 
            // TableLayoutPanelLeft
            // 
            this.TableLayoutPanelLeft.AutoScroll = true;
            this.TableLayoutPanelLeft.ColumnCount = 1;
            this.TableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelArguments, 0, 0);
            this.TableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelControl, 0, 1);
            this.TableLayoutPanelLeft.Controls.Add(this.listBoxTables, 0, 2);
            this.TableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanelLeft.Location = new System.Drawing.Point(20, 60);
            this.TableLayoutPanelLeft.Name = "TableLayoutPanelLeft";
            this.TableLayoutPanelLeft.RowCount = 3;
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelLeft.Size = new System.Drawing.Size(228, 519);
            this.TableLayoutPanelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelArguments
            // 
            this.tableLayoutPanelArguments.AutoScroll = true;
            this.tableLayoutPanelArguments.AutoSize = true;
            this.tableLayoutPanelArguments.ColumnCount = 2;
            this.tableLayoutPanelArguments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelArguments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelArguments.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanelArguments.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelArguments.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelArguments.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanelArguments.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelArguments.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelArguments.MaximumSize = new System.Drawing.Size(0, 200);
            this.tableLayoutPanelArguments.MinimumSize = new System.Drawing.Size(0, 200);
            this.tableLayoutPanelArguments.Name = "tableLayoutPanelArguments";
            this.tableLayoutPanelArguments.RowCount = 1;
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelArguments.Size = new System.Drawing.Size(222, 200);
            this.tableLayoutPanelArguments.TabIndex = 2;
            this.tableLayoutPanelArguments.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelArguments_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1111";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "11112222";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBoxTables
            // 
            this.listBoxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 25;
            this.listBoxTables.Location = new System.Drawing.Point(3, 302);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(222, 214);
            this.listBoxTables.TabIndex = 3;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewMain.GridColor = System.Drawing.Color.Black;
            this.dataGridViewMain.Location = new System.Drawing.Point(248, 60);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(685, 519);
            this.dataGridViewMain.TabIndex = 1;
            this.dataGridViewMain.SelectionChanged += new System.EventHandler(this.dataGridViewMain_SelectionChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.TableLayoutPanelLeft);
            this.Name = "Main";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelLeft.ResumeLayout(false);
            this.TableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelArguments.ResumeLayout(false);
            this.tableLayoutPanelArguments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelArguments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid dataGridViewMain;
        private MetroFramework.Controls.MetroButton buttonAdd;
        private MetroFramework.Controls.MetroButton buttonMod;
        private MetroFramework.Controls.MetroButton buttonDel;
        private MetroFramework.Controls.MetroButton buttonSearch;
        private MetroFramework.Controls.MetroButton buttonUpd;
        private System.Windows.Forms.ListBox listBoxTables;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
    }
}


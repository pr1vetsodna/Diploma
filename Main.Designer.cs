namespace DiplomaWinForms
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
            this.TableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelArguments = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelArguments.SuspendLayout();
            this.tableLayoutPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelLeft
            // 
            this.TableLayoutPanelLeft.AutoSize = true;
            this.TableLayoutPanelLeft.ColumnCount = 1;
            this.TableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelArguments, 0, 0);
            this.TableLayoutPanelLeft.Controls.Add(this.listBoxTables, 0, 2);
            this.TableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelControl, 0, 1);
            this.TableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelLeft.Name = "TableLayoutPanelLeft";
            this.TableLayoutPanelLeft.RowCount = 3;
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelLeft.Size = new System.Drawing.Size(228, 450);
            this.TableLayoutPanelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelArguments
            // 
            this.tableLayoutPanelArguments.AutoSize = true;
            this.tableLayoutPanelArguments.ColumnCount = 2;
            this.tableLayoutPanelArguments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelArguments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelArguments.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelArguments.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanelArguments.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelArguments.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelArguments.Name = "tableLayoutPanelArguments";
            this.tableLayoutPanelArguments.RowCount = 1;
            this.tableLayoutPanelArguments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelArguments.Size = new System.Drawing.Size(222, 26);
            this.tableLayoutPanelArguments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "вкпвапвапвап";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(103, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBoxTables
            // 
            this.listBoxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 25;
            this.listBoxTables.Location = new System.Drawing.Point(3, 128);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(222, 319);
            this.listBoxTables.TabIndex = 1;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.listBoxTables_SelectedIndexChanged);
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
            this.tableLayoutPanelControl.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanelControl.Controls.Add(this.buttonSearch, 1, 1);
            this.tableLayoutPanelControl.Controls.Add(this.buttonUpd, 1, 2);
            this.tableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelControl.Location = new System.Drawing.Point(3, 35);
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
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMod.Location = new System.Drawing.Point(3, 32);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(105, 23);
            this.buttonMod.TabIndex = 1;
            this.buttonMod.Text = "Изменить";
            this.buttonMod.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDel.Location = new System.Drawing.Point(3, 61);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(105, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(114, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(105, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Location = new System.Drawing.Point(114, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpd.Location = new System.Drawing.Point(114, 61);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(105, 23);
            this.buttonUpd.TabIndex = 5;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(228, 0);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(572, 450);
            this.dataGridViewMain.TabIndex = 1;
            this.dataGridViewMain.SelectionChanged += new System.EventHandler(this.dataGridViewMain_SelectionChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.TableLayoutPanelLeft);
            this.Name = "Main";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TableLayoutPanelLeft.ResumeLayout(false);
            this.TableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelArguments.ResumeLayout(false);
            this.tableLayoutPanelArguments.PerformLayout();
            this.tableLayoutPanelControl.ResumeLayout(false);
            this.tableLayoutPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelArguments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControl;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}


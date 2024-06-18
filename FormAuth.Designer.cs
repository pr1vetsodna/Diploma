using MetroFramework.Controls;

namespace DiplomaWinForms
{
    partial class FormAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.checkBoxShowPass = new MetroFramework.Controls.MetroCheckBox();
            this.buttonAuth = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLogin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPassword, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxShowPass, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAuth, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 81);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            // 
            // 
            // 
            this.textBoxLogin.CustomButton.Image = null;
            this.textBoxLogin.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.textBoxLogin.CustomButton.Name = "";
            this.textBoxLogin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxLogin.CustomButton.TabIndex = 1;
            this.textBoxLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxLogin.CustomButton.UseSelectable = true;
            this.textBoxLogin.CustomButton.Visible = false;
            this.textBoxLogin.Lines = new string[0];
            this.textBoxLogin.Location = new System.Drawing.Point(63, 3);
            this.textBoxLogin.MaxLength = 32767;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PasswordChar = '\0';
            this.textBoxLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxLogin.SelectedText = "";
            this.textBoxLogin.SelectionLength = 0;
            this.textBoxLogin.SelectionStart = 0;
            this.textBoxLogin.ShortcutsEnabled = true;
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.UseSelectable = true;
            this.textBoxLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.CustomButton.Image = null;
            this.textBoxPassword.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.textBoxPassword.CustomButton.Name = "";
            this.textBoxPassword.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPassword.CustomButton.TabIndex = 1;
            this.textBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPassword.CustomButton.UseSelectable = true;
            this.textBoxPassword.CustomButton.Visible = false;
            this.textBoxPassword.Lines = new string[0];
            this.textBoxPassword.Location = new System.Drawing.Point(63, 29);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSelectable = true;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(169, 31);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(116, 15);
            this.checkBoxShowPass.TabIndex = 4;
            this.checkBoxShowPass.Text = "Показать пароль";
            this.checkBoxShowPass.UseSelectable = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // buttonAuth
            // 
            this.buttonAuth.AutoSize = true;
            this.buttonAuth.Location = new System.Drawing.Point(63, 55);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(100, 23);
            this.buttonAuth.TabIndex = 5;
            this.buttonAuth.Text = "Авторизоваться";
            this.buttonAuth.UseSelectable = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 165);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroLabel label2;
        private MetroLabel label3;
        private MetroTextBox textBoxLogin;
        private MetroTextBox textBoxPassword;
        private MetroCheckBox checkBoxShowPass;
        private MetroButton buttonAuth;
    }
}
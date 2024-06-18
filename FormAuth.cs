using MetroFramework.Forms;
using System;
using System.Data;

namespace DiplomaWinForms
{
    public partial class FormAuth : MetroForm
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            table.Clear();
            DataBase.Adapter($"SELECT login, password, userroleid from users where login = '{textBoxLogin.Text}' and password = '{textBoxPassword.Text}'").Fill(table);
            if (table.Rows.Count == 0)
                msg.Error("Неверный логин или пароль");
            else
            {
                switch (Convert.ToInt32(table.Rows[0]["userroleid"]))
                {
                    case 1:
                        FormAdmin admin = new FormAdmin();
                        this.Hide();
                        admin.ShowDialog();
                        break;
                    case 2:
                        FormManager manager = new FormManager();
                        this.Hide();
                        manager.ShowDialog();
                        break;
                    case 3:
                        FormTranslator translator = new FormTranslator();
                        this.Hide();
                        translator.ShowDialog();
                        break;
                }
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPass.Checked;
            if (textBoxPassword.UseSystemPasswordChar)
                textBoxPassword.PasswordChar = '●';
            else
                textBoxPassword.PasswordChar = '\0';
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaWinForms
{
    public class Messages
    {
        public void Error(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Question(string message)
        {
            if (MessageBox.Show(message, "Ожидание ответа", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        void successfully(string message)
        {
            MessageBox.Show(message, "Успешно!", MessageBoxButtons.OK);
        }
    }
}

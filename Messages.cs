using System.Windows.Forms;

namespace DiplomaWinForms
{
    public static class msg
    {
        public static void Error(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Question(string question, string message)
        {
            if (question == null)
                question = "Ожидание ответа";
            if (MessageBox.Show(message, question, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static void successfully(string message)
        {
            MessageBox.Show(message, "Успешно!", MessageBoxButtons.OK);
        }
    }
}

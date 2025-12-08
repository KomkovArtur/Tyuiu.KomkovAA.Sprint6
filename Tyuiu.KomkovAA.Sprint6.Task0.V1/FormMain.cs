using Tyuiu.KomkovAA.Sprint6.Task0.V1.Lib;

namespace Tyuiu.KomkovAA.Sprint6.Task0.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Комков А. А. | РППб-25-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

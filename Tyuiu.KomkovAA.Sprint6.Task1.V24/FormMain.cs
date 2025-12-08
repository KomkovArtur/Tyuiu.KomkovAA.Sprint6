using Tyuiu.KomkovAA.Sprint6.Task1.V24.Lib;

namespace Tyuiu.KomkovAA.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();

        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes.Text = "";
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
                    textBoxRes.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: Комков А. А. | РППб-25-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

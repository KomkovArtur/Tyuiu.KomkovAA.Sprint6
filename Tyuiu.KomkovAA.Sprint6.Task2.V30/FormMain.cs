using Tyuiu.KomkovAA.Sprint6.Task2.V30.Lib;
namespace Tyuiu.KomkovAA.Sprint6.Task2.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);
                double[] valueArray = ds.GetMassFunction(startValue, stopValue);


                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewRes.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    startValue++;
                }


            }
            catch
            {
                MessageBox.Show("Eror", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

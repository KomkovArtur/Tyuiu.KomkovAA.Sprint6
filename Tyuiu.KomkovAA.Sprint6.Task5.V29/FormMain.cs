using System.IO;
using Tyuiu.KomkovAA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.KomkovAA.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Артур\Desktop\InPutDataFileTask5V29.txt";

        private void buttonRes_Click(object sender, EventArgs e)
        {
            dataGridViewRes.ColumnCount = 2;
            dataGridViewRes.Columns[0].Width = 20;
            dataGridViewRes.Columns[1].Width = 50;

            double[] numsArray = new double[ds.len];

            numsArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArray.Length; i++)
            {
                dataGridViewRes.Rows.Add(Convert.ToString(i), Convert.ToString(numsArray[i]));
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}

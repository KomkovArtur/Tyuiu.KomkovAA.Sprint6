using Tyuiu.KomkovAA.Sprint6.Task3.V23.Lib;
namespace Tyuiu.KomkovAA.Sprint6.Task3.V23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 0, -19, 25, 34, 0 }, { -19, -16, 1, -5, 34 }, { 1, 13, -5, -17, -5 }, { 3, -9, -15, -1, 0 }, { 1, 20, 15, -5, 31 } };


        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
    }
}

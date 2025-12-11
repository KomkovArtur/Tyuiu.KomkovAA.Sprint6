using Tyuiu.KomkovAA.Sprint6.Task7.V21.Lib;
namespace Tyuiu.KomkovAA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonIn_KAA_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_Kaa.ColumnCount = columns;
            dataGridViewIn_Kaa.RowCount = rows;
            dataGridViewOut_KAA.ColumnCount = columns;
            dataGridViewOut_KAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_Kaa.Columns[i].Width = 35;
                dataGridViewOut_KAA.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_Kaa.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonRes_KAA.Enabled = true;

        }

        private void buttonRes_KAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KAA.Enabled = true;
        }

        private void buttonSave_KAA_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_KAA.RowCount;
            int columns = dataGridViewOut_KAA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonIn_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Выполнить";
        }

        private void buttonRes_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAbout_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Справка";
        }

        private void buttonAbout_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}

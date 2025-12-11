using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomkovAA.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(";").Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }
            int col = 7;
            for (int r = 0; r < rowCount; r++)
            {
                if (col < colCount)
                {
                    
                }
            }
            return matrix;
        }
    }
}

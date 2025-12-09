using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomkovAA.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int s = 0;

            int len = Math.Abs(startValue) + stopValue + 1;
            int count = 0;
            double[] res = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((2 - i) == 0)
                {
                    res[count] = ((5 * i + 2.5) / (Math.Sin(i) + 3)) + (2 * i + Math.Cos(i));
                    res[count] = Math.Round((res[count]), 2);
                }
                else
                {
                    res[count] = ((5 * i + 2.5) / (Math.Sin(i) + 3)) + (2 * i + Math.Cos(i));
                    res[count] = Math.Round((res[count]), 2);
                }
                count++;

            }
            return res;

            return a;
        }
    }
}

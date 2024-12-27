using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovaGM.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            DataService ds = new DataService();
            double[] massive = new double[11];
            int count = 0;
            double result = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                result = Math.Cos(x)+1 != 0 ? 3*x+2-((2 * x - x) / (Math.Cos(x)+1)) : 0;
                massive[count] = Math.Round(result, 2);
                count++;
            }
            return massive;
        }
    }
}

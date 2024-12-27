using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovaGM.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            DataService ds = new DataService();
            double[] massive = new double[11];
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                double result = (Math.Cos(x)/(x-0.4))+Math.Sin( x) * 8*x+2;
                massive[count] = Math.Round(result, 2);
                count++;
            }
            return massive;
        }
    }
}

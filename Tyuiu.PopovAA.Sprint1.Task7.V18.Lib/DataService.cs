using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PopovAA.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            double z = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - ((2 * x) / (1 + ((x * x) * (y * y)))))) + x;
            return Math.Round(z, 3);
        }

    }
}   

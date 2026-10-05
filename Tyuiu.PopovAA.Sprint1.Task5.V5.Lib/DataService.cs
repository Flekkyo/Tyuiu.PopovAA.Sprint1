using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PopovAA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int y = Convert.ToInt32(x);
            if (y > x)
            {
                y--;
            }
            int d = Convert.ToInt32((x - y) * 10);
            if (d > (x - y) * 10)
            {
                d--;
            }
            return d;
        }
    }
}    

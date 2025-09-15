using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FisherMA.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Abs(Math.Pow(y, 2) - x) / (x * y), 3);
        }
    }
}

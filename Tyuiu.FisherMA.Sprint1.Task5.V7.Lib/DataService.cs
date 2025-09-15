using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FisherMA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int DegreesToHours(double degrees)
        {
          
            int hours = (int)(degrees / 30.0);
            return hours;
        }

        public int SecondsToHours(int time)
        {
            throw new NotImplementedException();
        }
    }
}

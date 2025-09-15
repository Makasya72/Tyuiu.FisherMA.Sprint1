using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FisherMA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            throw new NotImplementedException();
        }

        public string ToMoneyFormat(double amount)
        {
            int rubles = (int)Math.Floor(amount);
            int kopecks = (int)Math.Round((amount - rubles) * 100);

            return $"{amount} руб. — это {rubles} руб. {kopecks:00} коп.";
        }
    }
}

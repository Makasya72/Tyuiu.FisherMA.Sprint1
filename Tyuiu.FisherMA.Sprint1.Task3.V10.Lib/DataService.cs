using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FisherMA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            return ToMoneyFormat(number);
        }

        public string ToMoneyFormat(double amount)
        {
            int rubles = (int)Math.Floor(amount);
            int kopecks = (int)Math.Round((amount - rubles) * 100);

            
            string amountStr = amount.ToString(CultureInfo.InvariantCulture);

            return $"{amountStr} руб. - это {rubles} руб. {kopecks:00} коп.";
        }
    }
}
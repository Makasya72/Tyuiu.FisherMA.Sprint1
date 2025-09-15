using Tyuiu.FisherMA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Фишер М.А | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того *");
            Console.WriteLine("* момента (в первой половине дня), когда часовая стрелка повернулась на f *");
            Console.WriteLine("* градусов (0<f<360, f – вещественное число).                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double f;
            Console.WriteLine("* Введите угол f (0<f<360): ");
            f = Convert.ToDouble(Console.ReadLine());

            int h;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            h = ds.DegreesToHours(f);
            Console.WriteLine("* H = " + h);
        }
    }
}

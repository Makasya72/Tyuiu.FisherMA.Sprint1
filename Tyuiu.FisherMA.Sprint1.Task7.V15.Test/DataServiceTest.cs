using Tyuiu.FisherMA.Sprint1.Task7.V15.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();

            double x = 2;
            double wait = Math.Round(Math.Abs(Math.Pow(2, 2) - Math.Pow(2, 3)) -
                                     ((Math.Cos(Math.Pow(2, 3)) + 7 * Math.Pow(2, 2)) /
                                     (Math.Pow(2, 3) - 15 * 2)), 3);

            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.FisherMA.Sprint1.Task4.V6.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;

            double wait = 0.186;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
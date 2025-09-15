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
            double x = 2;
            double y = 3;

            double expected = 3.833; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}

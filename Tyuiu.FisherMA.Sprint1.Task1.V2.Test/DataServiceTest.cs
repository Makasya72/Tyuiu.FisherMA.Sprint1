using Tyuiu.FisherMA.Sprint1.Task1.V2.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 10.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10.0, res);
        }
    }
}
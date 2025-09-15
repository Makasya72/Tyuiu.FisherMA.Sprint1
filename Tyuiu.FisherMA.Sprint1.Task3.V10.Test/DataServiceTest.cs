using Tyuiu.FisherMA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoneyFormat()
        {
            DataService ds = new DataService();
            double amount = 23.6;

            var res = ds.ToMoneyFormat(amount);
            Assert.AreEqual("23.6 руб. — это 23 руб. 60 коп.", res);
        }

        [TestMethod]
        public void RoundCents()
        {
            DataService ds = new DataService();
            double amount = 23.6789;

            var res = ds.ToMoneyFormat(amount);
            Assert.AreEqual("23.6789 руб. — это 23 руб. 68 коп.", res);
        }
    }
}
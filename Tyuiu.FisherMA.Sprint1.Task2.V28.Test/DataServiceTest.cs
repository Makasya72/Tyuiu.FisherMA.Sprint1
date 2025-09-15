using Tyuiu.FisherMA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConversion()
        {
            DataService ds = new DataService();
            int celsius = 25;

            int kelvin = ds.ConvertCelsiusToKelvin(celsius);
            Assert.AreEqual(298, kelvin);
        }
    }
}
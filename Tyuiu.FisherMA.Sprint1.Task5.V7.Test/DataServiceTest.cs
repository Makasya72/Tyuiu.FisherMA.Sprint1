using Tyuiu.FisherMA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestHours()
        {
            DataService ds = new DataService();
            double f = 95.0; 

            int expectedHours = 3; 
            int result = ds.DegreesToHours(f);

            Assert.AreEqual(expectedHours, result);
        }
    }
}

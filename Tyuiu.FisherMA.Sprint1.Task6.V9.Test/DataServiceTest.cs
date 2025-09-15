using Tyuiu.FisherMA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.FisherMA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MoveLastLetterToStart_ValidString()
        {
            DataService ds = new DataService();

            string input = "Hello World";
            string expected = "oHell dWorl";

            string result = ds.MoveLastLetterToStart(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MoveLastLetterToStart_SingleLetterWords()
        {
            DataService ds = new DataService();

            string input = "A I U";
            string expected = "A I U";

            string result = ds.MoveLastLetterToStart(input);
            Assert.AreEqual(expected, result);
        }
    }
}

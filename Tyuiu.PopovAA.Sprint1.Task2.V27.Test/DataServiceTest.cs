using Tyuiu.PopovAA.Sprint1.Task2.V27.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task2.V27.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            var res = ds.CalculateSquarePerimetr(2);
            Assert.AreEqual(8, res);
        }
    }
}  
using Tyuiu.PopovAA.Sprint1.Task1.V18.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task1.V18.Test
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
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}   
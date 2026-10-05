using Tyuiu.PopovAA.Sprint1.Task7.V18.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task7.V18.Test
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
            double x = 15.15;
            double y = 16.35;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(15.209, res);
        }
    }
}   
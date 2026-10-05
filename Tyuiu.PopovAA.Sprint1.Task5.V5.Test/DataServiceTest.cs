using Tyuiu.PopovAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task5.V5.Test
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
            double x = 345.345;
            var res = ds.Calculate(x);
            Assert.AreEqual(3, res);
        }
    }
}  
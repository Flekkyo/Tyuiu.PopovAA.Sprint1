using Tyuiu.PopovAA.Sprint1.Task0.V5.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task0.V5.Test
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
            var res = ds.Calculate();
            Assert.AreEqual(12, res);
        }
    }
} 
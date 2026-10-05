using Tyuiu.PopovAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task3.V6.Test
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
            double distance = 249;
            double gasFlow = 10;
            double gasPrice = 71.34;
            var res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(3552, 732, res);
        }
    }
} 
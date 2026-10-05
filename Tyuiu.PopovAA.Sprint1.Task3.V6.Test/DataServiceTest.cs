using Tyuiu.PopovAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task3.V6.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double distance = 249;
        double gasFlow = 10;
        double gasPrice = 71.34;
        var res = ds.TravelCost(distance, gasFlow, gasPrice);
        Assert.AreEqual(3552, 732, res);
    }
} 

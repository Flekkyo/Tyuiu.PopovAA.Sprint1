using Tyuiu.PopovAA.Sprint1.Task4.V6.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task4.V6.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = -5;
        double y = 14;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(-2.871, res);
    }
} 

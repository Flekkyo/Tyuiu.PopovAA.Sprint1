using Tyuiu.PopovAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task5.V5.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        double x = 345.345;
        var res = ds.Calculate(x);
        Assert.AreEqual(3, res);
    }
}
 
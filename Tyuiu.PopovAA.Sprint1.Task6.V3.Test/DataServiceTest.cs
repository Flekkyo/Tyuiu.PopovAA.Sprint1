using Tyuiu.PopovAA.Sprint1.Task6.V3.Lib;
namespace Tyuiu.PopovAA.Sprint1.Task6.V3.Test
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
            string x = "Космонавт жевал фиолетовый трактор возле сонного кактуса и смеялся.";
            var res = ds.LastLetterWord(x);
            Assert.AreEqual("тлйреоаи.", res);
        }
    }
}  
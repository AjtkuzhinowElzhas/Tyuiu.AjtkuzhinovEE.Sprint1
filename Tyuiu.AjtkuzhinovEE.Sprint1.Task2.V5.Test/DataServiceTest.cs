using Tyuiu.AjtkuzhinovEE.Sprint1.Task2.V5.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds=new DataService();
            int x = 2;
            var res = ds.CalculateSideSquare(x);
            Assert.AreEqual(16, res);
        }
    }
}

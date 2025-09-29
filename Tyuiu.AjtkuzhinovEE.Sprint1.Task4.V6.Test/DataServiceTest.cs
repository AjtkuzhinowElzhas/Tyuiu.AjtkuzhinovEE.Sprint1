using Tyuiu.AjtkuzhinovEE.Sprint1.Task4.V6.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}

using System.Net.WebSockets;
using Tyuiu.AjtkuzhinovEE.Sprint1.Task7.V18.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 30;
            double y = 0;
            double wait = 30.062;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

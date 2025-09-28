using Tyuiu.AltkuzhinovEE.Sprint1.Task3.V5.Lib;

namespace Tyuiu.AltkuzhinovEE.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double mapScale = 120;
            double distanceBetweenPoints = 3.5;
            var res = ds.DistanceLength(mapScale, distanceBetweenPoints);
            Assert.AreEqual(420, res);
        }
    }
}

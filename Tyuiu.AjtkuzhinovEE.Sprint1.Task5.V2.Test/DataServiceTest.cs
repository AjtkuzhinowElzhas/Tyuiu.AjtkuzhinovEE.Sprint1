using Tyuiu.AjtkuzhinovEE.Sprint1.Task5.V2.Lib;


namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            double temp = 32;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = 0;
            Assert.AreEqual(wait, result);

        }
    }
}

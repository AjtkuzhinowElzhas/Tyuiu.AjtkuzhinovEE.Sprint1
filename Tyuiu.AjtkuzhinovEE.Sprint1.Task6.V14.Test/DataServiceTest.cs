using Tyuiu.AjtkuzhinovEE.Sprint1.Task6.V14.Lib;



namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            char[] russianLetters = new char[32];
            for (int i = 0; i < 32; i++)
            {
                russianLetters[i] = (char)('?' + i);
            }
            string strTest = "???????????????????";
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckLowerCaseRusLetters(strTest));


        }
    }
}

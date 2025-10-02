using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;



namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = Math.Round((temp - 32) * 5/9);
            return (int)res;
        }
    }
}

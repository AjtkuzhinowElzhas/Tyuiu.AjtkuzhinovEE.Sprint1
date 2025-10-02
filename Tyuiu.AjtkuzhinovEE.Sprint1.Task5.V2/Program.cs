
//ЗАДАНИЕ
//Написать программу, которая решает следующую задачу:

//Дано значение температуры в градусах Фаренгейта.
//Определить значение этой же температуры в градусах Цельсия.
//+Ответ привести к целому с помощью класса Convert.


using Tyuiu.AjtkuzhinovEE.Sprint1.Task5.V2.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение градусов по Фаренгейту:");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ B ГРАДУСАХ ЦЕЛЬСИЯ:                                             ");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
        Console.WriteLine(res);

        Console.ReadKey();




    }
}
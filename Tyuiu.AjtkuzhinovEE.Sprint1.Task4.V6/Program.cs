using Tyuiu.AjtkuzhinovEE.Sprint1.Task4.V6.Lib;


//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле и печатает его на экране.
//Формула:
//  |y ^ 2 - x|
//  -----------
//    x * y



internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        int x, y;

        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" |y ^ 2 - x| / (x * y) = " + ds.Calculate(x, y));

        Console.ReadKey();


    }
}
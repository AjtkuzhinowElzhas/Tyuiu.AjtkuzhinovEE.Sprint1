using System.Text.RegularExpressions;
using Tyuiu.AjtkuzhinovEE.Sprint1.Task6.V14.Lib;

//ЗАДАНИЕ
//Написать программу: пользователь вводит текст.
//Проверить, что строка составлена только из строчных русских букв.

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value;

        Console.WriteLine("Введите строку:");
        value = Convert.ToString(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"{ds.CheckLowerCaseRusLetters(value)}");

        Console.ReadLine();

    }



}

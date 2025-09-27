
using Tyuiu.AjtkuzhinovEE.Sprint1.Task1.V26.Lib;
//Задание
//Написать программу, которая запрашивает у пользователя исходные данные
//вычисляет результат по формуле 5*x/ (2+y) и печатает его на экране.

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Айткужинов.Е.Е | РППб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле 5*x/ (2+y)                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");


        //Метод Calculate находится в библиотеке Tyuiu.AjtkuzhinovEE.Sprint1.Task0.V0.Lib
        //в классе DataService
        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}
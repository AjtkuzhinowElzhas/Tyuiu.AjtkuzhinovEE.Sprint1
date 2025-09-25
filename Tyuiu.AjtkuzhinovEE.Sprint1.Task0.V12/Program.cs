using Tyuiu.AjtkuzhinovEE.Sprint1.Task0.V12.Lib;


//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение (5 * 2 - 2) / 4 * 3 и печатает результат на экране.


internal class Program
{
    public static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0 | Выполнил: Айткужинов.Е.Е | РППб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #12                                                              *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение (5*2 - 2) / 4 * 3       *");
        Console.WriteLine("* и печатает результат на экране                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* (5*2 - 2) / 4 * 3                                                        ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
        Console.WriteLine("***************************************************************************");

        //Метод Calculate находится в библиотеке Tyuiu.AjtkuzhinovEE.Sprint1.Task0.V0.Lib
        //в классе DataService
        Console.WriteLine(ds.Calculate());

        Console.ReadLine();
    }
}
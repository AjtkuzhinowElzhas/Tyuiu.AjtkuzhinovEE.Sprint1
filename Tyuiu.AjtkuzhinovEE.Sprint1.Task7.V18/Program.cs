using Tyuiu.AjtkuzhinovEE.Sprint1.Task7.V18.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет математическое выражение
//по исходным значениям данных, вводимых пользователем.
//Ответ округлите до 3 знаков после запятой.
//
//
//               1 + sin ^ 2 (x + y)
// z = ------------------------------------------  + x
//           |           2 * x           |
//       2 + | x - --------------------- |
//           |      1 + x ^ 2 * y ^ 2    |




internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Айткужинов Е. Е. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                1+sin ^ 2(x+y)                           *");
        Console.WriteLine("*                        z= --------------------- +x                      *");
        Console.WriteLine("*                               |       2x    |                           *");
        Console.WriteLine("*                            2+ | x- ---------|                           *");
        Console.WriteLine("*                               |    1+x^2*y^2|                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;
        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
    }
}
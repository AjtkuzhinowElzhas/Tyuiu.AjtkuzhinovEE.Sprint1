using Tyuiu.AjtkuzhinovEE.Sprint1.Task3.V5.Lib;


//ЗАДАНИЕ :
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчет :
//Написать программу вычисления расстояния между населенными пунктами, изображенными на карте.
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double mapScale = 120;
        double distanceBetweenPoints = 3.5;
        Console.WriteLine("Масштаб карты (количество км. в одном см.) = " + mapScale);
        Console.WriteLine("Расстояние между точками, изображающими населенные пункты (см) = " + distanceBetweenPoints);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Расстояние между населенными пунктами = " + ds.DistanceLength(mapScale, distanceBetweenPoints));

        Console.ReadKey();

    }
}
using Tyuiu.MedvedevDP.Sprint2.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("Vvedi x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Vvedi y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = dataService.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }

        Console.ReadKey();
    }
}
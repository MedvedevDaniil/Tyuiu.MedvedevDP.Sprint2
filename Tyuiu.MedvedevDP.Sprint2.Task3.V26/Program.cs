using Tyuiu.MedvedevDP.Sprint2.Task3.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        double x = Convert.ToDouble(Console.ReadLine());

        double result = dataService.Calculate(x);
        Console.WriteLine(Math.Round(result, 3));
    }
}
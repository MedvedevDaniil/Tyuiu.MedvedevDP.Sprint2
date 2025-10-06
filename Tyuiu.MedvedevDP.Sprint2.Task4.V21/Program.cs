using Tyuiu.MedvedevDP.Sprint2.Task4.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("Vvedi x:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvedi y:");
        int y = Convert.ToInt32(Console.ReadLine());

        double res = dataService.Calculate(x, y);

        Console.WriteLine(res); 
    }
}
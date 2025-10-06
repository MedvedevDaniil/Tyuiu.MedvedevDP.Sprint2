using Tyuiu.MedvedevDP.Sprint2.Task6.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("Vvedi nomer mesyaca:");
        int value = Convert.ToInt32(Console.ReadLine());

        int res = dataService.FindMonthDaysCount(value);

        Console.WriteLine(res);
    }
}
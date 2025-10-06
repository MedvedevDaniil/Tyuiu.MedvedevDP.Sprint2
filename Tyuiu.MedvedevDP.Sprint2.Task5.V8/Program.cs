using Tyuiu.MedvedevDP.Sprint2.Task5.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.WriteLine("Vvedi m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vvedi n:");
        int n = Convert.ToInt32(Console.ReadLine());

        string res = dataService.FindDateOfPreviousDay(m, n);

        Console.WriteLine(res);
    }
}
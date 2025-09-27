using Tyuiu.MedvedevDP.Sprint2.Task1.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        int a = 657;
        int b = 874;
        int c = 14;
        int d = 654;

        bool[] result = dataService.GetLogicOperations(a, b, c, d);
        Console.WriteLine(result);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}
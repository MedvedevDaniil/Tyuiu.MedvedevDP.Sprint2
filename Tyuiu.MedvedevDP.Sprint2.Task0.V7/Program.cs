using Tyuiu.MedvedevDP.Sprint2.Task0.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();

        int x = 103;
        int y = 475;

        bool[] res = new bool[6];
        res = dataService.GetCompareOperations(x, y);

        for (int i=0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}
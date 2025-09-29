using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevDP.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                double cosX2 = Math.Cos(x * x);
                double baseValue = (x + 1) / cosX2;
                return x + Math.Pow(baseValue, x);
            }
            else if (x == 0)
            {
                double sinX2 = Math.Sin(x * x); 
                double denominator = 9 - sinX2; 
                return (15 + x) / denominator; 
            }
            else if (x > -30 && x < 0)
            {
                double sinX3 = Math.Sin(x * x * x);
                double denominator = x + 5;
                double baseValue = sinX3 / denominator;
                return Math.Pow(baseValue, x);
            }
            else 
            {
                return 8 * x - 1 / x;
            }
        }
    }
}

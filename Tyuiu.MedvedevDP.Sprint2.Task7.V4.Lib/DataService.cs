using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevDP.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= -1) && (x <= 1) && (y >= 0) && !(Math.Pow(x, 2) + Math.Pow(y, 2) <= 0.09))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
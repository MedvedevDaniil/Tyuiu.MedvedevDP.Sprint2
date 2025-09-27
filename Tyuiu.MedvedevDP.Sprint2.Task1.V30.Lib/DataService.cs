using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MedvedevDP.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == d + 3) | (c == 100);
            res[1] = (c != 14) & (a != 657);
            res[2] = (c < a) || (b < 0);
            res[3] = (a > d) && (b > a);
            res[4] = !(c <= 0);
            res[5] = (a >= 657) ^ (d >= 654);

            return res;
        }
    }
}

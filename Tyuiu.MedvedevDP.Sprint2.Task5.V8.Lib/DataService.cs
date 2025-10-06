using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevDP.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    if (n == 1)
                        res = "31.12";
                    else
                        res = $"{n - 1}.01";
                    break;
                case 2:
                    if (n == 1)
                        res = "31.01";
                    else
                        res = $"{n - 1}.02";
                    break;
                case 3:
                    if (n == 1)
                        res = "28.02";
                    else
                        res = $"{n - 1}.03";
                    break;
                case 4:
                    if (n == 1)
                        res = "31.03";
                    else
                        res = $"{n - 1}.04";
                    break;
                case 5:
                    if (n == 1)
                        res = "30.04";
                    else
                        res = $"{n - 1}.05";
                    break;
                case 6:
                    if (n == 1)
                        res = "31.05";
                    else
                        res = $"{n - 1}.06";
                    break;
                case 7:
                    if (n == 1)
                        res = "30.06";
                    else
                        res = $"{n - 1}.07";
                    break;
                case 8:
                    if (n == 1)
                        res = "31.07";
                    else
                        res = $"{n - 1}.08";
                    break;
                case 9:
                    if (n == 1)
                        res = "31.08";
                    else
                        res = $"{n - 1}.09";
                    break;
                case 10:
                    if (n == 1)
                        res = "30.09";
                    else
                        res = $"{n - 1}.10";
                    break;
                case 11:
                    if (n == 1)
                        res = "31.10";
                    else
                        res = $"{n - 1}.11";
                    break;
                case 12:
                    if (n == 1)
                        res = "30.11";
                    else
                        res = $"{n - 1}.12";
                    break;
                default:
                    throw new ArgumentException("Некорректный месяц");
            }
            return res;
        }
    }
}
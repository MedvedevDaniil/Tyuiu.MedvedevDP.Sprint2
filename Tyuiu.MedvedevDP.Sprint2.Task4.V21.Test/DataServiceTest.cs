using Tyuiu.MedvedevDP.Sprint2.Task4.V21.Lib;
namespace Tyuiu.MedvedevDP.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService();

            double x = 5;
            double y = 5;

            double res = dataService.Calculate(x, y);
            double wait = 0.943;

            Assert.AreEqual(wait, res);
        }
    }
}

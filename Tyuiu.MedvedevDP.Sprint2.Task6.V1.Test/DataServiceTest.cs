using Tyuiu.MedvedevDP.Sprint2.Task6.V1.Lib;
namespace Tyuiu.MedvedevDP.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount_January()
        {
            DataService dataService = new DataService();
            int value = 1;
            int res = dataService.FindMonthDaysCount(value);
            int wait = 31;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthDaysCount_February()
        {
            DataService dataService = new DataService();
            int value = 2;
            int res = dataService.FindMonthDaysCount(value);
            int wait = 28;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthDaysCount_April()
        {
            DataService dataService = new DataService();
            int value = 4;
            int res = dataService.FindMonthDaysCount(value);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindMonthDaysCount_December()
        {
            DataService dataService = new DataService();
            int value = 12;
            int res = dataService.FindMonthDaysCount(value);
            int wait = 31;
            Assert.AreEqual(wait, res);
        }
    }
}
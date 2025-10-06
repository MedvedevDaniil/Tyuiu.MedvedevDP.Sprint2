using Tyuiu.MedvedevDP.Sprint2.Task5.V8.Lib;
namespace Tyuiu.MedvedevDP.Sprint2.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService dataService = new DataService();

            int m = 3;
            int n = 1;

            string res = dataService.FindDateOfPreviousDay(m, n);
            string wait = "28.02";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay2()
        {
            DataService dataService = new DataService();

            int m = 1;
            int n = 15;

            string res = dataService.FindDateOfPreviousDay(m, n);
            string wait = "14.01";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay3()
        {
            DataService dataService = new DataService();

            int m = 12;
            int n = 1;

            string res = dataService.FindDateOfPreviousDay(m, n);
            string wait = "30.11";

            Assert.AreEqual(wait, res);
        }
    }
}
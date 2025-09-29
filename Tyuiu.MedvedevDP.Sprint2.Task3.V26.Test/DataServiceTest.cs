using Tyuiu.MedvedevDP.Sprint2.Task3.V26.Lib;
namespace Tyuiu.MedvedevDP.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 1 + Math.Pow((1 + 1) / Math.Cos(1 * 1), 1);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = (15 + 0) / (9 - Math.Sin(0));
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double sinX3 = Math.Sin(-1 * -1 * -1);
            double denominator = -1 + 5;
            double baseValue = sinX3 / denominator;
            double wait = Math.Pow(baseValue, -1);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -31;
            double res = ds.Calculate(x);
            double wait = 8 * x - 1 / x;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}

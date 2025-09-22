using Tyuiu.MedvedevDP.Sprint2.Task0.V7.Lib;

namespace Tyuiu.MedvedevDP.Sprint2.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int x = 103;
            int y = 475;

            bool[] res = new bool[6];

            res = service.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, true, true, false};

            CollectionAssert.AreEqual(wait,res);
        }
    }
}

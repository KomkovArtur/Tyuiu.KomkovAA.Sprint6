using Tyuiu.KomkovAA.Sprint6.Task0.V1.Lib;

namespace Tyuiu.KomkovAA.Sprint6.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.2, ds.Calculate(2));

        }
    }
}

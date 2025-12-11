using Tyuiu.KomkovAA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.KomkovAA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\Артур\Desktop\InPutDataFileTask6V14.txt";
            var res = dataService.CollectTextFromFile(path);
            Assert.AreEqual("GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU", res);
        }
    }
}

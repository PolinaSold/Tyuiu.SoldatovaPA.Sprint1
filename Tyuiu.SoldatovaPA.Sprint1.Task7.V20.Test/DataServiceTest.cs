using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task7.V20.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_Test1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.918; // Примерное значение
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_Test2()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = 3.000; // При x=0, y=0: 2 + cos²(0) / 1 + 0 = 3
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_Test3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 0.5;
            double wait = 2.123; // Примерное значение
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_Test4()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 2;
            double wait = -1.082; // Примерное значение
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate_Test5()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            double wait = 1.250; // Примерное значение
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}

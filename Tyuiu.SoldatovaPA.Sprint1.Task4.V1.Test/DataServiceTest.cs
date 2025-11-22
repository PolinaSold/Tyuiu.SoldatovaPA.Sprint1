using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.25;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_PositiveNumber()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 0.111;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_NegativeNumber()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 1.0;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
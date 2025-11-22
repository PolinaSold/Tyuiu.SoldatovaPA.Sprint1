using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task1.V6.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double wait = 1;  // (4+2)/(3*2) = 6/6 = 1
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithDecimals()
        {
            DataService ds = new DataService();
            double x = 2.5;
            double y = 1.5;
            double wait = (2.5 + 1.5) / (3 * 1.5);  // 4 / 4.5 ≈ 0.8889
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculate_ZeroY()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 0;
            ds.Calculate(x, y);
        }
    }
}
   
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidVerstsToKilometers()
        {
            DataService ds = new DataService();
            double verst = 100;
            double wait = 106.68;  // 100 * 1.0668 = 106.68
            double res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidVerstsToKilometers_OneVerst()
        {
            DataService ds = new DataService();
            double verst = 1;
            double wait = 1.067;  // 1 * 1.0668 = 1.0668 → округление до 1.067
            double res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);
        }
    }
}

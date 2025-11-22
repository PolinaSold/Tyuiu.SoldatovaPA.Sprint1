using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculatePerimetrCircle()
        {
            DataService ds = new DataService();
            int radius = 5;
            double wait = 31.416;
            double res = ds.CalculatePerimetrCircle(radius);
            Assert.AreEqual(wait, res);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double wait = 3.0; // (9/3)=3, 3*4=12, 12/3=4, 4/2=2, 2+1=3
            double res = ds.Calculate();
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_CheckStepByStep()
        {
            DataService ds = new DataService();
            double result = ds.Calculate();

            // Проверяем пошагово:
            double step1 = 9.0 / 3.0; // 3
            double step2 = step1 * 4.0; // 12
            double step3 = step2 / 3.0; // 4
            double step4 = step3 / 2.0; // 2
            double step5 = step4 + 1.0; // 3

            Assert.AreEqual(step5, result);
        }
    }
}

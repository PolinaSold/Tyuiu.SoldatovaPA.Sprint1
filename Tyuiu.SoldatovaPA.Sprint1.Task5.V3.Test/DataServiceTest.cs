using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_ExampleFromCondition()
        {
            DataService ds = new DataService();
            int k = 130985;
            int wait = 9;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_SixDigitNumber()
        {
            DataService ds = new DataService();
            int k = 123456;
            int wait = 4;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_ThreeDigitNumber()
        {
            DataService ds = new DataService();
            int k = 789;
            int wait = 7;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_FourDigitNumber()
        {
            DataService ds = new DataService();
            int k = 4567;
            int wait = 5;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}

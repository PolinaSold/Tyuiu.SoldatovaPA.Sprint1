using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SoldatovaPA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLastLetterWord()
        {
            DataService ds = new DataService();
            string text = "Привет мир программирование";
            string wait = "трне";
            string res = ds.LastLetterWord(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidLastLetterWord_WithPunctuation()
        {
            DataService ds = new DataService();
            string text = "Hello, world! How are you?";
            string wait = "owru";
            string res = ds.LastLetterWord(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidLastLetterWord_SingleWord()
        {
            DataService ds = new DataService();
            string text = "Тест";
            string wait = "т";
            string res = ds.LastLetterWord(text);
            Assert.AreEqual(wait, res);
        }
    }
}

using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            StringBuilder result = new StringBuilder();

            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t', '\n' },
                                      StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char lastChar = word[word.Length - 1];
                    result.Append(lastChar);
                }
            }

            return result.ToString();
        }
    }
}
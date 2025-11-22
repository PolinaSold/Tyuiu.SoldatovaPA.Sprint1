using System;
using Tyuiu.SoldatovaPA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 3 | ИСПБ-25-1                   *");
            Console.WriteLine("* Составление строки из последних букв всех слов  *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите текст: ");
                string text = Console.ReadLine();

                if (!string.IsNullOrEmpty(text))
                {
                    string result = ds.LastLetterWord(text);
                    Console.WriteLine($"Строка из последних букв: \"{result}\"");
                }
                else
                {
                    Console.WriteLine("Ошибка: текст не может быть пустым.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

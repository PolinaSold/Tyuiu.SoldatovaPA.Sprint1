using System;
using Tyuiu.SoldatovaPA.Sprint1.Task3.V7.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 7 | ИСП-б-25-1                  *");
            Console.WriteLine("* Пересчет расстояния из верст в километры        *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите расстояние в верстах -> ");
                double verst = Convert.ToDouble(Console.ReadLine());

                if (verst >= 0)
                {
                    double km = ds.VerstsToKilometers(verst);
                    Console.WriteLine($"{verst} верст – это {km:F3} км.");
                }
                else
                {
                    Console.WriteLine("Ошибка: расстояние не может быть отрицательным.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите число.");
            }

            Console.ReadKey();
        }
    }
}

using System;
using Tyuiu.SoldatovaPA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 16 | ИСП-б-25-1                 *");
            Console.WriteLine("* Вычисление периметра круга                      *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");

            Console.Write("Введите радиус круга: ");
            int radius = Convert.ToInt32(Console.ReadLine());

            double result = ds.CalculatePerimetrCircle(radius);
            Console.WriteLine($"Периметр круга: {result:F3}");

            Console.ReadKey();
        }
    }
}
using System;
using Tyuiu.SoldatovaPA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 9 | ИСПБ-25-1                   *");
            Console.WriteLine("* Вычисление выражения (9/3)*4/3/2+1              *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение *");
            Console.WriteLine("* (9/3)*4/3/2+1 и печатает результат на экране.   *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            Console.WriteLine("Выражение: (9/3)*4/3/2+1");

            Console.WriteLine("***************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
            Console.WriteLine("***************************************************");

            double result = ds.Calculate();
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}

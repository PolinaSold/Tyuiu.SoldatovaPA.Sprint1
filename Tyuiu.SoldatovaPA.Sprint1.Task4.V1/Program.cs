using System;
using Tyuiu.SoldatovaPA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 1 | ИСПБ-25-1                   *");
            Console.WriteLine("* Вычисление выражения 1/(x+2)^2                  *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у       *");
            Console.WriteLine("* пользователя исходные данные, вычисляет         *");
            Console.WriteLine("* результат по формуле и печатает его на экране.  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("* Формула: 1/(x+2)^2                             *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (x != -2)
                {
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                    Console.WriteLine("***************************************************");

                    double result = ds.Calculate(x);
                    Console.WriteLine($"1/({x}+2)^2 = {result:F3}");
                }
                else
                {
                    Console.WriteLine("Ошибка: x не может быть равен -2 (деление на ноль).");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите числовое значение.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

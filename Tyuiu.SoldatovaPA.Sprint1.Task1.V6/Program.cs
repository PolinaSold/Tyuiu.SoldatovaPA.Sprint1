using System;
using Tyuiu.SoldatovaPA.Sprint1.Task1.V6.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 6 | ИСП-б-23-1                  *");
            Console.WriteLine("* Вычисление выражения (x+y)/(3*y)                *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у       *");
            Console.WriteLine("* пользователя исходные данные, вычисляет         *");
            Console.WriteLine("* результат по формуле (x+y)/(3*y) и печатает его *");
            Console.WriteLine("* на экране.                                      *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                Console.WriteLine("***************************************************");

                double result = ds.Calculate(x, y);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите числовые значения.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль. Значение y не должно быть равно 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
   
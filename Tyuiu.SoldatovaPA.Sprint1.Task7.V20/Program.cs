using System;
using Tyuiu.SoldatovaPA.Sprint1.Task7.V20.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 20 | ИСПБ-25-1                  *");
            Console.WriteLine("* Вычисление математического выражения            *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет           *");
            Console.WriteLine("* математическое выражение по исходным значениям  *");
            Console.WriteLine("* данных, вводимых пользователем. Ответ округлите *");
            Console.WriteLine("* до 3 знаков после запятой.                      *");
            Console.WriteLine("*                                                 *");
            Console.WriteLine("*     2 + cos²(x + y)                             *");
            Console.WriteLine("* z = ———————————————————— + x*y                  *");
            Console.WriteLine("*     1 + |x - 3x/(1 + x²y²)|                     *");
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

                double z = ds.Calculate(x, y);
                Console.WriteLine($"z = {z:F3}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите числовые значения.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
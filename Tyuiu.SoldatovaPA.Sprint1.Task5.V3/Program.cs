using System;
using Tyuiu.SoldatovaPA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SoldatovaPA.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************");
            Console.WriteLine("* ПР №1 | Вариант 3 | ИСПБ-25-1                   *");
            Console.WriteLine("* Получение третьей цифры от конца числа          *");
            Console.WriteLine("* Автор: Солдатова П.А.                           *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                        *");
            Console.WriteLine("* Присвоить целой переменной h третью от конца    *");
            Console.WriteLine("* цифру в записи положительного целого числа k    *");
            Console.WriteLine("* (например, если k=130985, то h=9).              *");
            Console.WriteLine("***************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                *");
            Console.WriteLine("***************************************************");

            try
            {
                Console.Write("Введите положительное целое число k: ");
                int k = Convert.ToInt32(Console.ReadLine());

                if (k > 0)
                {
                    if (k >= 100)
                    {
                        Console.WriteLine("***************************************************");
                        Console.WriteLine("* РЕЗУЛЬТАТ:                                     *");
                        Console.WriteLine("***************************************************");

                        int h = ds.Calculate(k);
                        Console.WriteLine($"Третья цифра от конца числа {k} = {h}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: число должно содержать минимум 3 цифры.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: число должно быть положительным.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

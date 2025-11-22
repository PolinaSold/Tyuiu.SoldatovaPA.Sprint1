using System;
using CalcLib_SoldatovaPA;

namespace PR1_SoldatovaPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("**    ПР №1. Вычисление арифметического выражения **");
            Console.WriteLine("**             Автор: Soldatova P.A.             **");
            Console.WriteLine("***************************************************");
            Console.WriteLine();

            // Вычисление выражения (9/3)*4/3/2+1
            double result = Calculator.CalculateExpression();

            Console.WriteLine($"Выражение: (9/3)*4/3/2+1");
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine();

            Console.WriteLine("Для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}

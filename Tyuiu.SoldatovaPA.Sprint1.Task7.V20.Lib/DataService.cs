using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            // Вычисляем выражение по частям:

            // Числитель: 2 + cos²(x + y)
            double cosValue = Math.Cos(x + y);
            double numerator = 2 + Math.Pow(cosValue, 2);

            // Знаменатель: 1 + |x - 3x/(1 + x²y²)|
            double denominatorInner = 1 + Math.Pow(x, 2) * Math.Pow(y, 2);
            double denominatorPart = x - (3 * x) / denominatorInner;
            double denominator = 1 + Math.Abs(denominatorPart);

            // Основная дробь + x*y
            double result = numerator / denominator + x * y;

            return Math.Round(result, 3);
        }
    }
}

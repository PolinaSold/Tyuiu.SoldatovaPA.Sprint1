using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task4V1
    {
        public double Calculate(double x)
        {
            double denominator = x + 2;
            double result = 1 / (denominator * denominator);
            return Math.Round(result, 3);
        }
    }
}
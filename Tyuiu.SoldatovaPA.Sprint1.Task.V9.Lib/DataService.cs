using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task0.V9.Lib
{
    public class DataService : ISprint1Task0V9
    {
        public double Calculate()
        {
            // Вычисление выражения (9/3)*4/3/2+1
            double result = (9.0 / 3.0) * 4.0 / 3.0 / 2.0 + 1.0;
            return result;
        }
    }
}
 
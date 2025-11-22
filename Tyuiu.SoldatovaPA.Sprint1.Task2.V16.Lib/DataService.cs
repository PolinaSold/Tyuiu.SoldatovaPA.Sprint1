using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            return Math.Round(2 * Math.PI * value, 3);
        }
    }
}
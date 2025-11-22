using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SoldatovaPA.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            // 1 верста = 1066.8 м = 1.0668 км
            double km = verst * 1.0668;
            return Math.Round(km, 3);
        }
    }
}
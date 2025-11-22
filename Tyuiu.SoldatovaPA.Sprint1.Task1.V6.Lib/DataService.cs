using System;

namespace Tyuiu.SoldatovaPA.Sprint1.Task1.V6.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Значение y не может быть равно 0.");
            }

            return (x + y) / (3 * y);
        }
    }
}
  
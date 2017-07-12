using System;

namespace Kalkulator
{
    public class Sinus : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}

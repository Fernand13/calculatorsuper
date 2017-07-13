using System;

namespace Kalkulator.TwoArg
{
    public class Division : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return first / second;
        }
    }
}

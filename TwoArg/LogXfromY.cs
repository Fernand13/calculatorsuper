using System;

namespace Kalkulator.TwoArg
{
    public class LogXfromY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (second < 0 || first == 1 || first <= 0)
            {
                throw new Exception("Не правильно введен логорифм");
            }
            return Math.Log(first,second);
        }
    }
}

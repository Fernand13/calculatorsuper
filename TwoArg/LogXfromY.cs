using System;

namespace Kalkulator.TwoArg
{/// <summary>
/// Class for Log X from Y function
/// </summary>
    public class LogXfromY : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Log X from Y fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
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

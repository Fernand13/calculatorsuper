using System;

namespace Kalkulator.TwoArg
{/// <summary>
/// Class for X pow one division Y function
/// </summary>
    public class Xpow1dY : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for X pow one division Y fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return Math.Pow(first, 1/second);
        }
    }
}

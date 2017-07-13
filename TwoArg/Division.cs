using System;

namespace Kalkulator.TwoArg
{/// <summary>
/// Class for Division function
/// </summary>
    public class Division : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Division fucntion
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
            return first / second;
        }
    }
}

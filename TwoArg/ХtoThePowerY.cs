using System;

namespace Kalkulator.TwoArg
{
    /// <summary>
    /// Class for Х to The Power Y function
    /// </summary>
    public class ХtoThePowerY : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Х to The Power Y  fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first,second);
        }
    }
}

using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Sinus function
    /// </summary>
    public class Sinus : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Sin fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}

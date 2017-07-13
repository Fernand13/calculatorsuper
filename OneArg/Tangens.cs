using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Tangens function
    /// </summary>
    public class Tangens : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Tangens fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}

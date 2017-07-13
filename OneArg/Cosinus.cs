using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Cosinus function
    /// </summary>
    public class Cosinus : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Cos fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}

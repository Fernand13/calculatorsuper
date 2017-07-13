using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Class for Two To The Power X function
    /// </summary>
    public class TwoToThePowerX : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for Two To The Power X fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}

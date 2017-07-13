namespace Kalkulator.TwoArg
{
    /// <summary>
    /// Class for Addition function
    /// </summary>
    public class Addition : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Addition fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}

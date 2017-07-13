namespace Kalkulator.TwoArg
{
    /// <summary>
    /// Class for Min X and Y function
    /// </summary>
    public class MinXY : ITwoArgumentsOperation
    {      
        /// <summary>
        /// Method for Min X and Y fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            if (first > second) return second;
            else return first;
        }
    }
}

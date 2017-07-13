using System;

namespace Kalkulator.OneArg
{
    /// <summary>
    /// Interface for factory
    /// </summary>
    public static class OneArgumentsCalculatorsFactory
    {
        /// <summary>
        /// Method for factory
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public static IOneArgumentsOperation CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new Sinus();
                case "Cos":
                    return new Cosinus();
                case "Tan":
                    return new Tangens();
                case "Pow2":
                    return new XtoThePowerTwo();
                case "Powx":
                    return new TwoToThePowerX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

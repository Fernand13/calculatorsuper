using System;

namespace Kalkulator.OneArg
{
    public static class OneArgumentsCalculatorsFactory
    {
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

namespace Kalkulator.TwoArg
{
    public class Subtraction : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
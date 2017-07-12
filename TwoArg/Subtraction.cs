namespace Kalkulator
{
    public class Subtraction : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
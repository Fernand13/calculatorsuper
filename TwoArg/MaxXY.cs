namespace Kalkulator
{
    public class MaxXY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (first > second) return first;
            else return second;
        }
    }
}

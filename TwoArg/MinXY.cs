namespace Kalkulator
{
    public class MinXY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (first > second) return second;
            else return first;
        }
    }
}

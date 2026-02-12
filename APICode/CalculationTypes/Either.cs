namespace ProbabilityCalculator.CalculationTypes
{
    public class Either :ICalculationType
    {
        public string Type => "either";

        public double Calculate(double p1, double p2)
        {
            return p1 + p2 - (p1 * p2);
        }
    }
}

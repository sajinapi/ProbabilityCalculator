namespace ProbabilityCalculator.CalculationTypes
{
    public class Combined :ICalculationType
    {
        public string Type => "combined";

        public double Calculate(double p1, double p2)
        {
            return p1 * p2;
        }
    }
}

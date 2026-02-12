namespace ProbabilityCalculator
{
    public interface ICalculationType
    {
            string Type { get; }
            double Calculate(double p1, double p2);
        
    }
}

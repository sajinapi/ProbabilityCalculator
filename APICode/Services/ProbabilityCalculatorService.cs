using ProbabilityCalculator.Repositories.Interface;
using ProbabilityCalculator.Services.Interface;

namespace ProbabilityCalculator.Services
{
    public class ProbabilityCalculatorService :IProbabilityCalculatorService
    {
        private readonly IEnumerable<ICalculationType> _calculationTypes;
        private readonly IProbabilityCalculatorRepo _calculatorRepo;
        public ProbabilityCalculatorService(IEnumerable<ICalculationType> calculationTypes, IProbabilityCalculatorRepo calculatorRepo) {
            _calculationTypes = calculationTypes;
            _calculatorRepo = calculatorRepo;
        }

        public double GetProbability(double p1, double p2, string method)
        {
            try
            {
                double result = 0;
                WriteLog("Started for the function: " + method);

                var calculationType = _calculationTypes.FirstOrDefault(w => w.Type == method.ToLower());
                if (calculationType == null)
                {
                    WriteLog("Invalid Method Type");
                    return -1;
                }

                result = calculationType.Calculate(p1, p2);
                WriteLog($"Result for the two numbers {p1} & {p2} is {result}");

                WriteLog("Ended for the function: " + method);
                return result;
            }
            catch(Exception e)
            {
                WriteLog("Failed due to exception: " + e.Message);
                return -1;
            }
        }

        private void WriteLog(string entry)
        {
            _calculatorRepo.Log(entry);
        }
    }
}

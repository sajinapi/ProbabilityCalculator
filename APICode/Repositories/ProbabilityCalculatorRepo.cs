using ProbabilityCalculator.Repositories.Interface;

namespace ProbabilityCalculator.Repositories
{
    public class ProbabilityCalculatorRepo :IProbabilityCalculatorRepo
    {

        public void Log(string message)
        {
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "Logs");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string _filePath = Path.Combine(directory, "log.txt");
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Probability Calculation: {message}";
                writer.WriteLine(logEntry);
            }
        }
    }
}

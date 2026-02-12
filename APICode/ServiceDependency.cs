using ProbabilityCalculator.CalculationTypes;
using ProbabilityCalculator.Repositories;
using ProbabilityCalculator.Repositories.Interface;
using ProbabilityCalculator.Services;
using ProbabilityCalculator.Services.Interface;

namespace ProbabilityCalculator
{
    public static class ServiceDependency
    {
        public static IServiceCollection ProjectDependencies(this IServiceCollection services)
        {
            // Move all your logic here
            services.AddScoped<ICalculationType, Either>();
            services.AddScoped<ICalculationType, Combined>();

            services.AddScoped<IProbabilityCalculatorRepo, ProbabilityCalculatorRepo>();
            services.AddScoped<IProbabilityCalculatorService, ProbabilityCalculatorService>();


            return services;
        }
    }
}

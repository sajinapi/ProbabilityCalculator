using Microsoft.AspNetCore.Mvc;
using ProbabilityCalculator.Services.Interface;

namespace ProbabilityCalculator.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProbabilityCalculatorController : ControllerBase
    {
        private readonly IProbabilityCalculatorService _calculatorService;
        
        public ProbabilityCalculatorController(IProbabilityCalculatorService calculatorService)
        {
            _calculatorService = calculatorService;  
        }

        [HttpPost("GetProbabilityCalculationResult")]
        public IActionResult GetProbabilityCalculationResult([FromBody] Probability probability)
        {
            return Ok(_calculatorService.GetProbability(probability.firstProbability,probability.secondProbability,probability.calculationType));
        }
    }
}

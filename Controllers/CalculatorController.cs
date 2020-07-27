using Microsoft.AspNetCore.Mvc;
using SimpleCalculator.Services;

namespace SimpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {

        private readonly ICalculatorRepository _calculatorRepository;

        public CalculatorController(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }


        [HttpGet()]
        public IActionResult Plus(float numbera, float numberb)
        {
            var IpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            _calculatorRepository.LogCalculationAddress(IpAddress);

            if (!_calculatorRepository.Save())
            {
                return StatusCode(500, "A problem happened with handling your request.");
            }

            return Ok(numbera + numberb);
        }

        [HttpGet()]
        public IActionResult Minus(float numbera, float numberb)
        {
            var IpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            _calculatorRepository.LogCalculationAddress(IpAddress);

            if (!_calculatorRepository.Save())
            {
                return StatusCode(500, "A problem happened with handling your request.");
            }

            return Ok(numbera - numberb);
        }

        [HttpGet()]
        public IActionResult Divide(float numbera, float numberb)
        {
            var IpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            _calculatorRepository.LogCalculationAddress(IpAddress);

            if (!_calculatorRepository.Save())
            {
                return StatusCode(500, "A problem happened with handling your request.");
            }

            return Ok(numbera / numberb);
        }

        [HttpGet()]
        public IActionResult Times(float numbera, float numberb)
        {
            var IpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            _calculatorRepository.LogCalculationAddress(IpAddress);

            if (!_calculatorRepository.Save())
            {
                return StatusCode(500, "A problem happened with handling your request.");
            }

            return Ok(numbera * numberb);
        }

    }
}

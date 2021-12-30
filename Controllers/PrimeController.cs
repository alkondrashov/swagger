using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Swagger.Services;

namespace swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeController : ControllerBase
    {
        private readonly ILogger<PrimeController> _logger;

        public PrimeController(ILogger<PrimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            var service = new PrimeService();
            return service.GeneratePrime(5);
        }
    }
}

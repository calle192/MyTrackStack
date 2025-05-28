using Microsoft.AspNetCore.Mvc;

namespace MyTrackStackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [Produces("application/json")]
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Health check requested at {Time}", DateTime.UtcNow);
            // You can add more health checks here, like checking database connectivity, etc.
            return Ok(new
            {
                Status = "Healthy",
                Timestamp = DateTime.UtcNow
            });

        }
    }

    
}

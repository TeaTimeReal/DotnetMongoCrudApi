using Microsoft.AspNetCore.Mvc;

namespace MongoCrudApi.Controllers
{
    [ApiController]
    [Route("[controller]")] // Placeholder, overridden by derived controllers

    public class GenericMongoCrudController<T> : ControllerBase
    {

        private readonly ILogger<GenericMongoCrudController<T>> _logger;

        public GenericMongoCrudController(ILogger<GenericMongoCrudController<T>> logger)
        {
            _logger = logger;
        }

        [HttpGet("create")]
        public IActionResult CreateEntry()
        {
            _logger.LogInformation("\n" +
                "===============================\n" +
                "Request on /create\n" +
                $"Controller with type {typeof(T).Name}\n" +
                "===============================\n");

 
            return Ok($"Controller with type {typeof(T).Name}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Transaction.Application.UseCases.Transaction.Create;

namespace Transaction.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly CreateTransationUseCase _createTransationUseCase;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            CreateTransationUseCase createTransationUseCase)
        {
            _logger = logger;
            _createTransationUseCase = createTransationUseCase;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _createTransationUseCase.Execute(10);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

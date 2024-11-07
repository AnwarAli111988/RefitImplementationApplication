using Microsoft.AspNetCore.Mvc;
using Refit;

namespace RefitApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDogApi _resp;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDogApi resp)
        {
            _logger = logger;
            _resp = resp;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }



        [HttpGet("Breeds")]
        public async Task<IActionResult> GetBreeds()
        {
            var data = await _resp.GetBread();
            if (data.IsSuccessStatusCode)
            {
                return Ok(data.Content);
            }


            return StatusCode((int)data.StatusCode,data.ReasonPhrase);
        }

    }
}
using BlazorI18N.Shared.Dtos;
using BlazorI18N.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorI18N.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly IWeatherForecastService weatherForecastService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            this.logger = logger;
            this.weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var weatherForecasts = await weatherForecastService.GetWeatherForecasts();
            return weatherForecasts;
        }
    }
}
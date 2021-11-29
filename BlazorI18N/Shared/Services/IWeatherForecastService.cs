namespace BlazorI18N.Shared.Services
{
    public interface IWeatherForecastService
    {
        Task<Dtos.WeatherForecast[]> GetWeatherForecasts();
    }
}

using BlazorI18N.Shared.Dtos;
using BlazorI18N.Shared.Services;

namespace BlazorI18N.Client.Services
{
    internal class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient httpClient;
        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            var response = await httpClient.GetAsync($"{httpClient.BaseAddress}WeatherForecast");
            var content = await response.Content.ReadAsStreamAsync();

            var result = await System.Text.Json.JsonSerializer.DeserializeAsync<WeatherForecast[]>(content);
            return result ?? Array.Empty<WeatherForecast>();
        }
    }
}

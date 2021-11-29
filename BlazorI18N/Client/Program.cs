using BlazorI18N.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<BlazorI18N.Shared.Services.IClientServerSideService, BlazorI18N.Client.Services.ClientServerSideService>();
builder.Services.AddScoped<BlazorI18N.Shared.Services.IWeatherForecastService, BlazorI18N.Client.Services.WeatherForecastService>();

builder.Services.AddLocalization(options =>
{
    //options.ResourcesPath = "/Translations";
});


await builder.Build().RunAsync();


// Blazor WebAssembly App
// ASP.NET Core hosted
// PWA support
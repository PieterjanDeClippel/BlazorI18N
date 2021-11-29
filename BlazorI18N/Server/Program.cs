var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = BlazorI18N.Server.Configuration.NamingPolicies.PascalNamingPolicy);
builder.Services.AddRazorPages();

builder.Services.AddScoped<BlazorI18N.Shared.Services.IClientServerSideService, BlazorI18N.Server.Services.ClientServerSideService>();
builder.Services.AddScoped<BlazorI18N.Shared.Services.IWeatherForecastService, BlazorI18N.Server.Services.WeatherForecastService>();
builder.Services.AddLocalization();
builder.Services.AddRequestLocalization(options =>
{
    options.ApplyCurrentCultureToResponseHeaders = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRequestLocalization(options =>
{
    options.SetDefaultCulture("en-EN");
    options.AddSupportedCultures("en-EN", "nl-NL", "fr-FR");
    options.AddSupportedUICultures("en-EN", "nl-NL", "fr-FR");
});

app.UseRouting();
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToPage("/_Host");

app.Run();

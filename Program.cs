using MongoDB.Driver;
using ProductService.Providers;
using ProductService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var mongoDbConnectionString = Environment.GetEnvironmentVariable("MONGODB_CONNECTION_STRING");
var mongoClient = new MongoClient(mongoDbConnectionString);
var mongoDatabase = mongoClient.GetDatabase("ProductService");
builder.Services.AddSingleton(mongoDatabase);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder.WithOrigins("http://localhost:3000",
                                        "https://productlicenseapproval-bsb3a3buh3bwavfy.northeurope-01.azurewebsites.net")  // Allow your frontend's URL

                          .AllowAnyHeader()                   // Allow all headers
                          .AllowAnyMethod()                   // Allow all methods (GET, POST, etc.)
                          .AllowCredentials());
});

builder.Services.AddScoped<ProductProvider>();
builder.Services.AddScoped<IProductService, ProductService.Services.ProductService>();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseCors("AllowLocalhost"); // Apply the CORS policy

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

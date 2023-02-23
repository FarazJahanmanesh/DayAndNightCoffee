using DayAndNightCoffee.Infra.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DayAndNightCoffeeDbContext>(options =>
    options.UseSqlServer("Server=.;Database=DayAndNightCoffee;Trusted_Connection=True;"));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

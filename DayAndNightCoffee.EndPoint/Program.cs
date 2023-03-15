using DayAndNightCoffee.Core.Application.Services;
using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Infra.Database;
using DayAndNightCoffee.Infra.Database.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductServices, ProductServices>();
builder.Services.AddScoped<ICategoryProductRepository, CategoryProductRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<ICategoryProductServices, CategoryProductServices>();

builder.Services.AddDbContext<DayAndNightCoffeeDbContext>(options =>
    options.UseSqlServer("Server=.;Database=DayAndNightCoffee;Trusted_Connection=True;"));

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();

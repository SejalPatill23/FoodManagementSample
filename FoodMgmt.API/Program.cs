using FoodMgmt.Application.Interfaces;
using FoodMgmt.Application.Services;
using FoodMgmt.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconn")));


//builder.Services.AddDbContext<AppDBContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IBrandService, BrandService>();
var app = builder.Build();

// Configure the HTTP request pipeline
//xgff
app.UseAuthorization();

app.MapControllers();

app.Run();

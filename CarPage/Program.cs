using Microsoft.EntityFrameworkCore;
using CarPage.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CarPage.Models.CarContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

app.UseStaticFiles();


app.MapDefaultControllerRoute();

app.Run();
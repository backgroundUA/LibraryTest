using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
var builder = WebApplication.CreateBuilder(args);



string connection = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var db = new AppDbContext();
db.Database.Migrate();

var app = builder.Build();

app.Run();


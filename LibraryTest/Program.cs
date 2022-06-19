using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string connection = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var librarian1 = new LibrarianEntity();

librarian1.Name = "Sara";

var db = new AppDbContext();
db.Libraryan.Add(librarian1);


app.Run();


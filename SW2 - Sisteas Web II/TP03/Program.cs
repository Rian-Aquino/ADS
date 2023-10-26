/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TP03.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TP03Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("TP03Context") ?? throw new InvalidOperationException("Connection string 'TP03Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

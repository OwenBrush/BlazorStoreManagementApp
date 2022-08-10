using InventoryDatabase.Plugins.InMemory;
using InventoryDatabase.UseCases.Inventories;
using InventoryDatabase.UseCases.Inventories.Interfaces;
using InventoryDatabase.UseCases.Locations;
using InventoryDatabase.UseCases.Locations.Interfaces;
using InventoryDatabase.UseCases.PluginInterfaces;
using InventoryDatabase.WebApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<ILocationRepository, LocationRepository>();

builder.Services.AddTransient<IInventoriesFilterUseCase, InventoriesFilterUseCase>();
builder.Services.AddTransient<IInventoriesAddUseCase, InventoriesAddUseCase>();
builder.Services.AddTransient<IInventoriesRemoveUseCase, InventoriesRemoveUseCase>();
builder.Services.AddTransient<ILocationsAddUseCase, LocationsAddUseCase>();
builder.Services.AddTransient<ILocationsRemoveUseCase, LocationsRemoveUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

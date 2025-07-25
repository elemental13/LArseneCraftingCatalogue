using LArseneCraftingCatalogue.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// create the entity framework database
var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        var DbPath = Path.Join(path, "crafting.db");
// using var db = new CraftingContext();
Console.WriteLine($"Database path: {DbPath}");
// Operations.Initialize(db);

// add DP injection for the db so other pages can use them
builder.Services.AddDbContext<CraftingContext>(options =>
    options.UseSqlite($"Data Source={DbPath}"), ServiceLifetime.Transient);

builder.Services.AddSingleton<CraftingService>();
builder.WebHost.UseUrls("http://*:5000");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();

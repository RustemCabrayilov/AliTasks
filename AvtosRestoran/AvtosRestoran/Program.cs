using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Abstractions;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


builder.Services.AddDbContext<AvtosDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-NIJAT;Database=AftosApp;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");
});

builder.Services.AddScoped<IRepository<Service>, Repository<Service>>();


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


//app.UseEndpoints(router =>
//{
//    router.MapAreaRoute(
//         name: "admin",
//         areaName: "admin",
//         template: "admin/{controller=Home}/{action=Index}/{id?}");
//    router.MapRoute(
//        name: "default",
//        template: "{controller=Home}/{action=Index}/{id?}");
//});

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "admin",
        areaName:"admin",
        pattern: "admin/{controller=Home}/{action=Index}/{id?}",
        defaults: new { area = "admin" });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});



app.Run();

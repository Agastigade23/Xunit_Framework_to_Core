using Microsoft.EntityFrameworkCore;
using WebApp_Xunit.Models;
using WebApp_Xunit.Repository;
using WebApp_Xunit.Services.Interface;
using WebApp_Xunit.Services;
using WebApp_Xunit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var cons = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
builder.Services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(cons));

builder.Services.AddTransient<IRepository<AirportInfo>, Repository<AirportInfo>>();
builder.Services.AddTransient<IRepository<CityInfo>, Repository<CityInfo>>();
builder.Services.AddTransient<IRepository<FeedBack>, Repository<FeedBack>>();
builder.Services.AddTransient<IRepository<StateImg>, Repository<StateImg>>();


builder.Services.AddTransient<IAirportService, AirportServices>();
builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<IStateService, StateService>();
builder.Services.AddTransient<IFeedBackService, FeedBackService>();
builder.Services.AddTransient<IDistMethods, DistMethods>();

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

app.UseAuthorization();

app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Airport}/{action=Index}/{id?}");



app.Run();

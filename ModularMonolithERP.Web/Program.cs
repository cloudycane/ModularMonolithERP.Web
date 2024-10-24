using Microsoft.EntityFrameworkCore;
using ModularMonolithERP.Application.UseCases.GetQueries;
using ModularMonolithERP.Core.Interfaces;
using ModularMonolithERP.Infrastructure.DataAccess;
using ModularMonolithERP.Infrastructure.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
// Add DbContext Service
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ProductoSuministradorGetQuery>();
builder.Services.AddScoped<SuministradorGetQuery>();

builder.Services.AddScoped<ITransaccionRepositorio, TransaccionRepositorio>();
builder.Services.AddScoped<ISuministradorRepositorio, SuministradorRepositorio>();
builder.Services.AddScoped<IProductoSuministradorRepositorio, ProductoSuministradorRepositorio>();
builder.Services.AddScoped<IOrdenCarritoRepositorio, OrdenCarritoRepositorio>();
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
    pattern: "{area=Cliente}/{controller=Home}/{action=Index}/{id?}");

app.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductStore.Data;
using ProductStore.Models;
using ProductStore.Work.Managers;
using ProductStore.Work.Repository;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContext' not found.")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>()
               //.AddDefaultUI()
               .AddDefaultTokenProviders();

builder.Services.AddScoped<ICategoryRepository, CategoryRepositoryImpl>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepositoryImpl>();

builder.Services.AddScoped<IProductRepository, ProductRepositoryImpl>();
builder.Services.AddTransient<IProductRepository, ProductRepositoryImpl>();

builder.Services.AddScoped<IOrderRepository, OrderRepositoryImpl>();
builder.Services.AddTransient<IOrderRepository, OrderRepositoryImpl>();

builder.Services.AddScoped<CategoryManager>();
builder.Services.AddScoped<ProductManager>();
builder.Services.AddScoped<ShoppingCart>();
builder.Services.AddScoped<OrderManager>();

builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


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

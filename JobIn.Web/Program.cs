using Microsoft.EntityFrameworkCore;
using JobIn.Data.Context;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using JobIn.Data.Extensions;
using JobIn.Service.Extensions;
using Microsoft.AspNetCore.Builder;
using JobIn.Entity.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Connection string kontrolü
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? "Server=LAPTOP-B20RK80B\\SQLEXPRESS04;Database=JobInDb;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=60;";

Console.WriteLine($"Connection String: {connectionString}");

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("❌ Connection string bulunamadı!");
    // Tüm konfigürasyonu yazdır
    foreach (var kv in builder.Configuration.AsEnumerable())
    {
        Console.WriteLine($"{kv.Key} = {kv.Value}");
    }
}
else
{
    Console.WriteLine("✅ Connection string başarıyla yüklendi");
}

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString, sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure();
    });
});

// 🔹 Katman servislerini yükle
builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtensions();
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// 🔹 Identity ayarları
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// 🔹 Cookie ayarları
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "JobIn",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(30);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Development modunda detaylı hata sayfası göster
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Static files ayarları
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapDefaultControllerRoute();
});

app.Run();
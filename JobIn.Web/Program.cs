using Microsoft.EntityFrameworkCore;
using JobIn.Data.Context;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using JobIn.Data.Extensions;
using JobIn.Service.Extensions;
using Microsoft.AspNetCore.Builder;
using JobIn.Entity.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtensions();
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");   //Kullanýcý login olmadan baþka sayfaya týklarsa otomatil login sayfasýna yönlendirir.
    config.LogoutPath = new PathString("/Admin/Auth/Logout"); //Kullanýcý oturmu sonlandýrmak istediðinde bu sayfaya yönlendiri.
    config.Cookie = new CookieBuilder
    {
        Name = "JobIn",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest //Canlýda Always seçilmeli. http,https ikisi birlikte
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(30);  //Kullanýcý sisteme giriþ yaptýktan sonra oturumu 30 gün boyunca sistemde açýk olsun
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");  //yetkisiz eriþimlerde uyarý sayfaya yönlendirir
});
 
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
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();      //Authentication altta kalmasý gerek.

app.UseEndpoints(endpoints =>
{
   endpoints.MapAreaControllerRoute(
   name: "Admin",
   areaName:"Admin",
   pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
    );
   endpoints.MapDefaultControllerRoute();
});

app.Run();

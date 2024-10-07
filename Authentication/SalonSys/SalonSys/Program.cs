using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SalonSys.Areas.Identity.Data;
using SalonSys.Data;
using SalonSys.Models;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevDB") ?? throw new InvalidOperationException("Connection string 'DevDB' not found.");

builder.Services.AddDbContext<SalonDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SalonSysUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SalonDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//Dependency Injection for DbContext
//builder.Services.AddDbContext<BookingDbContext>(options => 
//options.UseSqlServer(builder.Configuration.GetConnectionString("DevDB")));

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

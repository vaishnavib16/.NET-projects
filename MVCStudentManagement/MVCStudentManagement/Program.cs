using Microsoft.EntityFrameworkCore;
using MVCStudentManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var con = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(con, ServerVersion.AutoDetect(con)));

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

app.Run();

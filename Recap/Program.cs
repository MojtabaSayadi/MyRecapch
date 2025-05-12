using Microsoft.EntityFrameworkCore;
using MyRecapch.Core.Services.Implementations;
using MyRecapch.Core.Services.Interfaces;
using MyRecapch.Data.Context;
using MyRecapch.Data.Repositories;
using MyRecapch.Domain.Interfaces;
using Recapch.Ioc;
using static MyRecapch.Domain.ViewModel.Security.CapchaViewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region Add Db Context
builder.Services.AddDbContext<RecapchaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Myconnection"));
});
#endregion
builder.Services.RegisterServices();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();


#region GoogleRecaptcha
builder.Configuration.GetSection("GoogleRecapcha").Get<GoogleRecapchaViewModel>();
#endregion







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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

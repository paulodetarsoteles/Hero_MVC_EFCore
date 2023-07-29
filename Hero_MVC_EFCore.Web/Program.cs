using Hero_MVC_EFCore.DAL.Data;
using Hero_MVC_EFCore.DAL.Repositories;
using Hero_MVC_EFCore.DAL.Repositories.Interfaces;
using Hero_MVC_EFCore.Web.Service;
using Hero_MVC_EFCore.Web.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        builder.Services.AddTransient<IFilmRepository, FilmRepository>();
        builder.Services.AddTransient<IHeroRepository, HeroRepository>();
        builder.Services.AddTransient<IPowerRepository, PowerRepository>();
        builder.Services.AddTransient<ISecretIdentityRepository, SecretIdentityRepository>();

        builder.Services.AddTransient<IFilmViewModelService, FilmViewModelService>();
        builder.Services.AddTransient<IHeroViewModelService, HeroViewModelService>();
        builder.Services.AddTransient<IPowerViewModelService, PowerViewModelService>();
        builder.Services.AddTransient<ISecretIdentityViewModelService, SecretIdentityViewModelService>();

        builder.Services.AddControllersWithViews();

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
    }
}
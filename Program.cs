using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestWebApp.Reps;

namespace TestWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            builder.Services.AddDbContext<LibraryDb>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            builder.Services.AddScoped<DbRepository>();

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
                pattern: "{controller=Games}/{action=GameList}");

            app.Run();
        }
    }
}

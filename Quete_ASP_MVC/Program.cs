using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Quete_ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "/{controller=Atelier}/{action=Index}/{maxVal=15}"
            //    );
            app.MapControllerRoute(
                name: "default",
                pattern: "/{controller=Article}/{action=Index}/{id?}"
                );
            app.Run();
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using _27_ExceptionHanling.Exceptions;

namespace _27_ExceptionHanling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(config =>
            {
                config.Filters.Add(typeof(MyExceptionFilter));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error"); // Hata i�leme denetim eylemi i�in yol belirtin
                app.UseStatusCodePagesWithReExecute("/Home/Error/{0}"); // �ste�e ba�l�: Hata sayfalar�nda durum kodunu g�ster
                app.UseHsts(); // �ste�e ba�l�: HTTPS'yi zorla
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
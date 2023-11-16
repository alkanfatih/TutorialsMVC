using Microsoft.Extensions.FileProviders;

namespace _30_Middleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            // Maintenance mode middleware'ini ekleyin
            app.UseMaintenanceMode(isMaintenanceMode: true);

            // UseStaticFiles middleware'i özelleþtirme
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
                RequestPath = "/custom-static",
                OnPrepareResponse = context =>
                {
                    // Ýsteðe özel olarak HTTP yanýtýný özelleþtirebilirsiniz
                    context.Context.Response.Headers.Add("Cache-Control", "public,max-age=604800");
                }
            });


            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
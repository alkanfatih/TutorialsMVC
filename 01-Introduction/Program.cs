namespace _01_Introduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Hizmetlerin Eklenmesi
            //Web uygulamanýzýn temelinde MVC modelini kullanmaya baþladýðýnýzý belirtir.
            builder.Services.AddControllersWithViews();

            //Uygualama Ayarlarý
            var app = builder.Build();

            //HTTP isteklerini doðru denetleyici (controller) ve metoda (action) yönlendirmek için.
            app.UseRouting();
            //app.MapGet("/", () => "Hello World!");

            app.MapDefaultControllerRoute();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
namespace _01_Introduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Hizmetlerin Eklenmesi
            //Web uygulaman�z�n temelinde MVC modelini kullanmaya ba�lad���n�z� belirtir.
            builder.Services.AddControllersWithViews();

            //Uygualama Ayarlar�
            var app = builder.Build();

            //HTTP isteklerini do�ru denetleyici (controller) ve metoda (action) y�nlendirmek i�in.
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
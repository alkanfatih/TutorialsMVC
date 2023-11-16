using _26_Identity.Contexts;
using _26_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _26_Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // EntityServices
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true; // En az bir rakam gerekiyor
                options.Password.RequiredLength = 8; // Minimum 8 karakter uzunluðunda olmalý
                options.Password.RequireLowercase = true; // En az bir küçük harf gerekiyor
                options.Password.RequireUppercase = true; // En az bir büyük harf gerekiyor
                options.Password.RequireNonAlphanumeric = true; // En az bir sembol gerekiyor

                //Diðer Kimlik Ayarlarý
                options.SignIn.RequireConfirmedEmail = true; // E-posta onayý gerektirilsin mi?
                options.SignIn.RequireConfirmedPhoneNumber = false; // Telefon numarasý onayý gerektirilsin mi?
            })
            .AddEntityFrameworkStores<AppDbContext>()
              .AddDefaultTokenProviders();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy =>
                {
                    policy.RequireRole("Admin");
                });
            });


            builder.Services.ConfigureApplicationCookie(options => 
            {
                options.LoginPath = "/Account/Login"; // Giriþ yapýlacak sayfa
                options.LogoutPath = "/Account/Logout"; // Çýkýþ yapýlacak sayfa
                options.AccessDeniedPath = "/Account/AccessDenied"; // Yetkilendirme hatasý sayfasý
                options.SlidingExpiration = true; // Oturum süresi uzatýlsýn mý?
                options.ExpireTimeSpan = TimeSpan.FromDays(14); // Oturum süresi uzatma eþiði

            });

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
using _29_Caching.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace _29_Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        public IActionResult User()
        {
            // Bellekte veri var mı kontrol et
            if (!_cache.TryGetValue("KullaniciAdi", out string kullaniciAdi))
            {
                // Bellekte veri yoksa, veriyi oluştur ve belleğe ekle
                kullaniciAdi = "Fatih Alkan"; // Örnek bir kullanıcı adı
                _cache.Set("KullaniciAdi", kullaniciAdi, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10) // Bellekten silinme süresi
                });
                ViewBag.Mesaj = "Belleğe yeni veri eklendi.";
            }
            else
            {
                // Bellekte veri varsa, o veriyi kullan
                ViewBag.Mesaj = "Bellekten alınan veri: " + kullaniciAdi;
            }

            return View();
        }


        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
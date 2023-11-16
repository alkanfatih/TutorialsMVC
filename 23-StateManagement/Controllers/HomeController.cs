using _23_StateManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _23_StateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //https://example.com/home/index?id=123&name=John
        public IActionResult Index()
        {
            // Query string parametrelerine erişim örnekleri
            // 1. Tek bir parametreye erişim:
            string id = HttpContext.Request.Query["id"];

            // 2. Birden fazla parametreye erişim:
            string name = HttpContext.Request.Query["name"];

            // 3. Parametre var mı yok mu kontrolü:
            bool hasAge = HttpContext.Request.Query.ContainsKey("age");
            if (hasAge)
            {
                string age = HttpContext.Request.Query["age"];
            }

            // 4. Tüm query string parametrelerini döngü ile alma:
            foreach (var queryParam in HttpContext.Request.Query)
            {
                string key = queryParam.Key;
                string value = queryParam.Value;
            }

            // Bu verileri modelinize atayabilir veya işleyebilirsiniz.

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
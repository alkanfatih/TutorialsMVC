using _06_ViewModelKullanimi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _06_ViewModelKullanimi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            Product product = new Product()
            {
                Title = "Toilet Paper",
                Price = 1.99
            };
            return View(product);
        }

        [HttpGet]
        public ActionResult FormCollection()
        {
            return View();
        }

        [HttpPost] // HTTP POST isteği ile çalışacak eylem
        public ActionResult FormCollection(IFormCollection form)
        {
            // Form Collection'dan verileri çekelim
            string name = form["name"];
            string email = form["email"];

            // Verileri kullanarak işlem yapabiliriz
            // Diğer işlemler...

            return RedirectToAction("Success");
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
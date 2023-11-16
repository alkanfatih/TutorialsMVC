using _08_ViewPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _08_ViewPartialView.Controllers
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
            List<Product> products = new List<Product>()
            {
                new Product { Id=1, Name="Kalem-1", Price=14.9m },
                new Product { Id=2, Name="Kalem-2", Price=9.5m },
                new Product { Id=3, Name="Kalem-3", Price=20m }
            };
            return View(products);
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
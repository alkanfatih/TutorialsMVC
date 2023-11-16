using _04_ControllerActionFilter.Logs;
using _04_ControllerActionFilter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_ControllerActionFilter.Controllers
{
    [TypeFilter(typeof(LogActionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 3600)] // 1 saat boyunca önbellekle
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
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
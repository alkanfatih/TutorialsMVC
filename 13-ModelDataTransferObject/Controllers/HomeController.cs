using _13_ModelDataTransferObject.Models;
using _13_ModelDataTransferObject.Records;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13_ModelDataTransferObject.Controllers
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
            var person1 = new Person("John", "Doe");
            var person2 = new Person("Jane", "Doe");

            return Content((person1 == person2).ToString());
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
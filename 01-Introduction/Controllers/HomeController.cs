using _01_Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01_Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            //return Content("Merhanba MVC Dünyası - İlk Controller");

            Product product = new Product()
            {
                Id = 1,
                Name = "Kalem",
                Price = 150
            };
            return View(product);
        }
    }
}

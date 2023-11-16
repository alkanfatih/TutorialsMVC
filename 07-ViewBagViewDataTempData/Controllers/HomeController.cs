using _07_ViewBagViewDataTempData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using System.Diagnostics;

namespace _07_ViewBagViewDataTempData.Controllers
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

        public IActionResult Page1()
        {
            ViewBag.Title = "Öğrenciler";

            List<string> Student = new List<string>();
            Student.Add("Fatih");
            Student.Add("Beyazıt");
            Student.Add("Cem");

            ViewBag.Student = Student;
            return View();
        }

        public IActionResult Page2() 
        {
            ViewData["Title"] = "Öğrenciler";

            List<string> Student = new List<string>();
            Student.Add("Fatih");
            Student.Add("Beyazıt");
            Student.Add("Cem");

            ViewData["Student"] = Student;
            return View();
        }

        public IActionResult Page3()
        {
            TempData["Title"] = "Öğrenciler";

            List<string> Student = new List<string>();
            Student.Add("Fatih");
            Student.Add("Beyazıt");
            Student.Add("Cem");

            TempData["Student"] = Student;
            return View();
        }

        public IActionResult Page4()
        {
            TempData["ErrorMessage"] = "Bir hata gerçekleşti.";

            return RedirectToAction("Error");
        }

        public IActionResult Error()
        {
            //var errorMessage = TempData["ErrorMessage"] as string;
            //Bu kullanımda herhangi bir peek veya keep metodu kullanılmadığından dolayı ilk okuma gerçekleştikten sonra veriler silinecektir.

            //var errorMessage = TempData.Peek("ErrorMessage") as string;
            //Bu örnekte ise peek metodu kullanıldığından dolayı veri okunmadan önce bir sonraki istek için TempData'da saklanmaya devam edecektir. 

            var errorMessage = TempData["ErrorMessage"] as string;
            TempData.Keep("ErrorMessage");

            return Content(errorMessage);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
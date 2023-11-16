using _03_ControllerActionResults.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_ControllerActionResults.Controllers
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
            return View(); // Index.cshtml görünüm sayfasını kullanarak HTML oluştur
        }

        public IActionResult GetCustomContent()
        {
            return Content("Özel İçerik", "text/plain"); // Özel metin içeriği gönder
        }

        public IActionResult RedirectToHome()
        {
            return Redirect("/Home/Index"); // /Home/Index sayfasına yönlendir
        }

        public IActionResult RedirectToAbout()
        {
            return RedirectToAction("About", "Home"); // Home Controller'ın About action'ına yönlendir
        }

        public IActionResult RedirectToCustomRoute()
        {
            return RedirectToRoute("CustomRoute"); // "CustomRoute" adlı yönlendirmeye yönlendir
        }

        public IActionResult GetUserData()
        {
            var userData = new { Name = "John", Age = 30 };
            return Json(userData); // JSON verisi döndür
        }

        //public IActionResult DownloadFile()
        //{
        //    byte[] fileContents = GetFileContents(); // Dosyanın içeriği alınır
        //    return File(fileContents, "application/pdf", "example.pdf"); // FileResult döndürülür
        //}

        public IActionResult MyAction()
        {
            // İş mantığını burada gerçekleştirin
            // ...

            if (false) // Eğer belirli bir şart sağlanıyorsa
            {
                return NotFound(); // 404 Not Found yanıtı döndürün
            }
            else if (false) // Eğer başka bir şart sağlanıyorsa
            {
                return BadRequest(); // 400 Bad Request yanıtı döndürün
            }
            else
            {
                // Başarılı bir yanıt oluşturun ve belirli bir veri veya görünüm döndürün
                var data = new { Message = "İşlem başarılı!" };
                return Ok(data); // 200 OK yanıtı döndürün
            }
        }

        //Action Name (Eylem Adı), .NET MVC (Model-View-Controller) veya .NET Core gibi Microsoft platformlarında Controller Actions'ın isimlendirilmesi ve yönlendirilmesi için kullanılan bir kavramdır. 
        [ActionName("CustomList")]
        public IActionResult ListProducts()
        {
            return View();
        }

        [NonAction]
        public IActionResult Privacy()
        {
            return View();
        }

        // Bu bir Controller Action değildir
        [NonAction]
        public void InternalMethod()
        {
            // ...
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
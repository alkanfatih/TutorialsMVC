using _20_ModelMauelValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _20_ModelMauelValidation.Controllers
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            // Modelin belirli özelliklerini manuel olarak doğrulama
            if (string.IsNullOrEmpty(customer.CustomerName))
            {
                ModelState.AddModelError("CustomerName", "Müşteri adı zorunlu bir alan.");
            }

            if (string.IsNullOrEmpty(customer.CustomerEmail) || !customer.CustomerEmail.Contains("@"))
            {
                ModelState.AddModelError("Email", "Geçerli bir e-posta adresi giriniz.");
            }

            if (ModelState.IsValid)
            {
                // Model geçerli, işleme devam edebiliriz.
                // Örneğin, veritabanına müşteriyi ekleyebiliriz.
                // Bu aşamada müşteri verileri, model nesnesi olan 'customer' içinde bulunur.
                // ...
                return RedirectToAction("Success");
            }

            // Model geçerli değil, hata mesajlarıyla birlikte aynı görünümü tekrar göster.
            return View(customer);
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
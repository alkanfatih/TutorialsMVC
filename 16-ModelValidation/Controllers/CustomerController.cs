using _16_ModelValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16_ModelValidation.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
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

        public ActionResult Success()
        {
            return View();
        }
    }

}

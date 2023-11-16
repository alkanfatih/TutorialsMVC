using Microsoft.AspNetCore.Mvc;

namespace _02_ControllerActionVerb.Controllers
{
    public class UserController : Controller
    {
        // HTTP GET isteği ile çalışacak eylem
        [HttpGet]
        public IActionResult CreateForm()
        {
            // Formu görüntüle
            return View();
        }

        // HTTP POST isteği ile çalışacak eylem
        [HttpPost]
        public IActionResult CreateForm(string username, string email, string pass)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass))
            {
                // Kullanıcı adı ve e-posta adresini işle
                // Örneğin, veritabanına kaydet
                return View("Success");
            }
            else
            {
                // Eksik veri varsa aynı sayfayı tekrar görüntüle
                return View();
            }
        }
    }
}

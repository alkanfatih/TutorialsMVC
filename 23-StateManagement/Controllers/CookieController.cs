using Microsoft.AspNetCore.Mvc;

namespace _23_StateManagement.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            //Create Cookie
            Response.Cookies.Append("SessionId", "12345");

            //Read Cookie
            string sessionId = Request.Cookies["SessionId"];
            if (sessionId != null)
            {
                // Çerez değeri bulundu
            }

            //Update Cookie
            Response.Cookies.Append("SessionId", "newSessionId");

            //Delete Cookie
            Response.Cookies.Delete("SessionId");

            //Cookie Settings
            var cookieOptions = new CookieOptions
            {
                Path = "/",
                HttpOnly = true,
                Secure = true,
                IsEssential = true
            };

            Response.Cookies.Append("SessionId", "12345", cookieOptions);

            return View();
        }
    }
}

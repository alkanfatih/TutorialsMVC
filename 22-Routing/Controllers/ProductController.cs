using Microsoft.AspNetCore.Mvc;

namespace _22_Routing.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return Content("Product Listesi");
        }

        public IActionResult Details(int ProductId)
        {
            return Content("Product Detay ID: #" + ProductId);
        }
    }

}

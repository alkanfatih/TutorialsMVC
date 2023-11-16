using _11_ModelModelBinding.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11_ModelModelBinding.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult ShowProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowProduct(int id)
        {
            // id parametresi Model Binding ile doldurulur
            // Bu ID ile veritabanından ürün bilgisini çekebilir veya başka işlemler yapabiliriz
            // Örnek olarak, burada bir ürün detay sayfası gösterme işlemi simüle ediyoruz
            var product = GetProductById(id);
            return View("ProductDetail", product);
        }

        // Veritabanından ürünü çeken varsayılan bir metot
        private Product GetProductById(int id)
        {
            // Burada veritabanından ürün bilgisi çekme işlemi yapılabilir
            // Bu örnekte, basitçe bir Product nesnesi oluşturuyoruz
            return new Product
            {
                Id = id,
                Name = "Ürün Adı",
                Price = 99.99m
            };
        }

    }
}

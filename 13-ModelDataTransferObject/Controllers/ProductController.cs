using _13_ModelDataTransferObject.Models;
using _13_ModelDataTransferObject.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace _13_ModelDataTransferObject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ViewProduct(int productId)
        {
            // Ürünü veritabanından al
            var product = GetProductById(productId);

            // Ürünü ProductDTO'ya dönüştür
            var productDTO = new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                CategoryName = GetCategoryNameById(product.CategoryId)
            };

            return View(productDTO);
        }

        private Product GetProductById(int productId)
        {
            // Veritabanından ürün bilgisi çekme işlemi (örnek olarak, sabit veri kullanıyoruz)
            return new Product
            {
                ProductId = productId,
                Name = "Ürün Adı",
                Price = 99.99m,
                CategoryId = 1 // Örnek kategori ID'si
            };
        }

        private string GetCategoryNameById(int categoryId)
        {
            // Veritabanından kategori adını çekme işlemi (örnek olarak, sabit veri kullanıyoruz)
            return "Elektronik"; // Örnek kategori adı
        }
    }

}

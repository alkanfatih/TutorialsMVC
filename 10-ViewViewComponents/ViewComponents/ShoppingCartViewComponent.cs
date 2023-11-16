using _10_ViewViewComponents.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10_ViewViewComponents.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Örnek alışveriş sepeti verileri
            var cartItems = new List<CartItem>
            {
                new CartItem { ProductName = "Ürün 1", Price = 19.99m },
                new CartItem { ProductName = "Ürün 2", Price = 29.99m },
                new CartItem { ProductName = "Ürün 3", Price = 9.99m }
            };

            var model = new ShoppingCartViewModel
            {
                CartItems = cartItems,
                TotalPrice = CalculateTotalPrice(cartItems)
            };

            return View(model);
        }

        private decimal CalculateTotalPrice(List<CartItem> cartItems)
        {
            // Sepet öğelerinin toplam fiyatını hesaplamak için gereken işlemler
            // Bu örnek için basit bir toplam hesaplaması yapabiliriz
            decimal totalPrice = 0;
            foreach (var item in cartItems)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }

    }
}

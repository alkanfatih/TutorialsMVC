namespace _10_ViewViewComponents.Models
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; } // Sepet öğelerini içeren liste
        public decimal TotalPrice { get; set; } // Toplam fiyat

    }
}

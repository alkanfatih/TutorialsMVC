using System.ComponentModel.DataAnnotations;

namespace _16_ModelValidation.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Müşteri adı zorunlu bir alan.")]
        [StringLength(50, ErrorMessage = "Müşteri adı en fazla 50 karakter olabilir.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunlu bir alan.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunlu bir alan.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        public string Phone { get; set; }

    }
}

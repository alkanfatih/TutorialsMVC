using _17_ModelCustomizeValidationAttribute.Validation;

namespace _17_ModelCustomizeValidationAttribute.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [CustomDateValidation(2023, 1, 1, ErrorMessage = "Tarih 2023-01-01 veya sonrası olmalıdır.")]
        public DateTime ReleaseDate { get; set; }

        public string Name { get; set; }
    }

}

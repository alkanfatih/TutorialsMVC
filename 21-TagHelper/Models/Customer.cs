using System.ComponentModel.DataAnnotations;

namespace _21_TagHelper.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Age { get; set; }
    }
}

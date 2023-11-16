using System.ComponentModel.DataAnnotations;

namespace _19_ModelClientSideValidation.Models
{
    public class User
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunlu bir alan.")]
        public string UserName { get; set; }

    }
}

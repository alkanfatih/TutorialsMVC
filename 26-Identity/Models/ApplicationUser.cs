using Microsoft.AspNetCore.Identity;

namespace _26_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        // Diğer özelleştirmeler...

    }
}

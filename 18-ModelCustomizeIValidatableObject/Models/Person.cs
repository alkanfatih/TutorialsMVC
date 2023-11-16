using System.ComponentModel.DataAnnotations;

namespace _18_ModelCustomizeIValidatableObject.Models
{
    public class Person : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adı zorunludur.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadı zorunludur.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (BirthDate.HasValue && BirthDate.Value > DateTime.Now)
            {
                results.Add(new ValidationResult("Doğum tarihi gelecekte olamaz.", new[] { nameof(BirthDate) }));
            }

            return results;
        }
    }
}

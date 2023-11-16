using System.ComponentModel.DataAnnotations;

namespace _17_ModelCustomizeValidationAttribute.Validation
{
    public class CustomDateValidationAttribute : ValidationAttribute
    {
        private readonly DateTime _startDate;

        public CustomDateValidationAttribute(int startYear, int startMonth, int startDay)
        {
            _startDate = new DateTime(startYear, startMonth, startDay);
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime dateValue)
            {
                // Özel doğrulama mantığını burada uygulayabilirsiniz.
                if (dateValue >= _startDate)
                {
                    return true; // Geçerli
                }
            }
            return false; // Geçersiz
        }

    }
}

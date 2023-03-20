using System.ComponentModel.DataAnnotations;

namespace Validation.Custom_VAlidation
{
    public class DateLessThanToday:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime date=(DateTime)value;
            if(date>DateTime.Now)
            {
                return new ValidationResult("Date cannot be later than today!");
            }
            return ValidationResult.Success;
        }
    }
}

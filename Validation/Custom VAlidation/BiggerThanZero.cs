using System.ComponentModel.DataAnnotations;

namespace Validation.Custom_VAlidation
{
    public class BiggerThanZero:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int _value=(int)value;
            if(_value==0)
            {
                return new ValidationResult("Value connot equal to zero!");
            }
            if(_value<0)
            {
                return new ValidationResult("Value cannot be less than zero!");

            }
            return ValidationResult.Success;
        }
    }
}

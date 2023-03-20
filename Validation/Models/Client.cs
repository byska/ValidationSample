using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Validation.Custom_VAlidation;

namespace Validation.Models
{
    public enum GenderType
    {
        Man,
        Woman
    }
    public class Client:IValidatableObject
    {
        [BiggerThanZero]
        [DisplayName("Client Code"), Required(ErrorMessage ="{0} Cannot be empty!")]
        public int Id { get; set; }
        [DisplayName("Company Name"),Required(ErrorMessage ="Company Name cannot be empty!"),MaxLength(50,ErrorMessage = "Company Name cannot exceed 50 characters!")]
        public string Name { get; set; }
       
        public GenderType Gender { get; set; }

        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "You entered an incorrect e-mail address!")]
        public string? Email { get; set; }
        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        [DateLessThanToday]
        public DateTime BirthDate { get; set; }

        [DisplayName("Customer Notes")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        [DisplayName("Contact Name")]
        [MinLength(5,ErrorMessage = "At least {1} characters must be entered.")]
        [RegularExpression("\\D*",ErrorMessage = "You can only enter letters.")]
        public string ContactName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(this.Gender==GenderType.Woman)
            {
                if(this.Email==null)
                {
                    yield return new ValidationResult("Woman customers must enter e-mail.", new[] { "Gender", "Email" });
                }
            }
        }
    }
}

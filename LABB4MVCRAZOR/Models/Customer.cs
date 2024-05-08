using System.ComponentModel.DataAnnotations;

namespace LABB4MVCRAZOR.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "The customer's name is mandatory.")]
        [MinLength(2, ErrorMessage = "The customer's name must be at least 2 character.")]
        [MaxLength(50, ErrorMessage = "The customer's name may be a maximum of 60 characters.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "The customer's email is mandatory.")]
        [EmailAddress(ErrorMessage = "The email address provided is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The customer's phone number is mandatory.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The phone number must be a 10-digit number.")]
        public string PhoneNumber { get; set; }

    }
}

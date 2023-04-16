using System.ComponentModel.DataAnnotations;

namespace FlightBookingSystemV2.ViewModels
{
    public class UserRegistrationVM
    {
        [Required]
        public int Name { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8)]
        [Compare("Password", ErrorMessage ="Password and Confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}

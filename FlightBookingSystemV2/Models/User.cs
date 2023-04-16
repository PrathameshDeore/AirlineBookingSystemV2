using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace FlightBookingSystemV2.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        //[Index(IsUnique = true)]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid Email Address.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address is Required")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}

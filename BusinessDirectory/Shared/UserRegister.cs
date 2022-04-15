using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.ViewModels
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string AadharNumber { get; set; }
        public Int32 AadharId { get; set; }
        public OTPValidate OTPValidate { get; set; }
    }
}

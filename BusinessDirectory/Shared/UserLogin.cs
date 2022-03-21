using System.ComponentModel.DataAnnotations;

namespace BusinessDirectory.ViewModels
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter an Email Address."), EmailAddress]
        public string Email { get; set; }
        public OTPValidate OTPValidate { get; set; }
    }
}

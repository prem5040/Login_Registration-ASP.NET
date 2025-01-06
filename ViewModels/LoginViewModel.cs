using System.ComponentModel.DataAnnotations;

namespace UserApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email is mandatory!!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email is mandatory!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}

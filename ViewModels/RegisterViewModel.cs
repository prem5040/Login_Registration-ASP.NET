using System.ComponentModel.DataAnnotations;

namespace UserApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(40,MinimumLength =8,ErrorMessage ="The {0} must be at {2} and at max {1} character")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword",ErrorMessage ="Password doesnot match.")]
        [Display(Name = "Enter Password")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Comfirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public required string ConfirmPassword {  get; set; }

    }
}

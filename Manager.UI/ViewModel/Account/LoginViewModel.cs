using System.ComponentModel.DataAnnotations;

namespace Manager.UI.ViewModel.Account
{
    public class LoginViewModel
    {

        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress]
        //public string Email { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Lembre-se de mim?")]
        public bool RememberMe { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DepartmentManagementSystem.ViewModel
{
    public class LoginVm
    {

        [Required(ErrorMessage = "Username is Required")]
        [NotNull]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Steepsales.Areas.Admin
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

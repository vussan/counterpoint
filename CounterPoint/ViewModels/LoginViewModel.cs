using System.ComponentModel.DataAnnotations;

namespace CounterPoint.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        //[Required]
        //public bool RememberMe { get; set; }
    }
}

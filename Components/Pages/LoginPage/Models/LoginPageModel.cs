using System.ComponentModel.DataAnnotations;

namespace VFXChallenge.Components.Pages.LoginPage.Models
{
    public class LoginPageModel
    {
        [Required]
        public string ClientId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password should have at least 5 characters.")]
        public string Password { get; set; }
    }
}

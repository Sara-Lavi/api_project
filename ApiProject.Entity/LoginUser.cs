using System.ComponentModel.DataAnnotations;

namespace ApiProject.Entities
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    public class UsersLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        
    }
}

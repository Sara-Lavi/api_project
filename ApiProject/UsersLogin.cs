using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    //A clearer name would be LoginUser (and the file would be LoginUser.cs)
    public class UsersLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        
    }
}

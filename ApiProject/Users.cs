using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    public class Users
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int UserId { get; set; }
    }
}

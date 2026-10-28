using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    //The class describes one user, so User is a clearer name than Users (and the file would be User.cs)
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

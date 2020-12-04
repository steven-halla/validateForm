using System.ComponentModel.DataAnnotations;

namespace validateForm.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        [Required]
        []
        public string Email { get; set; }
        public string password { get; set; }
    }
}
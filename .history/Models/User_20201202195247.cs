using System.ComponentModel.DataAnnotations;

namespace validateForm.Models
{
    public class User
    {
        [Required]
        []
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace validateForm.Models
{
    public class User
    {
        [Required(ErrorMesssage= "first name min length is 4")]
        [MinLength(4, ErrorMessage = "First name ")]
        public string Firstname{ get; set; }

        [Required]
        [MinLength(4)]
        public string Lastname{ get; set; }

        [Required]
        [Range(1,125)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }
    }
}
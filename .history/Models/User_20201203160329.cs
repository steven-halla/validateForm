using System.ComponentModel.DataAnnotations;

namespace validateForm.Models
{
    public class User
    {
        [Required(ErrorMesssage= "Please do not leave first name field empty")]
        [MinLength(4, ErrorMessage = "First name min length is 4")]
        public string Firstname{ get; set; }

        [Required(ErrorMessage=)]
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
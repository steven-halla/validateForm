using System.ComponentModel.DataAnnotations;

namespace validateForm.Models
{
    public class User
    {
        [Required(ErrorMesssage= "Please do not leave first name field empty")]
        [MinLength(4, ErrorMessage = "First name min length is 4")]
        public string Firstname{ get; set; }

        [Required(ErrorMessage="Please do not leave last name field empty")]
        [MinLength(4, ErrorMessage = "Last name min length is 4")]
        public string Lastname{ get; set; }

        [Required(ErrorMessage="Please do not leave age field empty")]
        [Range(1,125, ErrorMessage = "Please input an age that is valid 1-125")]
        public int Age { get; set; }

        [Required(ErrorMessage="Please do not leave email address empty")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }
    }
}
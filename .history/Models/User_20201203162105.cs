using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validateForm.Models
{
    public class User
    {
        [Required(ErrorResponse= "Please do not leave first name field empty")]
        [MinLength(4, ErrorResponse = "First name min length is 4")]
        public string Firstname{ get; set; }

        [Required(ErrorResponse="Please do not leave last name field empty")]
        [MinLength(4, ErrorResponse = "Last name min length is 4")]
        public string Lastname{ get; set; }

        [Required(ErrorResponse="Please do not leave age field empty")]
        [Range(1,125, ErrorResponse = "Please input an age that is valid 1-125")]
        public int Age { get; set; }

        [Required(ErrorResponse="Please do not leave email address empty")]
        [EmailAddress(ErrorResponse="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorResponse="Please do not leave password field empty")]
        [MinLength(3,ErrorResponse="Password must be at least 3 characters")]
        public string Password { get; set; }
    }
}
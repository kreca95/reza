using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reza.Models.User
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "First name is required"), MaxLength(50, ErrorMessage = "Max length is 50"), MinLength(2, ErrorMessage = "Min lengths is 2")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required"), MaxLength(50, ErrorMessage = "Max length is 50"), MinLength(2, ErrorMessage = "Min lengths is 2")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "First name is required"), MaxLength(50, ErrorMessage = "Max length is 50"), MinLength(2, ErrorMessage = "Min lengths is 2")]
        public string Password { get; set; }
    }
}

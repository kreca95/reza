using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reza.API.Models.Auth
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(50, MinimumLength = 8), Required]
        public string Password { get; set; }
    }
}

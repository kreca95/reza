using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reza.API.Models.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

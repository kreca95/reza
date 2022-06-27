using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reza.Models.Entities
{
    public class User : BaseDbResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ConfirmationKey { get; set; }
        public bool IsConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

    }
}

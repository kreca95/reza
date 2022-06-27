using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reza.Models.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime GameTime { get; set; }
        public int UserOrganizerId { get; set; }

    }
}

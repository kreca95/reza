using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reza.Models
{
    public class BaseDbResponse
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public int Result { get; set; }
    }
}

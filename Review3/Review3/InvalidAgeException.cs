using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class InvalidAgeException:Exception
    {
        public InvalidAgeException(string message) : base(message) { }
        
    }
}

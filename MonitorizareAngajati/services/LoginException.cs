using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.services
{
    class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {
        }
    }
}

using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.services
{
    public class UserValidator
    {
        public void validateRegister(User user, string password, string confPassword)
        {
            if (user.getName() == "")
            {
                user.setName(null);
            }

            if (user.getUsername() == "")
            {
                user.setUsername(null);
            }

            if (password == "")
            {
                throw new Exception("Parola nu poate fi vida!");
            }

            if (!password.Equals(confPassword))
            {
                throw new Exception("Parolele nu coincid!");
            }
        }
    }
}

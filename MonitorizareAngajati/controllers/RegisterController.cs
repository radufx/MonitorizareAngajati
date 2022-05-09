using MonitorizareAngajati.model;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.controllers
{
    public class RegisterController
    {
        RegisterForm registerForm;
        Services services;

        public RegisterController(Services services)
        {
            registerForm = new RegisterForm(this);
            registerForm.Show();
            this.services = services;
        }

        public void initiateRegister(string username, string name, string password, string confPassword)
        {
            User user = new User(username, name);

            try
            {
                services.register(user, password, confPassword);
                registerForm.displayMessage("Inregistrare efectuata cu succes!", isError: false);
                registerForm.Close();
            }
            catch (Exception ex)
            {
                registerForm.displayMessage(ex.Message);
            }
        }
    }
}

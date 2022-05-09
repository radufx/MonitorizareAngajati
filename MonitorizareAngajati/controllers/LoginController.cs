using MonitorizareAngajati.model;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati.controllers
{
    public class LoginController
    {
        LoginForm loginForm;
        Services services;

        public LoginController(Services services)
        {
            loginForm = new LoginForm(this);
            loginForm.Show();
            this.services = services;
        }

        public void initiateLogin()
        {
            string username = loginForm.getUsernameText();
            string password = loginForm.getPasswordText();
            Observer client;

            try
            {
                if (username == "admin") client = new AdministratorController(services);
                else client = new EmployeeController(services);
                User user = services.login(username, password, client);
                if (username != "admin")
                {
                    TimeForm timeForm = new TimeForm();
                    DialogResult dialogResult = timeForm.ShowDialog(loginForm);
                    services.logUser(user, timeForm.getTime());
                }
                client.setUser(user);
                client.displayForm();
                loginForm.Close();
            }
            catch (Exception ex)
            {
                loginForm.displayErrorMessage(ex.Message);
            }
        }

        public void displayRegisterForm()
        {
            RegisterController registerController = new RegisterController(services);
            loginForm.Close();
        }
    }
}

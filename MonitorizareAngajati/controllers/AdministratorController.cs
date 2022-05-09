using MonitorizareAngajati.model;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.controllers
{
    public class AdministratorController : AdministratorObserver
    {
        AdministratorForm administratorForm;
        Services services;
        User user;

        public AdministratorController(Services services)
        {
            this.services = services;
        }

        public void employeeListChanged()
        {
            var loggedUsers = services.getLoggedUsers().Select(item => new
            {
                Nume = item.Name,
                Öra = item.Time
            }).ToList();
            administratorForm.updateLoggedUsersList(loggedUsers);
        }

        public void taskListChanged()
        {
            throw new NotImplementedException();
        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public void displayForm()
        {
            administratorForm = new AdministratorForm(this);
            administratorForm.Show();
            employeeListChanged();
        }

        public void logout()
        {
            try
            {
                services.logout(user);
                administratorForm.Close();
            }
            catch (Exception ex)
            {
                administratorForm.displayMessage(ex.Message, "Eroare la log out");
            }
        }
    }
}

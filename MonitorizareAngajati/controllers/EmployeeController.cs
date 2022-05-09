using MonitorizareAngajati.model;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.controllers
{
    public class EmployeeController: EmployeeObserver
    {
        EmployeeForm employeeForm;
        Services services;
        User user;

        public EmployeeController(Services services)
        {
            this.services = services;
        }

        public void displayForm()
        {
            employeeForm = new EmployeeForm(this);
            employeeForm.Show();
        }

        public void taskListChanged()
        {
            throw new NotImplementedException();
        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public void logout()
        {
            try
            {
                services.logout(user);
                employeeForm.Close();
            }
            catch(Exception ex)
            {
                employeeForm.displayMessage(ex.Message, "Eroare la log out");
            }
        }
    }
}

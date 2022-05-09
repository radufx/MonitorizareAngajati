using MonitorizareAngajati.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.services
{
    public interface Observer
    {
        void taskListChanged();

        void setUser(User user);

        void displayForm();
    }
}

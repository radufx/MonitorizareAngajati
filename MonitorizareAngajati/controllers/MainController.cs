using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati.controllers
{
    public class MainController
    {
        MainWindow mainWindow;
        Services services;

        public MainController(Services services)
        {
            this.services = services;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow(this);
            Application.Run(mainWindow);
        }

        public void displayLoginForm()
        {
            LoginController loginController = new LoginController(services);
        }
    }
}

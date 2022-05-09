using MonitorizareAngajati.controllers;
using MonitorizareAngajati.persistence;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserRepository userRepository = new UserRepository();
            LogsRepository logsRepository = new LogsRepository();
            Services services = new Services(userRepository, logsRepository);
            MainController mainController = new MainController(services);
        }
    }
}

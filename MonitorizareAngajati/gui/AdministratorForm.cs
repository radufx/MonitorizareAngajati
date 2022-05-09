using MonitorizareAngajati.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati
{
    public partial class AdministratorForm : Form
    {
        private AdministratorController administratorController;
        public AdministratorForm(AdministratorController administratorController)
        {
            this.administratorController = administratorController;
            InitializeComponent();
        }

        public void updateLoggedUsersList<T>(List<T> loggedUsers)
        {
            loggedUsersGridView.DataSource = loggedUsers;
            noLoggedUsersLabel.Text = loggedUsers.Count().ToString();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            administratorController.logout();
        }

        public void displayMessage(string text, string errorTitle = null)
        {
            if (errorTitle != null)
            {
                MessageBox.Show(text, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text);
            }
        }
    }
}

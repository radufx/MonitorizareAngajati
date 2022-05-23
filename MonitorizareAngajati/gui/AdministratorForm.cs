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

        public void bindData(BindingSource bindingParent, BindingSource bindingChild)
        {
            loggedUsersGridView.DataSource = bindingParent;
            userTasksGridView.DataSource = bindingChild;
            userIDLabel.DataBindings.Add("Text", bindingParent, "id");
            taskIDLabel.DataBindings.Add("Text", bindingChild, "id");
            userIDLabel.Visible = false;
            taskIDLabel.Visible = false;
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            administratorController.displayAddTaskDialog();
        }

        public int getSelectedUserID()
        {
            return Int32.Parse(userIDLabel.Text);
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            administratorController.deleteTask(taskIDLabel.Text);
        }
    }
}

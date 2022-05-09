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
    public partial class EmployeeForm : Form
    {
        EmployeeController controller;
        public EmployeeForm(EmployeeController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        public void displayMessage(string text, string errorTitle=null)
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

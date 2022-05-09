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
    public partial class LoginForm : Form
    {
        LoginController loginController;
        public LoginForm(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginController.initiateLogin();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginController.displayRegisterForm();
        }

        public string getUsernameText()
        {
            return usernameTextBox.Text;
        }

        public string getPasswordText()
        {
            return passwordTextBox.Text;
        }

        public void displayErrorMessage(string message)
        {
            MessageBox.Show(message, "Conectare nereusita", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

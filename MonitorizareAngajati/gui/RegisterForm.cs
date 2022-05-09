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
    public partial class RegisterForm : Form
    {
        RegisterController registerController;
        public RegisterForm(RegisterController registerController)
        {
            this.registerController = registerController;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerController.initiateRegister(usernameTextBox.Text,
                                                nameTextBox.Text,
                                                passwordTextBox.Text,
                                                confirmPasswordTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void displayMessage(string text, bool isError = true)
        {
            if (isError)
            {
                MessageBox.Show(text, "Eroare la inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text);
            }
        }
    }
}

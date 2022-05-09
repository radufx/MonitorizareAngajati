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
    public partial class MainWindow : Form
    {
        MainController mainController;
        public MainWindow(MainController mainController)
        {
            this.mainController = mainController;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainController.displayLoginForm();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

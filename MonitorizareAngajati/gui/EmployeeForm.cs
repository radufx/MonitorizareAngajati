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
            statusAllButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            statusDoneButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            statusProgressButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            statusTodoButton.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
        }

        public void bindData(BindingSource bindingTasks)
        {
            tasksGridView.DataSource = bindingTasks;
            taskIDLabel.DataBindings.Add("Text", bindingTasks, "id");
            taskIDLabel.Visible = false;
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

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            controller.displayUpdateTaskDialog();
        }

        public string getSelectedTaskID()
        {
            return taskIDLabel.Text;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (statusTodoButton.Checked)
            {
                controller.filterTasks("De facut");
            }
            else if (statusDoneButton.Checked)
            {
                controller.filterTasks("Terminat");
            } 
            else if (statusProgressButton.Checked)
            {
                controller.filterTasks("In progres");
            }
            else
            {
                controller.filterTasks("all");
            }
        }
    }
}

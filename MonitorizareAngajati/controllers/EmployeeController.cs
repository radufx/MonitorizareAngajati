using MonitorizareAngajati.model;
using MonitorizareAngajati.persistence;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati.controllers
{
    public class EmployeeController: EmployeeObserver
    {
        EmployeeForm employeeForm;
        Services services;
        User user;

        DataSet dataSet = new DataSet();
        SQLiteDataAdapter taskAdapter = new SQLiteDataAdapter();
        BindingSource bindingTask = new BindingSource();

        public EmployeeController(Services services)
        {
            this.services = services;
        }

        private void fillDataSet()
        {
            SQLiteConnection con = DBUtils.CreateConnection();
            string selectCommand = String.Format("SELECT * FROM Tasks WHERE userID={0};", user.getKey());
            taskAdapter.SelectCommand = new SQLiteCommand(selectCommand, con);
            taskAdapter.Fill(dataSet, "Tasks");
            bindingTask.DataSource = dataSet.Tables["Tasks"];
        }

        public void displayForm()
        {
            employeeForm = new EmployeeForm(this);
            employeeForm.Show();
            fillDataSet();
            employeeForm.bindData(bindingTask);
        }

        public void taskListChanged()
        {
            SQLiteConnection con = DBUtils.CreateConnection();
            taskAdapter.SelectCommand.Connection = con;

            dataSet.Clear();
            taskAdapter.Fill(dataSet, "Tasks");
        }

        public void filterTasks(string status)
        {
            string selectCommand;
            if (status != "all")
            {
                selectCommand = String.Format("SELECT * FROM Tasks WHERE userID={0} and status='{1}';", user.getKey(), status);
            } 
            else
            {
                selectCommand = String.Format("SELECT * FROM Tasks WHERE userID={0};", user.getKey());
            }
            SQLiteConnection con = DBUtils.CreateConnection();
            taskAdapter.SelectCommand = new SQLiteCommand(selectCommand, con);
            dataSet.Clear();
            taskAdapter.Fill(dataSet, "Tasks");
        }

        public void setUser(User user)
        {
            this.user = user;
            this.fillDataSet();
        }

        public void logout()
        {
            try
            {
                services.logout(user);
                employeeForm.Close();
            }
            catch(Exception ex)
            {
                employeeForm.displayMessage(ex.Message, "Eroare la log out");
            }
        }

        public void displayUpdateTaskDialog()
        {
            UpdateTaskForm updateTaskForm = new UpdateTaskForm();
            DialogResult dialogResult = updateTaskForm.ShowDialog(employeeForm);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    string status = updateTaskForm.getStatus();
                    int id = Int32.Parse(employeeForm.getSelectedTaskID());
                    services.updateTask(id, status);
                    employeeForm.displayMessage("Sarcina actualizata cu succes.");
                }
                catch (Exception ex)
                {
                    employeeForm.displayMessage(ex.Message, "Sarcina nu a putut fi actualizata");
                }
            }
        }
    }
}

using MonitorizareAngajati.model;
using MonitorizareAngajati.persistence;
using MonitorizareAngajati.services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorizareAngajati.controllers
{
    public class AdministratorController : AdministratorObserver
    {
        AdministratorForm administratorForm;
        Services services;
        User user;
    
        string selectParent = ConfigurationSettings.AppSettings["selectParent"];
        string selectChild = ConfigurationSettings.AppSettings["selectChild"];

        DataSet dataSet = new DataSet();
        SQLiteDataAdapter parentAdapter = new SQLiteDataAdapter();
        SQLiteDataAdapter childAdapter = new SQLiteDataAdapter();
        BindingSource bindingParent = new BindingSource();
        BindingSource bindingChild = new BindingSource();

        public AdministratorController(Services services)
        {
            this.services = services;
            this.fillDataSet();
        }

        private void fillDataSet()
        {
            SQLiteConnection con = DBUtils.CreateConnection();
            parentAdapter.SelectCommand = new SQLiteCommand(selectParent, con);
            parentAdapter.Fill(dataSet, "Parinte");
            childAdapter.SelectCommand = new SQLiteCommand(selectChild, con);
            childAdapter.Fill(dataSet, "Fiu");

            DataColumn pkColumn = dataSet.Tables["Parinte"].Columns["id"];
            DataColumn fkColumn = dataSet.Tables["Fiu"].Columns["userID"];
            DataRelation relation = new DataRelation("fk_Parinte_Fiu", pkColumn, fkColumn);

            dataSet.Relations.Add(relation);
       
            bindingParent.DataSource = dataSet.Tables["Parinte"];
            bindingChild.DataSource = bindingParent;
            bindingChild.DataMember = "fk_Parinte_Fiu";
        }

        public void employeeListChanged()
        {
            SQLiteConnection con = DBUtils.CreateConnection();
            parentAdapter.SelectCommand.Connection = con;
            childAdapter.SelectCommand.Connection = con;

            dataSet.Clear();
            parentAdapter.Fill(dataSet, "Parinte");
            childAdapter.Fill(dataSet, "Fiu");
            //var loggedUsers = services.getLoggedUsers().Select(item => new
            //{
            //    Nume = item.Name,
            //    Öra = item.Time
            //}).ToList();
            //administratorForm.updateLoggedUsersList(loggedUsers);
        }

        public void taskListChanged()
        {
            SQLiteConnection con = DBUtils.CreateConnection();
            parentAdapter.SelectCommand.Connection = con;
            childAdapter.SelectCommand.Connection = con;

            dataSet.Clear();
            parentAdapter.Fill(dataSet, "Parinte");
            childAdapter.Fill(dataSet, "Fiu");
        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public void displayForm()
        {
            administratorForm = new AdministratorForm(this);
            administratorForm.Show();
            administratorForm.bindData(bindingParent, bindingChild);
            employeeListChanged();
        }

        public void displayAddTaskDialog()
        {
            AddTaskForm addTaskForm = new AddTaskForm(this);
            DialogResult dialogResult = addTaskForm.ShowDialog(administratorForm);

            if (dialogResult == DialogResult.OK)
            {
                string description = addTaskForm.getDescription();
                string status = addTaskForm.getStatus();

                try
                {
                    int userID = administratorForm.getSelectedUserID();
                    services.addTask(new model.Task(userID, status, description));
                    administratorForm.displayMessage("Sarcina adaugata cu succes.");
                }
                catch(Exception ex)
                {
                    administratorForm.displayMessage(ex.Message, "Sarcina nu a putut fi adaugata");
                }
            }
        }

        public void logout()
        {
            try
            {
                services.logout(user);
                administratorForm.Close();
            }
            catch (Exception ex)
            {
                administratorForm.displayMessage(ex.Message, "Eroare la log out");
            }
        }

        public void deleteTask(string taskID)
        {
            try
            {
                int id = Int32.Parse(taskID);
                services.removeTask(id);
                administratorForm.displayMessage("Sarcina stearsa cu succes.");
            }
            catch (Exception ex)
            {
                administratorForm.displayMessage(ex.Message, "Sarcina nu a putut fi stearsa");
            }
        }
    }
}

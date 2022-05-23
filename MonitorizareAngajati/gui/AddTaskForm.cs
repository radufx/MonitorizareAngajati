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
    public partial class AddTaskForm : Form
    {
        private AdministratorController controller;
        public AddTaskForm(AdministratorController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var dataSource = new List<Object>();
            dataSource.Add(new { Name = "De facut", Value = "De facut" });
            dataSource.Add(new { Name = "In progres", Value = "In progres" });
            dataSource.Add(new { Name = "Terminat", Value = "Terminat" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedItem = "De facut";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string getDescription()
        {
            return richTextBox1.Text;
        }

        public string getStatus()
        {
            return comboBox1.SelectedValue.ToString();
        }
    }
}

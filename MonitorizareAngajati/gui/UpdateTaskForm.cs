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
    public partial class UpdateTaskForm : Form
    {
        public UpdateTaskForm()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
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

        public string getStatus()
        {
            return comboBox1.SelectedValue.ToString();
        }
    }
}

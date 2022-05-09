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
    public partial class TimeForm : Form
    {
        public TimeForm()
        {
            InitializeComponent();
        }

        private void TimeForm_Load(object sender, EventArgs e)
        {
            timePicker.Value = DateTime.Now;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
        }

        public string getTime()
        {
            return timePicker.Value.ToString("HH:mm");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}

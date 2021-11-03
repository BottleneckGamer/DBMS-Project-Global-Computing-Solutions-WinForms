using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Computing_Solutions
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSchedule openaddscheduleform = new AddSchedule();
            openaddscheduleform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           UpdateSchedule openupscheduleform = new UpdateSchedule();
            openupscheduleform.Show();
        }
    }
}

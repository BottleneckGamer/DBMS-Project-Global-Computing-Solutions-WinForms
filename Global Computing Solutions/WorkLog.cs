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
    public partial class WorkLog : Form
    {
        public WorkLog()
        {
            InitializeComponent();
        }

        private void wlclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wlAddbtn_Click(object sender, EventArgs e)
        {
            addworklog openaddworklogform = new addworklog();
            openaddworklogform.Show();
        }

        private void wlUpbtn_Click(object sender, EventArgs e)
        {
            UpdateWorkLog openupworklogform = new UpdateWorkLog();
            openupworklogform.Show();
        }
    }
}

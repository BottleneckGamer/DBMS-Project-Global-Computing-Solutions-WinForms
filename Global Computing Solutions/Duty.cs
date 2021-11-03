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
    public partial class Duty : Form
    {
        public Duty()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDuty openadddutyform = new AddDuty();
            openadddutyform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDuty openupdutyform = new UpdateDuty();
            openupdutyform.Show();
        }
    }
}

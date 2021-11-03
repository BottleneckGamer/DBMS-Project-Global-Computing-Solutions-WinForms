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
    public partial class Certification : Form
    {
        public Certification()
        {
            InitializeComponent();
        }

        private void certAddbtn_Click(object sender, EventArgs e)
        {
            addcertification openaddcertform = new addcertification();
            openaddcertform.Show();
        }

        private void certUpbtn_Click(object sender, EventArgs e)
        {
            updatecertification openupcertform = new updatecertification();
            openupcertform.Show();
        }
    }
}

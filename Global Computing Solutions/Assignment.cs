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
    public partial class Assignment : Form
    {
        public Assignment()
        {
            InitializeComponent();
        }

        private void assclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assAddbtn_Click(object sender, EventArgs e)
        {
            addAssignment openaddassignform = new addAssignment();
            openaddassignform.Show();
        }

        private void adatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assigndatalbl_Click(object sender, EventArgs e)
        {

        }

        private void assdatapnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void assbtnspnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void assdelbtn_Click(object sender, EventArgs e)
        {

        }

        private void assUpbtn_Click(object sender, EventArgs e)
        {
            UpdateAssignment openupassignform = new UpdateAssignment();
            openupassignform.Show();
        }
    }
}

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
    public partial class TaskSkills : Form
    {
        public TaskSkills()
        {
            InitializeComponent();
        }

        private void tsAddbtn_Click(object sender, EventArgs e)
        {
            AddTaskSkills openaddtaskskillsform = new AddTaskSkills();
            openaddtaskskillsform.Show();
        }

        private void tsUpbtn_Click(object sender, EventArgs e)
        {
            UpdateTaskSkills openuptaskskillsform = new UpdateTaskSkills();
            openuptaskskillsform.Show();
        }
    }
}

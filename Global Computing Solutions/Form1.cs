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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customdesignwin();
        }

        private void customdesignwin()
        {
            submenu1pnl.Visible = false;
           
        }

        private void hidesubmenu()
        {
            if (submenu1pnl.Visible == true)
                submenu1pnl.Visible = false;
     

        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hidesubmenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void WorkMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(submenu1pnl);
        }




        private Form activeform = null;
        private void OpenSubForm(Form subform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            MainFormPnl.Controls.Add(subform);
            MainFormPnl.Tag = subform;
            subform.BringToFront();
            subform.Show();

        }

        private void EmpFormbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new EmployeeForm());
            //hidemenu
            hidesubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Region());
            //hidemenu
            hidesubmenu();
        }

        private void Certbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Certification());
            //hidemenu
            hidesubmenu();
        }

        private void Skillbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Skills());
            //hidemenu
            hidesubmenu();
        }

        private void Assignment_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Assignment());
            //hidemenu
            hidesubmenu();
        }

        private void WorkLogbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new WorkLog());
            //hidemenu
            hidesubmenu();
        }

        private void Billingbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new BillingNumber());
            //hidemenu
            hidesubmenu();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Customer());
            //hidemenu
            hidesubmenu();
        }

        private void taskskillbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new TaskSkills());
            //hidemenu
            hidesubmenu();
        }

        private void Projectbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Project());
            //hidemenu
            hidesubmenu();
        }

        private void schedbtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Schedule());
            //hidemenu
            hidesubmenu();
        }

        private void Dutybtn_Click(object sender, EventArgs e)
        {
            //show form
            OpenSubForm(new Duty());
            //hidemenu
            hidesubmenu();
        }
    }
}

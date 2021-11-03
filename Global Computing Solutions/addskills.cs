using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Computing_Solutions
{
    public partial class addskills : Form
    {
        public addskills()
        {
            InitializeComponent();
        }

        private void regskillbtn_Click(object sender, EventArgs e)
        {
            // try
            // {
            //     string connectionString;
            //     SqlConnection cnn;
            //     connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            //     // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            //     cnn = new SqlConnection(connectionString);
            //     cnn.Open();
            //
            //     SqlCommand command;
            //     SqlDataAdapter adapter = new SqlDataAdapter();
            //     String sql = "";
            //
            //     sql = "insert into Skill (Name, RateOfPay) values ('" + skillnametxbox.Text + "', '" + rateofpaytxtbox.Text + "') Set IDENTITY_INSERT Region OFF";
            //
            //     command = new SqlCommand(sql, cnn);
            //     adapter.InsertCommand = new SqlCommand(sql, cnn);
            //     adapter.InsertCommand.ExecuteNonQuery();
            //     MessageBox.Show("Added entry!");
            //     command.Dispose();
            //     cnn.Close();
            //     Skills openSkillsForm = new Skills();
            //     openSkillsForm.Show();
            //     this.Close();
            // }
            // catch (Exception exception)
            // {
            //     MessageBox.Show(exception.ToString());
            //     throw;
            // }
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            
            sql = "insert into Skill (Name, RateOfPay) values ('" + skillnametxbox.Text + "', '" + rateofpaytxtbox.Text + "') Set IDENTITY_INSERT Region OFF";
            
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Added entry!");
            command.Dispose();
            cnn.Close();
            Skills openSkillsForm = new Skills();
            openSkillsForm.Show();
            this.Close();
        }
    }
}

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
    public partial class addregion : Form
    {
        public addregion()
        {
            InitializeComponent();
        }

        private void regregionbtn_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "insert into Region (Name) values ('" + regnametxtbox.Text + "') Set IDENTITY_INSERT Region OFF";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Added entry!");
            command.Dispose();
            cnn.Close();
            Region openRegionform = new Region();
            openRegionform.Show();
            this.Close();
        }
    }
}

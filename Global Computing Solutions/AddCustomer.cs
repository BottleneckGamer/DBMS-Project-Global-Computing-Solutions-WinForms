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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void regCustButton_Click(object sender, EventArgs e)
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

            sql = "insert into Customer (Name, PhoneNumber, RegionId) values ('"+textBox2.Text+"', '"+textBox1.Text+"','"+regIdCmb.Text+"') Set IDENTITY_INSERT Customer OFF";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Added entry!");
            command.Dispose();
            cnn.Close();
            Customer openCustomerForm = new Customer();
            openCustomerForm.Show();
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.gCSDevDataSet.Region);
        }
    }
}

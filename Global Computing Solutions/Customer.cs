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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customeraddbtn_Click(object sender, EventArgs e)
        {
            AddCustomer openaddcustomerform = new AddCustomer();
            this.Close();
            openaddcustomerform.Show();
        }

        private void customerclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerupbtn_Click(object sender, EventArgs e)
        {
            var x = CustomerDataGrid.SelectedCells;
            MessageBox.Show("You have chosen to edit ID #" + x[0].Value.ToString() + "!");
            UpdateCustomer openUpdateCustomerForm = new UpdateCustomer(x[0].Value.ToString());
            this.Close();
            openUpdateCustomerForm.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.gCSDevDataSet.Customer);
        }

        private void customerdelbtn_Click(object sender, EventArgs e)
        {
            var x = CustomerDataGrid.SelectedCells[0].Value.ToString();
            MessageBox.Show(x);
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "DELETE Customer where CustomerId='"+x+"'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show("Item Deleted!");
            this.customerTableAdapter.Fill(this.gCSDevDataSet.Customer);
        }
    }
}

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
    public partial class BillingNumber : Form
    {
        public BillingNumber()
        {
            InitializeComponent();
        }

        private void billclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billAddbtn_Click(object sender, EventArgs e)
        {
            addbilling openaddbillingform = new addbilling();
            this.Close();
            openaddbillingform.Show();
        }

        private void billUpbtn_Click(object sender, EventArgs e)
        {
            var x = billdatagridview.SelectedCells;
            MessageBox.Show("You have chosen to edit ID #"+x[0].Value.ToString()+"!");
            UpdateBilling openUpdateBilling = new UpdateBilling(x[0].Value.ToString());
            this.Close();
            openUpdateBilling.Show();
        }

        private void BillingNumber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.gCSDevDataSet.Bill);

        }

        private void billdelbtn_Click(object sender, EventArgs e)
        {
            var x = billdatagridview.SelectedCells[0].Value.ToString();
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

            sql = "DELETE Bill where BillId='"+x+"'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show("Item Deleted!");
            this.billTableAdapter.Fill(this.gCSDevDataSet.Bill);
        }
    }
}

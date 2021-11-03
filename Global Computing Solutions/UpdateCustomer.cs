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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public UpdateCustomer(String x)
        {
            updateId = x;
            InitializeComponent();
        }
        private String updateId;

        public String UpdateId
        {
            get { return updateId; }
            set { updateId = value; }
        }

        private void button1_Click(object sender, EventArgs e)
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

            sql = "Update Customer set Name='"+textBox2.Text+"', PhoneNumber='"+textBox1.Text+ "', RegionId='" + comboBox1.Text + "'where CustomerId='"+updateId+"'";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            Customer openCustomerForm = new Customer();
            this.Close();
            openCustomerForm.Show();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.gCSDevDataSet.Region);
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";

            sql = "Select CustomerId,Name,PhoneNumber,RegionId from Customer where CustomerId='"+updateId+"'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                textBox2.Text = dataReader.GetValue(1).ToString();
                textBox1.Text = dataReader.GetValue(2).ToString();
                comboBox1.Text = dataReader.GetValue(3).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}

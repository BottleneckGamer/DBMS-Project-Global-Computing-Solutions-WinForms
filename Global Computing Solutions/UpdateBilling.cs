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
    public partial class UpdateBilling : Form
    {
        public UpdateBilling()
        {
            InitializeComponent();
        }
        public UpdateBilling(String x)
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

        private void regbillbtn_Click(object sender, EventArgs e)
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

            sql = "Update Bill set BillDate='" + billdatepicker.Value.ToShortDateString() + "', TotalAmount='" + totalamounttxtbox.Text + "'where BillId='" + updateId + "'";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            BillingNumber openBillingNumber = new BillingNumber();
            this.Close();
            openBillingNumber.Show();
        }

        private void UpdateBilling_Load(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "Data Source=MASTERUSER\\JUL;Initial Catalog=GCSDev;Persist Security Info=True;User ID=Test;Password=password";
            // connectionString = "Server=.\\JUL;Database=GCSDev;Trusted_Connection=true;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";

            sql = "Select BillId,BillDate,TotalAmount from Bill where BillId='" + updateId + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                billdatepicker.Value = Convert.ToDateTime(dataReader.GetValue(1));
                totalamounttxtbox.Text = dataReader.GetValue(2).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}

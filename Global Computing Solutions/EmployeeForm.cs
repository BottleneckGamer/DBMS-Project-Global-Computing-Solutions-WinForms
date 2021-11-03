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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddEmployee openaddempform = new AddEmployee();
            this.Close();
            openaddempform.Show();
        }

        private void eclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edelbtn_Click(object sender, EventArgs e)
        {
            var x = edatagridview.SelectedCells[0].Value.ToString();
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

            sql = "DELETE Employee where EmployeeId='" + x + "'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show("Item Deleted!");
            this.employeeTableAdapter.Fill(this.gCSDevDataSet.Employee);
        }

        private void EUpbtn_Click(object sender, EventArgs e)
        {
            var x = edatagridview.SelectedCells;
            MessageBox.Show("You have chosen to edit ID #" + x[0].Value.ToString() + "!");
            updateemployee openEmployeeForm = new updateemployee(x[0].Value.ToString());
            this.Close();
            openEmployeeForm.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gCSDevDataSet.Employee);

        }
    }
}

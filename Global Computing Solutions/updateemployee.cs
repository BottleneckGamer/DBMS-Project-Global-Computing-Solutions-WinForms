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
    public partial class updateemployee : Form
    {
        public updateemployee()
        {
            InitializeComponent();
        }
        public updateemployee(String x)
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

        private void updateemployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.gCSDevDataSet.Employee);
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

            sql = "Select EmployeeId,LastName,MiddleName,FirstName,DateOfHire,RegionId,ManagerId from Employee where EmployeeId='" + updateId + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                upefirstnametxtbox.Text = dataReader.GetValue(3).ToString();
                upmidnametxbox.Text = dataReader.GetValue(2).ToString();
                uplastnametxtbox.Text = dataReader.GetValue(1).ToString();
                updateofhirepicker.Value = Convert.ToDateTime(dataReader.GetValue(4));
                upregioncmbox.Text = dataReader.GetValue(5).ToString();
                upmanagercmbox.Text = dataReader.GetValue(6).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void addregionbtn_Click(object sender, EventArgs e)
        {
            addregion openaddregionform = new addregion();
            this.Close();
            openaddregionform.Show();
        }

        private void upregempbtn_Click(object sender, EventArgs e)
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

            sql = "Update Employee set FirstName='"+upefirstnametxtbox.Text + "', MiddleName='" + upmidnametxbox.Text + "', LastName='" + uplastnametxtbox.Text + "', DateOfHire='"+updateofhirepicker.Value.ToShortDateString()+ "', RegionId='"+upregioncmbox.Text+ "', ManagerId='"+upmanagercmbox.Text+"' where EmployeeId='" + updateId + "'";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            EmployeeForm openEmployeeForm = new EmployeeForm();
            this.Close();
            openEmployeeForm.Show();
        }
    }
}

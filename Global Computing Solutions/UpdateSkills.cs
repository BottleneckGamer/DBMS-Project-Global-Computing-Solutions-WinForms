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
    public partial class UpdateSkills : Form
    {
        public UpdateSkills()
        {
            InitializeComponent();
        }

        public UpdateSkills(String x)
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

        private void upregskillbtn_Click(object sender, EventArgs e)
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

            sql = "Update Skill set Name='"+upskillnametxbox.Text+ "', RateOfPay='"+uprateofpaytxtbox.Text + "'where SkillId='"+updateId+"'";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();


            Skills openSkills = new Skills();
            this.Close();
            openSkills.Show();
        }

        private void UpdateSkills_Load(object sender, EventArgs e)
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

            sql = "Select SkillId,Name,RateOfPay from Skill where SkillId='"+updateId+"'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                upskillnametxbox.Text = dataReader.GetValue(1).ToString();
                uprateofpaytxtbox.Text = dataReader.GetValue(2).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}

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
    public partial class updateregion : Form
    {
        public updateregion()
        {
            InitializeComponent();
        }

        public updateregion(String x)
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


        private void upregregionbtn_Click(object sender, EventArgs e)
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

            sql = "Update Region set Name='"+upregnametxtbox.Text+"' where RegionId='"+updateId+"'";
            
            command = new SqlCommand(sql,cnn);

            adapter.UpdateCommand = new SqlCommand(sql,cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            
            command.Dispose();
            cnn.Close();

            
            Region openRegion = new Region();
            this.Close();
            openRegion.Show();
        }

        private void updateregion_Load(object sender, EventArgs e)
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

            sql = "Select RegionId,Name from Region where RegionId='"+updateId+"'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                upregnametxtbox.Text = dataReader.GetValue(1).ToString();
            }
            
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}

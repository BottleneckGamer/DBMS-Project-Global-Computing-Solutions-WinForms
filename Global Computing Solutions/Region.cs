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
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
        }

        private void regAddbtn_Click(object sender, EventArgs e)
        {
            addregion openaddregionform = new addregion();
            this.Close();
            openaddregionform.Show();
        }

        private void rclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rUpbtn_Click(object sender, EventArgs e)
        {
            var x = regdatagridview.SelectedCells;
            MessageBox.Show("You have chosen to edit ID #"+x[0].Value.ToString()+"!");
            updateregion openupregionform = new updateregion(x[0].Value.ToString());
            this.Close();
            openupregionform.Show();
        }

        private void Region_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.gCSDevDataSet.Region);
        }
        

        private void regdelbtn_Click(object sender, EventArgs e)
        {
            var x = regdatagridview.SelectedCells[0].Value.ToString();
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

            sql = "DELETE Region where RegionId='" + x + "'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show("Item Deleted!");
            this.regionTableAdapter.Fill(this.gCSDevDataSet.Region);
        }
    }
}

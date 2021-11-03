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
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();
        }

        private void skillclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skillAddbtn_Click(object sender, EventArgs e)
        {
            addskills openaddskillform = new addskills();
            this.Close();
            openaddskillform.Show();
        }

        private void skillUpbtn_Click(object sender, EventArgs e)
        {
            var x = skilldatagridview.SelectedCells;
            MessageBox.Show("You have chosen to edit ID #" + x[0].Value.ToString() + "!");
            UpdateSkills openupskillform = new UpdateSkills(x[0].Value.ToString());
            this.Close();
            openupskillform.Show();
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCSDevDataSet.Skill' table. You can move, or remove it, as needed.
            this.skillTableAdapter.Fill(this.gCSDevDataSet.Skill);

        }

        private void skilldelbtn_Click(object sender, EventArgs e)
        {
            var x = skilldatagridview.SelectedCells[0].Value.ToString();
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

            sql = "DELETE Skill where SkillId='" + x + "'";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show("Item Deleted!");
            this.skillTableAdapter.Fill(this.gCSDevDataSet.Skill);
        }
    }
}

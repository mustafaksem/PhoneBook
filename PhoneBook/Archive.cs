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

namespace PhoneBook
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
        private void Archive_Load(object sender, EventArgs e)
        {
            GiveMeArchive();
        }
       
        private void GiveMeArchive()
        {
            SqlCommand cmd = new SqlCommand("Sp_GiveMePersons", DataConnection.dataConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IsItActive", 0);
            cmd.Parameters.AddWithValue("@AdminID", DataConnection.AdminID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgDeletedPersons.DataSource = dt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Sp_SearchContacts", DataConnection.dataConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchText", tbSearchedText.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgDeletedPersons.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GiveMeArchive();
        }
        private void dgDeletedPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgDeletedPersons.Rows[e.RowIndex];
                string personId = row.Cells["PersonID"].Value.ToString(); 
                SqlCommand cmd = new SqlCommand("Sp_BringBackPerson", DataConnection.dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", Convert.ToInt32(personId)); 
                DataConnection.dataConn.Open();
                cmd.ExecuteNonQuery();
                DataConnection.dataConn.Close();
                MessageBox.Show("\r\nContact successfully restored.");
            }
        }

    }
}

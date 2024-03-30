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
    public partial class AddNew_User : Form
    {
        int AdminID;
        public AddNew_User(int adminIDParam)
        {
            AdminID = adminIDParam;
            InitializeComponent();
        }


        private void AddNew_Admin_Load(object sender, EventArgs e)
        {
            if (AdminID != 0)
            {
                SqlCommand cmd3 = new SqlCommand("Sp_UpdteAdmin", DataConnection.dataConn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@AdminId", AdminID);
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtAdminName.Text = dt.Rows[0]["AdminName"].ToString();
                    txtAdminSurname.Text = dt.Rows[0]["AdminSurname"].ToString();
                    txtAdminEmail.Text = dt.Rows[0]["AdminEmail"].ToString();
                    txtAdminPassword.Text = dt.Rows[0]["AdminPassword"].ToString();
                    lblBaslikAdmin.Text = "Edit User";
                    btnAddNewAdmin.Text = "Save to Updated User";
                }
            }
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            if (AdminID == 0)
            {
                if (txtAdminPassword.Text == "")
                {
                    MessageBox.Show("Email field must be filled in ");
                }
                else if (txtAdminPassword.Text.Length < 5)
                {
                    MessageBox.Show("Password must be at least 5 characters long.");
                }
                else if (!txtAdminPassword.Text.Any(char.IsLetter) || !txtAdminPassword.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("The password must contain at least one letter and one number.");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Sp_AddNewAdmin", DataConnection.dataConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdminName", txtAdminName.Text);
                    cmd.Parameters.AddWithValue("@AdminSurname", txtAdminSurname.Text);
                    cmd.Parameters.AddWithValue("@AdminEmail", txtAdminEmail.Text);
                    cmd.Parameters.AddWithValue("@AdminPassword", txtAdminPassword.Text);
                    DataConnection.dataConn.Open();
                    cmd.ExecuteNonQuery();
                    DataConnection.dataConn.Close();
                    MessageBox.Show("The new Admin has been added successfully.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {

                SqlCommand cmd = new SqlCommand("Sp_EditAdmin", DataConnection.dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdminID", AdminID);
                cmd.Parameters.AddWithValue("@AdminName", txtAdminName.Text);
                cmd.Parameters.AddWithValue("@AdminSurname", txtAdminSurname.Text);
                cmd.Parameters.AddWithValue("@AdminEmail", txtAdminEmail.Text);
                cmd.Parameters.AddWithValue("@AdminPassword", txtAdminPassword.Text);
                DataConnection.dataConn.Open();
                cmd.ExecuteNonQuery();
                DataConnection.dataConn.Close();
                MessageBox.Show("The new Admin has been updated successfully.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

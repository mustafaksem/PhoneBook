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
    public partial class SelectForUpdate_User : Form
    {
        //int selectedAdminID;
        public SelectForUpdate_User()
        {
            InitializeComponent();
        }

        private void SelectForUpdate_User_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Sp_GiveMeAdmin", DataConnection.dataConn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbUpdateUser.DataSource = dt;
            cbUpdateUser.DisplayMember = "AdminNameSurname";
            cbUpdateUser.ValueMember = "AdminID";
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
            }
            else if (!txtAdminPassword.Text.Any(char.IsLetter) || !txtAdminPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("The password must contain at least one letter and one number.");
            }
            else
            {
                SqlConnection dataConn = new SqlConnection("Data Source=DESKTOP-LQOAMHU\\SQLEXPRESS;Initial Catalog=PhoneBook;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Sp_PhoneBookAdminLogin", dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AdminID", SqlDbType.NVarChar).Value = cbUpdateUser.SelectedValue;
                cmd.Parameters.Add("@AdminPassword", SqlDbType.NVarChar).Value = txtAdminPassword.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    AddNew_User addNewAdminForm = new AddNew_User(Convert.ToInt32(cbUpdateUser.SelectedValue));
                    this.Hide();
                    addNewAdminForm.FormClosed += (s, args) => this.Show();
                    addNewAdminForm.Show();
                }
                else
                {
                    MessageBox.Show("No records found or matches.");
                }
               
                
            }
        }
    }
}

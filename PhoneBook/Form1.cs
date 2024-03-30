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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Email field must be filled in ");
            }
            else if (tbPassword.Text.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long.");
            }
            else if (!tbPassword.Text.Any(char.IsLetter) || !tbPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("The password must contain at least one letter and one number.");
            }
            else
            {
                SqlConnection dataConn = new SqlConnection("Data Source=DESKTOP-LQOAMHU\\SQLEXPRESS;Initial Catalog=PhoneBook;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Sp_PhoneBookLogin", dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AdminEmail", SqlDbType.NVarChar).Value = tbEmail.Text;
                cmd.Parameters.Add("@AdminPassword", SqlDbType.NVarChar).Value = tbPassword.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int AdminID = Convert.ToInt32(dt.Rows[0]["AdminID"]);
                    DataConnection.AdminID = AdminID;
                    YellowPages yellowPagesForm = new YellowPages();
                    this.Hide();
                    yellowPagesForm.FormClosed += (s, args) => this.Show();
                    yellowPagesForm.Show();
                   
                }
                else
                {
                    MessageBox.Show("Record not found or does not match.");
                }
            }
        }
    }
}

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
    public partial class AddNewPerson : Form
    {
        int PersonID;
        public AddNewPerson(int personIDParam)
        {
            InitializeComponent();
            PersonID = personIDParam;
        }
        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            if(PersonID != 0)
            {
                SqlCommand cmd2 = new SqlCommand("Sp_UpdtePerson", DataConnection.dataConn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@PersonID", PersonID);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if(dt2.Rows.Count > 0)
                {
                    txtName.Text = dt2.Rows[0]["Name"].ToString();
                    txtSurname.Text = dt2.Rows[0]["Surname"].ToString();
                    txtEmail.Text = dt2.Rows[0]["EMail"].ToString();
                    txtPhone.Text = dt2.Rows[0]["Phone"].ToString();
                    txtAddress.Text = dt2.Rows[0]["Address"].ToString();
                    dpBirthday.Value = Convert.ToDateTime(dt2.Rows[0]["BirthDay"]);
                    btnAddNewPerson.Text = "Update Person";
                    lblBaslik.Text = "Edit Person";
                }

            }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            if (PersonID == 0)
            {
                SqlCommand cmd = new SqlCommand("Sp_AddNewPerson", DataConnection.dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@EMail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@BirthDay", dpBirthday.Value);
                cmd.Parameters.AddWithValue("@AdminID", DataConnection.AdminID);
                DataConnection.dataConn.Open();
                cmd.ExecuteNonQuery();
                DataConnection.dataConn.Close();
                MessageBox.Show("The new person has been added successfully.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Sp_EditPerson", DataConnection.dataConn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@PersonID", PersonID);
                cmd2.Parameters.AddWithValue("@Name", txtName.Text);
                cmd2.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd2.Parameters.AddWithValue("@EMail", txtEmail.Text);
                cmd2.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd2.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd2.Parameters.AddWithValue("@BirthDay", dpBirthday.Value);
                DataConnection.dataConn.Open();
                cmd2.ExecuteNonQuery();
                DataConnection.dataConn.Close();
                MessageBox.Show("The  person has been updated successfully.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

       
    }
}

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
using ZXing;
using ZXing.QrCode;

namespace PhoneBook
{
    public partial class YellowPages : Form
    {
        public YellowPages()
        {
            InitializeComponent();
            
        }

        private void YellowPages_Load(object sender, EventArgs e)
        {
            GiveMePhoneBook();
            pictureBox1.Visible = false;
            btnImageClose.Visible = false;
        }
        private void GiveMePhoneBook()
        {
            SqlCommand cmd = new SqlCommand("Sp_GiveMePersons", DataConnection.dataConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IsItActive", 1);
            cmd.Parameters.AddWithValue("@AdminID", DataConnection.AdminID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgYellowPages.DataSource = dt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Sp_SearchContacts", DataConnection.dataConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchText", tbSearchedText.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgYellowPages.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GiveMePhoneBook();
        }
        public void dgYellowPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Seçilen satırdaki verileri al
                DataGridViewRow row = this.dgYellowPages.Rows[e.RowIndex];
                string personId = row.Cells["PersonID"].Value.ToString(); // ID kolonunun adını düzeltin
                SqlCommand cmd = new SqlCommand("Sp_DeletePerson", DataConnection.dataConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", Convert.ToInt32(personId)); // personId'yi int'e dönüştür ve parametreye ekle
                DataConnection.dataConn.Open();
                cmd.ExecuteNonQuery();
                DataConnection.dataConn.Close();
                MessageBox.Show("Contact successfully deleted.");
            }
            else if (e.ColumnIndex == 1)
            {
                AddNewPerson editPersonForm = new AddNewPerson(Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value));
                this.Hide();
                editPersonForm.FormClosed += (s, args) => this.Show();
                editPersonForm.Show();
            }
        }
        private void vCARDCODEQRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Seçilen satırdaki vCard bilgilerini al
            DataGridViewRow row = dgYellowPages.CurrentRow;
            string name = row.Cells["Name"].Value.ToString();
            string surname = row.Cells["Surname"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();

            // vCard oluştur
            StringBuilder vCard = new StringBuilder();
            vCard.AppendLine("BEGIN:VCARD");
            vCard.AppendLine("VERSION:3.0");
            vCard.AppendLine("FN:" + name + " " + surname);
            vCard.AppendLine("TEL;TYPE=CELL:" + phone);
            vCard.AppendLine("EMAIL;TYPE=INTERNET:" + email);
            vCard.AppendLine("END:VCARD");

            // QR kod oluştur
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            Bitmap qrCodeBitmap = writer.Write(vCard.ToString());

            pictureBox1.Visible = true;
            btnImageClose.Visible = true;

            // Oluşturulan QR kodunu kullanıcıya göster
            pictureBox1.Image = qrCodeBitmap;
        }

        private void nEWPERSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddNewPerson addNewPersonForm = new AddNewPerson(0);
            this.Hide();
            addNewPersonForm.FormClosed += (s, args) => this.Show();
            addNewPersonForm.Show();
        }
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Archive archiveForm = new Archive();
            this.Hide();
            archiveForm.FormClosed += (s, args) => this.Show();
            archiveForm.Show();
        }
        private void btnImageClose_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btnImageClose.Visible = false;
        }

        private void newAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddNew_User addNewAdminForm = new AddNew_User(0);
            this.Hide();
            addNewAdminForm.FormClosed += (s, args) => this.Show();
            addNewAdminForm.Show();
        }

        private void editAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SelectForUpdate_User selectForm= new SelectForUpdate_User();
            this.Hide();
            selectForm.FormClosed += (s, args) => this.Show();
            selectForm.Show();
        }

    }
}

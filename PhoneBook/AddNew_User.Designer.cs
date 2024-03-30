namespace PhoneBook
{
    partial class AddNew_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslikAdmin = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslikAdmin
            // 
            this.lblBaslikAdmin.AutoSize = true;
            this.lblBaslikAdmin.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslikAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblBaslikAdmin.Location = new System.Drawing.Point(87, 42);
            this.lblBaslikAdmin.Name = "lblBaslikAdmin";
            this.lblBaslikAdmin.Size = new System.Drawing.Size(262, 40);
            this.lblBaslikAdmin.TabIndex = 19;
            this.lblBaslikAdmin.Text = "Add New Admin";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(142, 230);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(275, 22);
            this.txtAdminEmail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Admin Email :";
            // 
            // txtAdminSurname
            // 
            this.txtAdminSurname.Location = new System.Drawing.Point(142, 181);
            this.txtAdminSurname.Name = "txtAdminSurname";
            this.txtAdminSurname.Size = new System.Drawing.Size(275, 22);
            this.txtAdminSurname.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Admin Surname :";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(142, 134);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(275, 22);
            this.txtAdminName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Name :";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(142, 288);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(275, 22);
            this.txtAdminPassword.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Admin Password :";
            // 
            // btnAddNewAdmin
            // 
            this.btnAddNewAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewAdmin.Location = new System.Drawing.Point(142, 344);
            this.btnAddNewAdmin.Name = "btnAddNewAdmin";
            this.btnAddNewAdmin.Size = new System.Drawing.Size(133, 59);
            this.btnAddNewAdmin.TabIndex = 22;
            this.btnAddNewAdmin.Text = " Save to New Admin";
            this.btnAddNewAdmin.UseVisualStyleBackColor = true;
            this.btnAddNewAdmin.Click += new System.EventHandler(this.btnAddNewAdmin_Click);
            // 
            // AddNew_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 489);
            this.Controls.Add(this.btnAddNewAdmin);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBaslikAdmin);
            this.Controls.Add(this.txtAdminEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdminSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNew_User";
            this.Text = "AddNew_Admin";
            this.Load += new System.EventHandler(this.AddNew_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslikAdmin;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewAdmin;
    }
}
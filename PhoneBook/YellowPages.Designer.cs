namespace PhoneBook
{
    partial class YellowPages
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
            this.dgYellowPages = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nEWPERSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEPERSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCARDCODEQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.btnImageClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgYellowPages)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgYellowPages
            // 
            this.dgYellowPages.AllowUserToAddRows = false;
            this.dgYellowPages.AllowUserToDeleteRows = false;
            this.dgYellowPages.BackgroundColor = System.Drawing.Color.Beige;
            this.dgYellowPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYellowPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgYellowPages.Location = new System.Drawing.Point(1, 151);
            this.dgYellowPages.Name = "dgYellowPages";
            this.dgYellowPages.ReadOnly = true;
            this.dgYellowPages.RowHeadersWidth = 51;
            this.dgYellowPages.RowTemplate.Height = 24;
            this.dgYellowPages.Size = new System.Drawing.Size(1278, 395);
            this.dgYellowPages.TabIndex = 0;
            this.dgYellowPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgYellowPages_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete Person";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edit Person";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Edit";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-4, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "YELLOW PAGES";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(416, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 43);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(0, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1278, 36);
            this.button3.TabIndex = 5;
            this.button3.TabStop = false;
            this.button3.Text = "Person List";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWPERSONToolStripMenuItem,
            this.dELETEPERSONToolStripMenuItem,
            this.vCARDCODEQRCodeToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nEWPERSONToolStripMenuItem
            // 
            this.nEWPERSONToolStripMenuItem.Name = "nEWPERSONToolStripMenuItem";
            this.nEWPERSONToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.nEWPERSONToolStripMenuItem.Text = "NEW PERSON";
            this.nEWPERSONToolStripMenuItem.Click += new System.EventHandler(this.nEWPERSONToolStripMenuItem_Click);
            // 
            // dELETEPERSONToolStripMenuItem
            // 
            this.dELETEPERSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem});
            this.dELETEPERSONToolStripMenuItem.Name = "dELETEPERSONToolStripMenuItem";
            this.dELETEPERSONToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.dELETEPERSONToolStripMenuItem.Text = "DELETED PERSONS";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // vCARDCODEQRCodeToolStripMenuItem
            // 
            this.vCARDCODEQRCodeToolStripMenuItem.Name = "vCARDCODEQRCodeToolStripMenuItem";
            this.vCARDCODEQRCodeToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.vCARDCODEQRCodeToolStripMenuItem.Text = "V-CARD (QR Code)";
            this.vCARDCODEQRCodeToolStripMenuItem.Click += new System.EventHandler(this.vCARDCODEQRCodeToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdminToolStripMenuItem,
            this.editAdminToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingToolStripMenuItem.Text = "Settings";
            // 
            // newAdminToolStripMenuItem
            // 
            this.newAdminToolStripMenuItem.Name = "newAdminToolStripMenuItem";
            this.newAdminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newAdminToolStripMenuItem.Text = "New User";
            this.newAdminToolStripMenuItem.Click += new System.EventHandler(this.newAdminToolStripMenuItem_Click);
            // 
            // editAdminToolStripMenuItem
            // 
            this.editAdminToolStripMenuItem.Name = "editAdminToolStripMenuItem";
            this.editAdminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editAdminToolStripMenuItem.Text = "Edit User";
            this.editAdminToolStripMenuItem.Click += new System.EventHandler(this.editAdminToolStripMenuItem_Click);
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSearchedText.Location = new System.Drawing.Point(12, 86);
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(379, 22);
            this.tbSearchedText.TabIndex = 7;
            this.tbSearchedText.Text = "Enter text to search...";
            // 
            // btnImageClose
            // 
            this.btnImageClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImageClose.BackgroundImage = global::PhoneBook.Properties.Resources.x_png_42458;
            this.btnImageClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageClose.Location = new System.Drawing.Point(346, 151);
            this.btnImageClose.Name = "btnImageClose";
            this.btnImageClose.Size = new System.Drawing.Size(31, 26);
            this.btnImageClose.TabIndex = 10;
            this.btnImageClose.UseVisualStyleBackColor = false;
            this.btnImageClose.Click += new System.EventHandler(this.btnImageClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::PhoneBook.Properties.Resources.pngwing_com;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(511, 86);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 42);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // YellowPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.btnImageClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearchedText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgYellowPages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YellowPages";
            this.Text = "YellowPages";
            this.Load += new System.EventHandler(this.YellowPages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgYellowPages)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgYellowPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nEWPERSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEPERSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCARDCODEQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImageClose;
        private System.Windows.Forms.ToolStripMenuItem newAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAdminToolStripMenuItem;
    }
}
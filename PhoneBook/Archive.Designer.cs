namespace PhoneBook
{
    partial class Archive
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgDeletedPersons = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeletedPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::PhoneBook.Properties.Resources.pngwing_com;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(526, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 42);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSearchedText.Location = new System.Drawing.Point(27, 42);
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(379, 22);
            this.tbSearchedText.TabIndex = 10;
            this.tbSearchedText.Text = "Enter text to search...";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(431, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 43);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgDeletedPersons
            // 
            this.dgDeletedPersons.AllowUserToAddRows = false;
            this.dgDeletedPersons.AllowUserToDeleteRows = false;
            this.dgDeletedPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeletedPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dgDeletedPersons.Location = new System.Drawing.Point(3, 90);
            this.dgDeletedPersons.Name = "dgDeletedPersons";
            this.dgDeletedPersons.ReadOnly = true;
            this.dgDeletedPersons.RowHeadersWidth = 51;
            this.dgDeletedPersons.RowTemplate.Height = 24;
            this.dgDeletedPersons.Size = new System.Drawing.Size(1176, 384);
            this.dgDeletedPersons.TabIndex = 12;
            this.dgDeletedPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDeletedPersons_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Add Back";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Add";
            this.Column3.UseColumnTextForButtonValue = true;
            this.Column3.Width = 125;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 493);
            this.Controls.Add(this.dgDeletedPersons);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearchedText);
            this.Controls.Add(this.btnFind);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDeletedPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgDeletedPersons;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}
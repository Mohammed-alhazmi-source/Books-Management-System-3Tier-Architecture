namespace BMS.Authors
{
    partial class frmListAuthors
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAuthors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewAuthor = new System.Windows.Forms.Button();
            this.ShowPersonDetailsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAuthorDetailsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewAuthorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAuthorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAuthorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBooksHistoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.cmsAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(292, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management Authors";
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.AllowUserToOrderColumns = true;
            this.dgvAuthors.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.PersonID,
            this.NationalNo,
            this.FullName,
            this.Nationality,
            this.Gender});
            this.dgvAuthors.ContextMenuStrip = this.cmsAuthors;
            this.dgvAuthors.Location = new System.Drawing.Point(12, 237);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.Size = new System.Drawing.Size(899, 294);
            this.dgvAuthors.TabIndex = 2;
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "Author ID";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No.";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 300;
            // 
            // Nationality
            // 
            this.Nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nationality.DataPropertyName = "Nationality";
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            this.Nationality.Width = 150;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // cmsAuthors
            // 
            this.cmsAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetailsItem,
            this.ShowAuthorDetailsItem,
            this.ShowBooksHistoryItem,
            this.toolStripSeparator1,
            this.AddNewAuthorItem,
            this.EditAuthorItem,
            this.DeleteAuthorItem,
            this.toolStripSeparator2});
            this.cmsAuthors.Name = "cmsAuthors";
            this.cmsAuthors.Size = new System.Drawing.Size(236, 244);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Author ID",
            "Person ID",
            "National No.",
            "Full Name",
            "Nationality",
            "Gender"});
            this.cbFilterBy.Location = new System.Drawing.Point(86, 204);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(209, 27);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(301, 204);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(243, 27);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(14, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(108, 540);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 9;
            this.lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(791, 540);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewAuthor
            // 
            this.btnAddNewAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAuthor.Image = global::BMS.Properties.Resources.Add_Person_40;
            this.btnAddNewAuthor.Location = new System.Drawing.Point(836, 175);
            this.btnAddNewAuthor.Name = "btnAddNewAuthor";
            this.btnAddNewAuthor.Size = new System.Drawing.Size(75, 56);
            this.btnAddNewAuthor.TabIndex = 6;
            this.btnAddNewAuthor.UseVisualStyleBackColor = true;
            this.btnAddNewAuthor.Click += new System.EventHandler(this.btnAddNewAuthor_Click);
            // 
            // ShowPersonDetailsItem
            // 
            this.ShowPersonDetailsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowPersonDetailsItem.Image = global::BMS.Properties.Resources.PersonDetails_32;
            this.ShowPersonDetailsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonDetailsItem.Name = "ShowPersonDetailsItem";
            this.ShowPersonDetailsItem.Size = new System.Drawing.Size(235, 38);
            this.ShowPersonDetailsItem.Text = "Show Person Details";
            this.ShowPersonDetailsItem.Click += new System.EventHandler(this.ShowPersonDetailsItem_Click);
            // 
            // ShowAuthorDetailsItem
            // 
            this.ShowAuthorDetailsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowAuthorDetailsItem.Image = global::BMS.Properties.Resources.Man_32;
            this.ShowAuthorDetailsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowAuthorDetailsItem.Name = "ShowAuthorDetailsItem";
            this.ShowAuthorDetailsItem.Size = new System.Drawing.Size(235, 38);
            this.ShowAuthorDetailsItem.Text = "Show Author Details";
            this.ShowAuthorDetailsItem.Click += new System.EventHandler(this.ShowAuthorDetailsItem_Click);
            // 
            // AddNewAuthorItem
            // 
            this.AddNewAuthorItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddNewAuthorItem.Image = global::BMS.Properties.Resources.AddPerson_32;
            this.AddNewAuthorItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewAuthorItem.Name = "AddNewAuthorItem";
            this.AddNewAuthorItem.Size = new System.Drawing.Size(235, 38);
            this.AddNewAuthorItem.Text = "Add New Author";
            this.AddNewAuthorItem.Click += new System.EventHandler(this.AddNewAuthorItem_Click);
            // 
            // EditAuthorItem
            // 
            this.EditAuthorItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EditAuthorItem.Image = global::BMS.Properties.Resources.edit_32;
            this.EditAuthorItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditAuthorItem.Name = "EditAuthorItem";
            this.EditAuthorItem.Size = new System.Drawing.Size(235, 38);
            this.EditAuthorItem.Text = "Edit";
            this.EditAuthorItem.Click += new System.EventHandler(this.EditAuthorItem_Click);
            // 
            // DeleteAuthorItem
            // 
            this.DeleteAuthorItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteAuthorItem.Image = global::BMS.Properties.Resources.Delete_32;
            this.DeleteAuthorItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteAuthorItem.Name = "DeleteAuthorItem";
            this.DeleteAuthorItem.Size = new System.Drawing.Size(235, 38);
            this.DeleteAuthorItem.Text = "Delete";
            this.DeleteAuthorItem.Click += new System.EventHandler(this.DeleteAuthorItem_Click);
            // 
            // ShowBooksHistoryItem
            // 
            this.ShowBooksHistoryItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBooksHistoryItem.Image = global::BMS.Properties.Resources.icons8_bookss_32;
            this.ShowBooksHistoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowBooksHistoryItem.Name = "ShowBooksHistoryItem";
            this.ShowBooksHistoryItem.Size = new System.Drawing.Size(235, 38);
            this.ShowBooksHistoryItem.Text = "Show Books History";
            this.ShowBooksHistoryItem.Click += new System.EventHandler(this.ShowBooksHistoryItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.Drivers_64;
            this.pictureBox1.Location = new System.Drawing.Point(386, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmListAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 584);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewAuthor);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListAuthors";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Authors";
            this.Load += new System.EventHandler(this.frmListAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.cmsAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddNewAuthor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip cmsAuthors;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetailsItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAuthorDetailsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNewAuthorItem;
        private System.Windows.Forms.ToolStripMenuItem EditAuthorItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAuthorItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowBooksHistoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    }
}
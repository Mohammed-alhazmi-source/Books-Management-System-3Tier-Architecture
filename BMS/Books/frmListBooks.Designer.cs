namespace BMS.Books
{
    partial class frmListBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowBookDetialsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBookCopiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBookAuthorsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCopiesToBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddAuthorsToBookItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.cmsBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(371, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management Books";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.AuthorName,
            this.Title,
            this.ISBN,
            this.CategoryName,
            this.PublisherDate,
            this.NationalNo});
            this.dgvBooks.ContextMenuStrip = this.cmsBooks;
            this.dgvBooks.Location = new System.Drawing.Point(12, 260);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(1031, 313);
            this.dgvBooks.TabIndex = 3;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "Book ID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 75;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 200;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 180;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 120;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 150;
            // 
            // PublisherDate
            // 
            this.PublisherDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PublisherDate.DataPropertyName = "PublisherDate";
            this.PublisherDate.HeaderText = "Publisher Date";
            this.PublisherDate.Name = "PublisherDate";
            this.PublisherDate.ReadOnly = true;
            this.PublisherDate.Width = 150;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No.";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // cmsBooks
            // 
            this.cmsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowBookDetialsItem,
            this.ShowBookCopiesItem,
            this.ShowBookAuthorsItem,
            this.toolStripSeparator1,
            this.AddNewBookItem,
            this.AddCopiesToBookItem,
            this.EditBookItem,
            this.DeleteBookItem,
            this.toolStripSeparator2,
            this.AddAuthorsToBookItem});
            this.cmsBooks.Name = "cmsBooks";
            this.cmsBooks.Size = new System.Drawing.Size(230, 246);
            // 
            // ShowBookDetialsItem
            // 
            this.ShowBookDetialsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBookDetialsItem.Name = "ShowBookDetialsItem";
            this.ShowBookDetialsItem.Size = new System.Drawing.Size(229, 26);
            this.ShowBookDetialsItem.Text = "Show Book Detials";
            this.ShowBookDetialsItem.Click += new System.EventHandler(this.ShowBookDetialsItem_Click);
            // 
            // ShowBookCopiesItem
            // 
            this.ShowBookCopiesItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBookCopiesItem.Name = "ShowBookCopiesItem";
            this.ShowBookCopiesItem.Size = new System.Drawing.Size(229, 26);
            this.ShowBookCopiesItem.Text = "Show Book Copies";
            this.ShowBookCopiesItem.Click += new System.EventHandler(this.ShowBookCopiesItem_Click);
            // 
            // ShowBookAuthorsItem
            // 
            this.ShowBookAuthorsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBookAuthorsItem.Name = "ShowBookAuthorsItem";
            this.ShowBookAuthorsItem.Size = new System.Drawing.Size(229, 26);
            this.ShowBookAuthorsItem.Text = "Show Authors History";
            this.ShowBookAuthorsItem.Click += new System.EventHandler(this.ShowBookAuthorsItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // AddNewBookItem
            // 
            this.AddNewBookItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddNewBookItem.Name = "AddNewBookItem";
            this.AddNewBookItem.Size = new System.Drawing.Size(229, 26);
            this.AddNewBookItem.Text = "Add New Book";
            this.AddNewBookItem.Click += new System.EventHandler(this.AddNewBookItem_Click);
            // 
            // AddCopiesToBookItem
            // 
            this.AddCopiesToBookItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddCopiesToBookItem.Name = "AddCopiesToBookItem";
            this.AddCopiesToBookItem.Size = new System.Drawing.Size(229, 26);
            this.AddCopiesToBookItem.Text = "Add Copies To Book";
            this.AddCopiesToBookItem.Click += new System.EventHandler(this.AddCopiesToBookItem_Click);
            // 
            // EditBookItem
            // 
            this.EditBookItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EditBookItem.Name = "EditBookItem";
            this.EditBookItem.Size = new System.Drawing.Size(229, 26);
            this.EditBookItem.Text = "Edit";
            this.EditBookItem.Click += new System.EventHandler(this.EditBookItem_Click);
            // 
            // DeleteBookItem
            // 
            this.DeleteBookItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteBookItem.Name = "DeleteBookItem";
            this.DeleteBookItem.Size = new System.Drawing.Size(229, 26);
            this.DeleteBookItem.Text = "Delete";
            this.DeleteBookItem.Click += new System.EventHandler(this.DeleteBookItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // AddAuthorsToBookItem
            // 
            this.AddAuthorsToBookItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddAuthorsToBookItem.Name = "AddAuthorsToBookItem";
            this.AddAuthorsToBookItem.Size = new System.Drawing.Size(229, 26);
            this.AddAuthorsToBookItem.Text = "Add Authors To Book";
            this.AddAuthorsToBookItem.Click += new System.EventHandler(this.AddAuthorsToBookItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(23, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Book ID",
            "Title",
            "ISBN",
            "Category Name",
            "National No.",
            "Author Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(95, 223);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(213, 27);
            this.cbFilterBy.TabIndex = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(315, 223);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(237, 27);
            this.txtFilterValue.TabIndex = 6;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(23, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(117, 576);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 9;
            this.lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(905, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 44);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.books_96px;
            this.pictureBox1.Location = new System.Drawing.Point(431, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Image = global::BMS.Properties.Resources.add_32;
            this.btnAddNewBook.Location = new System.Drawing.Point(975, 197);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(68, 53);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // frmListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 632);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmListBooks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Books";
            this.Load += new System.EventHandler(this.frmListBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.cmsBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip cmsBooks;
        private System.Windows.Forms.ToolStripMenuItem ShowBookDetialsItem;
        private System.Windows.Forms.ToolStripMenuItem ShowBookAuthorsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNewBookItem;
        private System.Windows.Forms.ToolStripMenuItem EditBookItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteBookItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AddAuthorsToBookItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.ToolStripMenuItem AddCopiesToBookItem;
        private System.Windows.Forms.ToolStripMenuItem ShowBookCopiesItem;
    }
}
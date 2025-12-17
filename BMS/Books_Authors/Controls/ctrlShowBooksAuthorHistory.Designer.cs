namespace BMS.Books_Authors.Controls
{
    partial class ctrlShowBooksAuthorHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowBookDetialsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBookCopiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.cmsBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecordsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvBooks);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books History";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.ISBN,
            this.PublisherDate,
            this.CategoryName});
            this.dgvBooks.ContextMenuStrip = this.cmsBooks;
            this.dgvBooks.Location = new System.Drawing.Point(23, 27);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(973, 198);
            this.dgvBooks.TabIndex = 0;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "Book ID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Book Name";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 150;
            // 
            // PublisherDate
            // 
            this.PublisherDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PublisherDate.DataPropertyName = "PublisherDate";
            this.PublisherDate.HeaderText = "Publiser";
            this.PublisherDate.Name = "PublisherDate";
            this.PublisherDate.ReadOnly = true;
            this.PublisherDate.Width = 180;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 290;
            // 
            // cmsBooks
            // 
            this.cmsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowBookDetialsItem,
            this.ShowBookCopiesItem});
            this.cmsBooks.Name = "cmsBooks";
            this.cmsBooks.Size = new System.Drawing.Size(207, 56);
            // 
            // ShowBookDetialsItem
            // 
            this.ShowBookDetialsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBookDetialsItem.Name = "ShowBookDetialsItem";
            this.ShowBookDetialsItem.Size = new System.Drawing.Size(206, 26);
            this.ShowBookDetialsItem.Text = "Show Book Detials";
            this.ShowBookDetialsItem.Click += new System.EventHandler(this.ShowBookDetialsItem_Click);
            // 
            // ShowBookCopiesItem
            // 
            this.ShowBookCopiesItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBookCopiesItem.Name = "ShowBookCopiesItem";
            this.ShowBookCopiesItem.Size = new System.Drawing.Size(206, 26);
            this.ShowBookCopiesItem.Text = "Show Book Copies";
            this.ShowBookCopiesItem.Click += new System.EventHandler(this.ShowBookCopiesItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(123, 232);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 19);
            this.lblRecordsCount.TabIndex = 2;
            this.lblRecordsCount.Text = "0";
            // 
            // ctrlShowBooksAuthorHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlShowBooksAuthorHistory";
            this.Size = new System.Drawing.Size(1070, 326);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.cmsBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.ContextMenuStrip cmsBooks;
        private System.Windows.Forms.ToolStripMenuItem ShowBookDetialsItem;
        private System.Windows.Forms.ToolStripMenuItem ShowBookCopiesItem;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
    }
}

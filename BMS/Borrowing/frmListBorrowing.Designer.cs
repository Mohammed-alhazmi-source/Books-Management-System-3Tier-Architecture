namespace BMS.Borrowing
{
    partial class frmListBorrowing
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
            this.dgvBorrowing = new System.Windows.Forms.DataGridView();
            this.BorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsBorrowing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowBorrowInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseBorrowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterByActive = new System.Windows.Forms.ComboBox();
            this.btnAddNewBorrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowing)).BeginInit();
            this.cmsBorrowing.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(419, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Borrowing";
            // 
            // dgvBorrowing
            // 
            this.dgvBorrowing.AllowUserToAddRows = false;
            this.dgvBorrowing.AllowUserToDeleteRows = false;
            this.dgvBorrowing.AllowUserToOrderColumns = true;
            this.dgvBorrowing.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowID,
            this.BookID,
            this.BookName,
            this.BookCopyID,
            this.BorrowedName,
            this.BorrowingDate,
            this.DueDate,
            this.ActualReturnDate,
            this.IsActive});
            this.dgvBorrowing.ContextMenuStrip = this.cmsBorrowing;
            this.dgvBorrowing.Location = new System.Drawing.Point(12, 157);
            this.dgvBorrowing.Name = "dgvBorrowing";
            this.dgvBorrowing.ReadOnly = true;
            this.dgvBorrowing.Size = new System.Drawing.Size(1188, 386);
            this.dgvBorrowing.TabIndex = 1;
            // 
            // BorrowID
            // 
            this.BorrowID.DataPropertyName = "BorrowID";
            this.BorrowID.HeaderText = "Borrow ID";
            this.BorrowID.Name = "BorrowID";
            this.BorrowID.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "Book ID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookCopyID
            // 
            this.BookCopyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookCopyID.DataPropertyName = "BookCopyID";
            this.BookCopyID.HeaderText = "BC.ID";
            this.BookCopyID.Name = "BookCopyID";
            this.BookCopyID.ReadOnly = true;
            this.BookCopyID.Width = 80;
            // 
            // BorrowedName
            // 
            this.BorrowedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BorrowedName.DataPropertyName = "BorrowedName";
            this.BorrowedName.HeaderText = "Full Name";
            this.BorrowedName.Name = "BorrowedName";
            this.BorrowedName.ReadOnly = true;
            this.BorrowedName.Width = 200;
            // 
            // BorrowingDate
            // 
            this.BorrowingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BorrowingDate.DataPropertyName = "BorrowingDate";
            this.BorrowingDate.HeaderText = "Borrowing Date";
            this.BorrowingDate.Name = "BorrowingDate";
            this.BorrowingDate.ReadOnly = true;
            this.BorrowingDate.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 150;
            // 
            // ActualReturnDate
            // 
            this.ActualReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ActualReturnDate.DataPropertyName = "ActualReturnDate";
            this.ActualReturnDate.HeaderText = "Actual Return Date";
            this.ActualReturnDate.Name = "ActualReturnDate";
            this.ActualReturnDate.ReadOnly = true;
            this.ActualReturnDate.Width = 140;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // cmsBorrowing
            // 
            this.cmsBorrowing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowBorrowInfoItem,
            this.toolStripSeparator1,
            this.ReleaseBorrowItem});
            this.cmsBorrowing.Name = "cmsBorrowing";
            this.cmsBorrowing.Size = new System.Drawing.Size(203, 62);
            this.cmsBorrowing.Opening += new System.ComponentModel.CancelEventHandler(this.cmsBorrowing_Opening);
            // 
            // ShowBorrowInfoItem
            // 
            this.ShowBorrowInfoItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowBorrowInfoItem.Name = "ShowBorrowInfoItem";
            this.ShowBorrowInfoItem.Size = new System.Drawing.Size(202, 26);
            this.ShowBorrowInfoItem.Text = "Show Borrow Info";
            this.ShowBorrowInfoItem.Click += new System.EventHandler(this.ShowBorrowInfoItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // ReleaseBorrowItem
            // 
            this.ReleaseBorrowItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReleaseBorrowItem.Name = "ReleaseBorrowItem";
            this.ReleaseBorrowItem.Size = new System.Drawing.Size(202, 26);
            this.ReleaseBorrowItem.Text = "Release Borrow";
            this.ReleaseBorrowItem.Click += new System.EventHandler(this.ReleaseBorrowItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Borrow ID",
            "Book ID",
            "Book Copy ID",
            "Full Name",
            "Book Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(91, 122);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 27);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFilterValue.Location = new System.Drawing.Point(308, 122);
            this.txtFilterValue.MaxLength = 100;
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 26);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterByActive
            // 
            this.cbFilterByActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFilterByActive.FormattingEnabled = true;
            this.cbFilterByActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbFilterByActive.Location = new System.Drawing.Point(308, 121);
            this.cbFilterByActive.Name = "cbFilterByActive";
            this.cbFilterByActive.Size = new System.Drawing.Size(98, 27);
            this.cbFilterByActive.TabIndex = 5;
            this.cbFilterByActive.Visible = false;
            this.cbFilterByActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterByActive_SelectedIndexChanged);
            // 
            // btnAddNewBorrow
            // 
            this.btnAddNewBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBorrow.Image = global::BMS.Properties.Resources.borrow_book_32px;
            this.btnAddNewBorrow.Location = new System.Drawing.Point(1116, 99);
            this.btnAddNewBorrow.Name = "btnAddNewBorrow";
            this.btnAddNewBorrow.Size = new System.Drawing.Size(84, 49);
            this.btnAddNewBorrow.TabIndex = 6;
            this.btnAddNewBorrow.UseVisualStyleBackColor = true;
            this.btnAddNewBorrow.Click += new System.EventHandler(this.btnAddNewBorrow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(17, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(111, 551);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1019, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmListBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1212, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewBorrow);
            this.Controls.Add(this.cbFilterByActive);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBorrowing);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmListBorrowing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Borrowing";
            this.Load += new System.EventHandler(this.frmListBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowing)).EndInit();
            this.cmsBorrowing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrowing;
        private System.Windows.Forms.ContextMenuStrip cmsBorrowing;
        private System.Windows.Forms.ToolStripMenuItem ShowBorrowInfoItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ReleaseBorrowItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterByActive;
        private System.Windows.Forms.Button btnAddNewBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCopyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualReturnDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}
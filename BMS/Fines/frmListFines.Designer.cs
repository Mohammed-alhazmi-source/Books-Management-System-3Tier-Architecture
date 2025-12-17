namespace BMS.Fines
{
    partial class frmListFines
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
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.FineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsFines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowFineInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddFine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.cmsFines.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(399, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Fines";
            // 
            // dgvFines
            // 
            this.dgvFines.AllowUserToAddRows = false;
            this.dgvFines.AllowUserToDeleteRows = false;
            this.dgvFines.AllowUserToOrderColumns = true;
            this.dgvFines.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FineID,
            this.PersonID,
            this.BorrowID,
            this.FullName,
            this.BookName,
            this.BookCopyID,
            this.FineAmount});
            this.dgvFines.ContextMenuStrip = this.cmsFines;
            this.dgvFines.Location = new System.Drawing.Point(12, 212);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.ReadOnly = true;
            this.dgvFines.Size = new System.Drawing.Size(1077, 339);
            this.dgvFines.TabIndex = 1;
            // 
            // FineID
            // 
            this.FineID.DataPropertyName = "FineID";
            this.FineID.HeaderText = "Fine ID";
            this.FineID.Name = "FineID";
            this.FineID.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // BorrowID
            // 
            this.BorrowID.DataPropertyName = "BorrowID";
            this.BorrowID.HeaderText = "Borrow ID";
            this.BorrowID.Name = "BorrowID";
            this.BorrowID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 280;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 160;
            // 
            // BookCopyID
            // 
            this.BookCopyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookCopyID.DataPropertyName = "BookCopyID";
            this.BookCopyID.HeaderText = "Book Copy ID";
            this.BookCopyID.Name = "BookCopyID";
            this.BookCopyID.ReadOnly = true;
            this.BookCopyID.Width = 150;
            // 
            // FineAmount
            // 
            this.FineAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FineAmount.DataPropertyName = "FineAmount";
            this.FineAmount.HeaderText = "Fine Amount";
            this.FineAmount.Name = "FineAmount";
            this.FineAmount.ReadOnly = true;
            this.FineAmount.Width = 140;
            // 
            // cmsFines
            // 
            this.cmsFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowFineInfoItem});
            this.cmsFines.Name = "cmsFines";
            this.cmsFines.Size = new System.Drawing.Size(208, 36);
            // 
            // ShowFineInfoItem
            // 
            this.ShowFineInfoItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ShowFineInfoItem.Name = "ShowFineInfoItem";
            this.ShowFineInfoItem.Size = new System.Drawing.Size(207, 32);
            this.ShowFineInfoItem.Text = "Show Fine Info";
            this.ShowFineInfoItem.Click += new System.EventHandler(this.ShowFineInfoItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
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
            "Fine ID",
            "Person ID",
            "Borrow ID",
            "Full Name",
            "Book Name",
            "Book Copy ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(102, 176);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(245, 27);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFilterValue.Location = new System.Drawing.Point(354, 176);
            this.txtFilterValue.MaxLength = 70;
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(292, 27);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(24, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblRecordsCount.Location = new System.Drawing.Point(121, 554);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 22);
            this.lblRecordsCount.TabIndex = 6;
            this.lblRecordsCount.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(932, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddFine
            // 
            this.btnAddFine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFine.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAddFine.Image = global::BMS.Properties.Resources.Release_Detained_License_32;
            this.btnAddFine.Location = new System.Drawing.Point(1008, 154);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(81, 49);
            this.btnAddFine.TabIndex = 8;
            this.btnAddFine.UseVisualStyleBackColor = true;
            this.btnAddFine.Click += new System.EventHandler(this.btnAddFine_Click);
            // 
            // frmListFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1101, 610);
            this.Controls.Add(this.btnAddFine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmListFines";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Fines";
            this.Load += new System.EventHandler(this.frmListFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.cmsFines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCopyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsFines;
        private System.Windows.Forms.ToolStripMenuItem ShowFineInfoItem;
        private System.Windows.Forms.Button btnAddFine;
    }
}
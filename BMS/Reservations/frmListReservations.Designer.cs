namespace BMS.Reservations
{
    partial class frmListReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.cmsReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowReserveInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReleaseReserveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterByActive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnAddReserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReserveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseReserveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.cmsReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(386, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Reservations";
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToOrderColumns = true;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.PersonID,
            this.FullName,
            this.BookName,
            this.BookCopyID,
            this.ReserveDate,
            this.ReleaseReserveDate,
            this.ReservationStatus});
            this.dgvReservations.ContextMenuStrip = this.cmsReservations;
            this.dgvReservations.Location = new System.Drawing.Point(12, 209);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(1155, 358);
            this.dgvReservations.TabIndex = 1;
            // 
            // cmsReservations
            // 
            this.cmsReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowReserveInfoItem,
            this.toolStripSeparator1,
            this.ReleaseReserveItem});
            this.cmsReservations.Name = "cmsReservations";
            this.cmsReservations.Size = new System.Drawing.Size(238, 74);
            this.cmsReservations.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReservations_Opening);
            // 
            // ShowReserveInfoItem
            // 
            this.ShowReserveInfoItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ShowReserveInfoItem.Name = "ShowReserveInfoItem";
            this.ShowReserveInfoItem.Size = new System.Drawing.Size(237, 32);
            this.ShowReserveInfoItem.Text = "Show Reserve Info";
            this.ShowReserveInfoItem.Click += new System.EventHandler(this.ShowReserveInfoItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // ReleaseReserveItem
            // 
            this.ReleaseReserveItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ReleaseReserveItem.Name = "ReleaseReserveItem";
            this.ReleaseReserveItem.Size = new System.Drawing.Size(237, 32);
            this.ReleaseReserveItem.Text = "Release Reserve";
            this.ReleaseReserveItem.Click += new System.EventHandler(this.ReleaseReserveItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(29, 170);
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
            "Reserve ID",
            "Full Name",
            "Book Name",
            "Book Copy ID",
            "Is Reserved"});
            this.cbFilterBy.Location = new System.Drawing.Point(107, 167);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(214, 27);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFilterValue.Location = new System.Drawing.Point(328, 167);
            this.txtFilterValue.MaxLength = 40;
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(231, 27);
            this.txtFilterValue.TabIndex = 5;
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
            this.cbFilterByActive.Location = new System.Drawing.Point(328, 167);
            this.cbFilterByActive.Name = "cbFilterByActive";
            this.cbFilterByActive.Size = new System.Drawing.Size(90, 27);
            this.cbFilterByActive.TabIndex = 6;
            this.cbFilterByActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterByActive_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(29, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(123, 570);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 9;
            this.lblRecordsCount.Text = "??";
            // 
            // btnAddReserve
            // 
            this.btnAddReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReserve.Image = global::BMS.Properties.Resources.reservation_32px;
            this.btnAddReserve.Location = new System.Drawing.Point(1090, 137);
            this.btnAddReserve.Name = "btnAddReserve";
            this.btnAddReserve.Size = new System.Drawing.Size(77, 57);
            this.btnAddReserve.TabIndex = 7;
            this.btnAddReserve.UseVisualStyleBackColor = true;
            this.btnAddReserve.Click += new System.EventHandler(this.btnAddReserve_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(992, 575);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ReservationID
            // 
            this.ReservationID.DataPropertyName = "ReservationID";
            this.ReservationID.HeaderText = "Reserve ID";
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 220;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 130;
            // 
            // BookCopyID
            // 
            this.BookCopyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookCopyID.DataPropertyName = "BookCopyID";
            this.BookCopyID.HeaderText = "Book Copy ID";
            this.BookCopyID.Name = "BookCopyID";
            this.BookCopyID.ReadOnly = true;
            this.BookCopyID.Width = 120;
            // 
            // ReserveDate
            // 
            this.ReserveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReserveDate.DataPropertyName = "ReservationDate";
            this.ReserveDate.HeaderText = "Reserve Date";
            this.ReserveDate.Name = "ReserveDate";
            this.ReserveDate.ReadOnly = true;
            this.ReserveDate.Width = 130;
            // 
            // ReleaseReserveDate
            // 
            this.ReleaseReserveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReleaseReserveDate.DataPropertyName = "ReleaseReservationDate";
            this.ReleaseReserveDate.HeaderText = "Release Reserve Date";
            this.ReleaseReserveDate.Name = "ReleaseReserveDate";
            this.ReleaseReserveDate.ReadOnly = true;
            this.ReleaseReserveDate.Width = 180;
            // 
            // ReservationStatus
            // 
            this.ReservationStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReservationStatus.DataPropertyName = "ReservationStatus";
            this.ReservationStatus.HeaderText = "Is Reserved";
            this.ReservationStatus.Name = "ReservationStatus";
            this.ReservationStatus.ReadOnly = true;
            this.ReservationStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ReservationStatus.Width = 120;
            // 
            // frmListReservations
            // 
            this.AcceptButton = this.btnAddReserve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1187, 622);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddReserve);
            this.Controls.Add(this.cbFilterByActive);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmListReservations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Reservations";
            this.Load += new System.EventHandler(this.frmListReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.cmsReservations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.ContextMenuStrip cmsReservations;
        private System.Windows.Forms.ToolStripMenuItem ShowReserveInfoItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ReleaseReserveItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterByActive;
        private System.Windows.Forms.Button btnAddReserve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCopyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReserveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseReserveDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReservationStatus;
    }
}
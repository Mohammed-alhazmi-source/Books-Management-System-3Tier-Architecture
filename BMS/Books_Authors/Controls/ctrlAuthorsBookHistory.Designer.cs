namespace BMS.Books_Authors.Controls
{
    partial class ctrlAuthorsBookHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAuthorsHistory = new System.Windows.Forms.DataGridView();
            this.cmsAuthors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowAuthorDetialsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowPersonDetialsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorsHistory)).BeginInit();
            this.cmsAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecordsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvAuthorsHistory);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authors History";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(122, 275);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(20, 22);
            this.lblRecordsCount.TabIndex = 2;
            this.lblRecordsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records:";
            // 
            // dgvAuthorsHistory
            // 
            this.dgvAuthorsHistory.AllowUserToAddRows = false;
            this.dgvAuthorsHistory.AllowUserToDeleteRows = false;
            this.dgvAuthorsHistory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthorsHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthorsHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorsHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.AuthorID,
            this.AuthorName,
            this.NationalNo,
            this.Gender,
            this.Nationality,
            this.DateOfBirht});
            this.dgvAuthorsHistory.ContextMenuStrip = this.cmsAuthors;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthorsHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthorsHistory.Location = new System.Drawing.Point(18, 38);
            this.dgvAuthorsHistory.Name = "dgvAuthorsHistory";
            this.dgvAuthorsHistory.ReadOnly = true;
            this.dgvAuthorsHistory.Size = new System.Drawing.Size(1127, 225);
            this.dgvAuthorsHistory.TabIndex = 0;
            // 
            // cmsAuthors
            // 
            this.cmsAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetialsItem,
            this.ShowAuthorDetialsItem});
            this.cmsAuthors.Name = "cmsAuthors";
            this.cmsAuthors.Size = new System.Drawing.Size(220, 78);
            // 
            // ShowAuthorDetialsItem
            // 
            this.ShowAuthorDetialsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowAuthorDetialsItem.Name = "ShowAuthorDetialsItem";
            this.ShowAuthorDetialsItem.Size = new System.Drawing.Size(219, 26);
            this.ShowAuthorDetialsItem.Text = "Show Author Detials";
            this.ShowAuthorDetialsItem.Click += new System.EventHandler(this.ShowAuthorDetialsItem_Click);
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "Author ID";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Width = 115;
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Author Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            this.AuthorName.Width = 270;
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No.";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            this.NationalNo.Width = 140;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
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
            // DateOfBirht
            // 
            this.DateOfBirht.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateOfBirht.DataPropertyName = "DateOfBirth";
            this.DateOfBirht.HeaderText = "Date Of Birth";
            this.DateOfBirht.Name = "DateOfBirht";
            this.DateOfBirht.ReadOnly = true;
            this.DateOfBirht.Width = 190;
            // 
            // ShowPersonDetialsItem
            // 
            this.ShowPersonDetialsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowPersonDetialsItem.Name = "ShowPersonDetialsItem";
            this.ShowPersonDetialsItem.Size = new System.Drawing.Size(219, 26);
            this.ShowPersonDetialsItem.Text = "Show Person Detials";
            this.ShowPersonDetialsItem.Click += new System.EventHandler(this.ShowPersonDetialsItem_Click);
            // 
            // ctrlAuthorsBookHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlAuthorsBookHistory";
            this.Size = new System.Drawing.Size(1216, 346);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorsHistory)).EndInit();
            this.cmsAuthors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAuthorsHistory;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAuthors;
        private System.Windows.Forms.ToolStripMenuItem ShowAuthorDetialsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirht;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetialsItem;
    }
}

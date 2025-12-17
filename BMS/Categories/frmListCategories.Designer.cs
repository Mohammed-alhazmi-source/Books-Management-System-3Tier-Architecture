namespace BMS.Categories
{
    partial class frmListCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterByActive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.cmsCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowCategoryDetailsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.cmsCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(210, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Categories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToOrderColumns = true;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.IsActive});
            this.dgvCategories.ContextMenuStrip = this.cmsCategories;
            this.dgvCategories.Location = new System.Drawing.Point(20, 229);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.Size = new System.Drawing.Size(761, 296);
            this.dgvCategories.TabIndex = 2;
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Width = 120;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 470;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(27, 197);
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
            "Category ID",
            "Category Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(105, 194);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(188, 27);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtFilterValue.Location = new System.Drawing.Point(300, 194);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(238, 27);
            this.txtFilterValue.TabIndex = 5;
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
            this.cbFilterByActive.Location = new System.Drawing.Point(299, 194);
            this.cbFilterByActive.Name = "cbFilterByActive";
            this.cbFilterByActive.Size = new System.Drawing.Size(109, 27);
            this.cbFilterByActive.TabIndex = 6;
            this.cbFilterByActive.Visible = false;
            this.cbFilterByActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterByActive_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(27, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(121, 528);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(25, 19);
            this.lblRecordsCount.TabIndex = 10;
            this.lblRecordsCount.Text = "??";
            // 
            // cmsCategories
            // 
            this.cmsCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowCategoryDetailsItem,
            this.toolStripSeparator1,
            this.AddNewCategoryItem,
            this.EditCategoryItem,
            this.DeleteCategoryItem});
            this.cmsCategories.Name = "cmsCategories";
            this.cmsCategories.Size = new System.Drawing.Size(251, 162);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(647, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCategory.Image = global::BMS.Properties.Resources.add_64px;
            this.btnAddNewCategory.Location = new System.Drawing.Point(706, 161);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(75, 62);
            this.btnAddNewCategory.TabIndex = 7;
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.categorize_64;
            this.pictureBox1.Location = new System.Drawing.Point(320, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ShowCategoryDetailsItem
            // 
            this.ShowCategoryDetailsItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowCategoryDetailsItem.Image = global::BMS.Properties.Resources.details_pane_32px;
            this.ShowCategoryDetailsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowCategoryDetailsItem.Name = "ShowCategoryDetailsItem";
            this.ShowCategoryDetailsItem.Size = new System.Drawing.Size(250, 38);
            this.ShowCategoryDetailsItem.Text = "Show Category Details";
            this.ShowCategoryDetailsItem.Click += new System.EventHandler(this.ShowCategoryDetailsItem_Click);
            // 
            // AddNewCategoryItem
            // 
            this.AddNewCategoryItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddNewCategoryItem.Image = global::BMS.Properties.Resources.add_32;
            this.AddNewCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewCategoryItem.Name = "AddNewCategoryItem";
            this.AddNewCategoryItem.Size = new System.Drawing.Size(250, 38);
            this.AddNewCategoryItem.Text = "Add New Category";
            this.AddNewCategoryItem.Click += new System.EventHandler(this.AddNewCategoryItem_Click);
            // 
            // EditCategoryItem
            // 
            this.EditCategoryItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EditCategoryItem.Image = global::BMS.Properties.Resources.edit_32;
            this.EditCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditCategoryItem.Name = "EditCategoryItem";
            this.EditCategoryItem.Size = new System.Drawing.Size(250, 38);
            this.EditCategoryItem.Text = "Edit";
            this.EditCategoryItem.Click += new System.EventHandler(this.EditCategoryItem_Click);
            // 
            // DeleteCategoryItem
            // 
            this.DeleteCategoryItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeleteCategoryItem.Image = global::BMS.Properties.Resources.Delete_32;
            this.DeleteCategoryItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteCategoryItem.Name = "DeleteCategoryItem";
            this.DeleteCategoryItem.Size = new System.Drawing.Size(250, 38);
            this.DeleteCategoryItem.Text = "Delete";
            this.DeleteCategoryItem.Click += new System.EventHandler(this.DeleteCategoryItem_Click);
            // 
            // frmListCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.cbFilterByActive);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListCategories";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Categories";
            this.Load += new System.EventHandler(this.frmListCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.cmsCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterByActive;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip cmsCategories;
        private System.Windows.Forms.ToolStripMenuItem ShowCategoryDetailsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNewCategoryItem;
        private System.Windows.Forms.ToolStripMenuItem EditCategoryItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryItem;
    }
}
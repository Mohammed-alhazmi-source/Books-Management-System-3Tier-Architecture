namespace BMS.Books
{
    partial class frmAddUpdateBook
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcBook = new System.Windows.Forms.TabControl();
            this.tpAuthorInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.llAddCategory = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookCopiesCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudBookCopies = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdditionalDetials = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPublisherDate = new System.Windows.Forms.DateTimePicker();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcBook.SuspendLayout();
            this.tpAuthorInfo.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCopies)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(223, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcBook
            // 
            this.tcBook.Controls.Add(this.tpAuthorInfo);
            this.tcBook.Controls.Add(this.tpBookInfo);
            this.tcBook.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tcBook.Location = new System.Drawing.Point(12, 59);
            this.tcBook.Name = "tcBook";
            this.tcBook.SelectedIndex = 0;
            this.tcBook.Size = new System.Drawing.Size(1025, 509);
            this.tcBook.TabIndex = 1;
            // 
            // tpAuthorInfo
            // 
            this.tpAuthorInfo.BackColor = System.Drawing.Color.White;
            this.tpAuthorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAuthorInfo.Controls.Add(this.btnNextTab);
            this.tpAuthorInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpAuthorInfo.Location = new System.Drawing.Point(4, 30);
            this.tpAuthorInfo.Name = "tpAuthorInfo";
            this.tpAuthorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthorInfo.Size = new System.Drawing.Size(1017, 475);
            this.tpAuthorInfo.TabIndex = 0;
            this.tpAuthorInfo.Text = "Author Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(795, 434);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(161, 33);
            this.btnNextTab.TabIndex = 1;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(28, 5);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(958, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnSelectedPerson);
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.BackColor = System.Drawing.Color.White;
            this.tpBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBookInfo.Controls.Add(this.llAddCategory);
            this.tpBookInfo.Controls.Add(this.panel3);
            this.tpBookInfo.Controls.Add(this.panel2);
            this.tpBookInfo.Controls.Add(this.panel1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 30);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(1017, 475);
            this.tpBookInfo.TabIndex = 1;
            this.tpBookInfo.Text = "Book Info";
            // 
            // llAddCategory
            // 
            this.llAddCategory.AutoSize = true;
            this.llAddCategory.Location = new System.Drawing.Point(759, 45);
            this.llAddCategory.Name = "llAddCategory";
            this.llAddCategory.Size = new System.Drawing.Size(117, 22);
            this.llAddCategory.TabIndex = 15;
            this.llAddCategory.TabStop = true;
            this.llAddCategory.Text = "Add Category";
            this.llAddCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddCategory_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRemoveImage);
            this.panel3.Controls.Add(this.btnChooseImage);
            this.panel3.Controls.Add(this.pbBookImage);
            this.panel3.Location = new System.Drawing.Point(672, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 286);
            this.panel3.TabIndex = 14;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemoveImage.Location = new System.Drawing.Point(15, 231);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(165, 45);
            this.btnRemoveImage.TabIndex = 39;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnChooseImage.Location = new System.Drawing.Point(15, 180);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(165, 45);
            this.btnChooseImage.TabIndex = 38;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // pbBookImage
            // 
            this.pbBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBookImage.Image = global::BMS.Properties.Resources.book_96px;
            this.pbBookImage.Location = new System.Drawing.Point(15, 5);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(165, 167);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 0;
            this.pbBookImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBookCopiesCount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nudBookCopies);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAdditionalDetials);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpPublisherDate);
            this.panel2.Controls.Add(this.cbCategories);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Location = new System.Drawing.Point(139, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 286);
            this.panel2.TabIndex = 13;
            // 
            // lblBookCopiesCount
            // 
            this.lblBookCopiesCount.AutoSize = true;
            this.lblBookCopiesCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBookCopiesCount.Location = new System.Drawing.Point(431, 161);
            this.lblBookCopiesCount.Name = "lblBookCopiesCount";
            this.lblBookCopiesCount.Size = new System.Drawing.Size(25, 19);
            this.lblBookCopiesCount.TabIndex = 19;
            this.lblBookCopiesCount.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(275, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Book Copies Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(25, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book Copies ";
            // 
            // nudBookCopies
            // 
            this.nudBookCopies.Location = new System.Drawing.Point(19, 161);
            this.nudBookCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBookCopies.Name = "nudBookCopies";
            this.nudBookCopies.Size = new System.Drawing.Size(225, 28);
            this.nudBookCopies.TabIndex = 16;
            this.nudBookCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(25, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Additional Detials:";
            // 
            // txtAdditionalDetials
            // 
            this.txtAdditionalDetials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalDetials.Location = new System.Drawing.Point(19, 225);
            this.txtAdditionalDetials.MaxLength = 200;
            this.txtAdditionalDetials.Multiline = true;
            this.txtAdditionalDetials.Name = "txtAdditionalDetials";
            this.txtAdditionalDetials.Size = new System.Drawing.Size(484, 50);
            this.txtAdditionalDetials.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(25, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Publisher:";
            // 
            // dtpPublisherDate
            // 
            this.dtpPublisherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublisherDate.Location = new System.Drawing.Point(19, 102);
            this.dtpPublisherDate.Name = "dtpPublisherDate";
            this.dtpPublisherDate.Size = new System.Drawing.Size(225, 28);
            this.dtpPublisherDate.TabIndex = 12;
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(278, 101);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(225, 29);
            this.cbCategories.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(19, 35);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(225, 36);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(284, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(284, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Location = new System.Drawing.Point(278, 35);
            this.txtISBN.MaxLength = 200;
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(225, 36);
            this.txtISBN.TabIndex = 8;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBookID);
            this.panel1.Location = new System.Drawing.Point(139, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 42);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(87, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBookID.Location = new System.Drawing.Point(124, 10);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(45, 19);
            this.lblBookID.TabIndex = 2;
            this.lblBookID.Text = "[???]";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSave.Image = global::BMS.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(872, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(705, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 619);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcBook);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Book";
            this.Activated += new System.EventHandler(this.frmAddUpdateBook_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateBook_Load);
            this.tcBook.ResumeLayout(false);
            this.tpAuthorInfo.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.tpBookInfo.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookCopies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcBook;
        private System.Windows.Forms.TabPage tpAuthorInfo;
        private System.Windows.Forms.TabPage tpBookInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPublisherDate;
        private System.Windows.Forms.TextBox txtAdditionalDetials;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudBookCopies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBookCopiesCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llAddCategory;
    }
}
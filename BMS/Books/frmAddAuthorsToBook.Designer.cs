namespace BMS.Books
{
    partial class frmAddAuthorsToBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.tcAddAuthorsToBook = new System.Windows.Forms.TabControl();
            this.tpAuthorInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookCardWithFilter1 = new BMS.Books.Controls.ctrlBookCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.tcAddAuthorsToBook.SuspendLayout();
            this.tpAuthorInfo.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(363, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Authors To Book";
            // 
            // tcAddAuthorsToBook
            // 
            this.tcAddAuthorsToBook.Controls.Add(this.tpAuthorInfo);
            this.tcAddAuthorsToBook.Controls.Add(this.tpBookInfo);
            this.tcAddAuthorsToBook.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tcAddAuthorsToBook.Location = new System.Drawing.Point(12, 51);
            this.tcAddAuthorsToBook.Name = "tcAddAuthorsToBook";
            this.tcAddAuthorsToBook.SelectedIndex = 0;
            this.tcAddAuthorsToBook.Size = new System.Drawing.Size(1037, 522);
            this.tcAddAuthorsToBook.TabIndex = 1;
            // 
            // tpAuthorInfo
            // 
            this.tpAuthorInfo.BackColor = System.Drawing.Color.White;
            this.tpAuthorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAuthorInfo.Controls.Add(this.btnAddAuthor);
            this.tpAuthorInfo.Controls.Add(this.btnNextTab);
            this.tpAuthorInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpAuthorInfo.Location = new System.Drawing.Point(4, 30);
            this.tpAuthorInfo.Name = "tpAuthorInfo";
            this.tpAuthorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAuthorInfo.Size = new System.Drawing.Size(1029, 488);
            this.tpAuthorInfo.TabIndex = 0;
            this.tpAuthorInfo.Text = "AuthorInfo";
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(792, 448);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(161, 33);
            this.btnNextTab.TabIndex = 2;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(27, 15);
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
            this.tpBookInfo.Controls.Add(this.ctrlBookCardWithFilter1);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 30);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(1029, 488);
            this.tpBookInfo.TabIndex = 1;
            this.tpBookInfo.Text = "Book Info";
            // 
            // ctrlBookCardWithFilter1
            // 
            this.ctrlBookCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardWithFilter1.FilterEnabled = true;
            this.ctrlBookCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlBookCardWithFilter1.Location = new System.Drawing.Point(33, 8);
            this.ctrlBookCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlBookCardWithFilter1.Name = "ctrlBookCardWithFilter1";
            this.ctrlBookCardWithFilter1.Size = new System.Drawing.Size(972, 462);
            this.ctrlBookCardWithFilter1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(717, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSave.Image = global::BMS.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(884, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Location = new System.Drawing.Point(858, 50);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(74, 56);
            this.btnAddAuthor.TabIndex = 3;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // frmAddAuthorsToBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 629);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcAddAuthorsToBook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddAuthorsToBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Authors To Book";
            this.Activated += new System.EventHandler(this.frmAddAuthorsToBook_Activated);

            this.tcAddAuthorsToBook.ResumeLayout(false);
            this.tpAuthorInfo.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcAddAuthorsToBook;
        private System.Windows.Forms.TabPage tpAuthorInfo;
        private System.Windows.Forms.TabPage tpBookInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlBookCardWithFilter ctrlBookCardWithFilter1;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}
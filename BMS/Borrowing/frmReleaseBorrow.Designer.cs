namespace BMS.Borrowing
{
    partial class frmReleaseBorrow
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
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llAddFine = new System.Windows.Forms.LinkLabel();
            this.llShowAuthorsBook = new System.Windows.Forms.LinkLabel();
            this.llShowBookCopies = new System.Windows.Forms.LinkLabel();
            this.llShowBorrowInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlReleaseBorrowWithFilter1 = new BMS.Borrowing.Controls.ctrlReleaseBorrowWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(457, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Borrow:";
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRelease.Location = new System.Drawing.Point(1001, 566);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(103, 40);
            this.btnRelease.TabIndex = 2;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(853, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llAddFine
            // 
            this.llAddFine.AutoSize = true;
            this.llAddFine.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llAddFine.Location = new System.Drawing.Point(609, 566);
            this.llAddFine.Name = "llAddFine";
            this.llAddFine.Size = new System.Drawing.Size(89, 23);
            this.llAddFine.TabIndex = 4;
            this.llAddFine.TabStop = true;
            this.llAddFine.Text = "Fine Fees";
            this.llAddFine.Visible = false;
            this.llAddFine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddFine_LinkClicked);
            // 
            // llShowAuthorsBook
            // 
            this.llShowAuthorsBook.AutoSize = true;
            this.llShowAuthorsBook.Enabled = false;
            this.llShowAuthorsBook.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowAuthorsBook.Location = new System.Drawing.Point(51, 566);
            this.llShowAuthorsBook.Name = "llShowAuthorsBook";
            this.llShowAuthorsBook.Size = new System.Drawing.Size(172, 23);
            this.llShowAuthorsBook.TabIndex = 5;
            this.llShowAuthorsBook.TabStop = true;
            this.llShowAuthorsBook.Text = "Show Authors Book";
            this.llShowAuthorsBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowAuthorsBook_LinkClicked);
            // 
            // llShowBookCopies
            // 
            this.llShowBookCopies.AutoSize = true;
            this.llShowBookCopies.Enabled = false;
            this.llShowBookCopies.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowBookCopies.Location = new System.Drawing.Point(236, 566);
            this.llShowBookCopies.Name = "llShowBookCopies";
            this.llShowBookCopies.Size = new System.Drawing.Size(162, 23);
            this.llShowBookCopies.TabIndex = 6;
            this.llShowBookCopies.TabStop = true;
            this.llShowBookCopies.Text = "Show Book Copies";
            this.llShowBookCopies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowBookCopies_LinkClicked);
            // 
            // llShowBorrowInfo
            // 
            this.llShowBorrowInfo.AutoSize = true;
            this.llShowBorrowInfo.Enabled = false;
            this.llShowBorrowInfo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowBorrowInfo.Location = new System.Drawing.Point(411, 566);
            this.llShowBorrowInfo.Name = "llShowBorrowInfo";
            this.llShowBorrowInfo.Size = new System.Drawing.Size(161, 23);
            this.llShowBorrowInfo.TabIndex = 7;
            this.llShowBorrowInfo.TabStop = true;
            this.llShowBorrowInfo.Text = "Show Borrow Info";
            this.llShowBorrowInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowBorrowInfo_LinkClicked);
            // 
            // ctrlReleaseBorrowWithFilter1
            // 
            this.ctrlReleaseBorrowWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlReleaseBorrowWithFilter1.FilterEnabled = true;
            this.ctrlReleaseBorrowWithFilter1.Location = new System.Drawing.Point(12, 38);
            this.ctrlReleaseBorrowWithFilter1.Name = "ctrlReleaseBorrowWithFilter1";
            this.ctrlReleaseBorrowWithFilter1.Size = new System.Drawing.Size(1146, 533);
            this.ctrlReleaseBorrowWithFilter1.TabIndex = 0;
            this.ctrlReleaseBorrowWithFilter1.VisibleLinkFineFees = false;
            this.ctrlReleaseBorrowWithFilter1.VisibleMessageUser = false;
            this.ctrlReleaseBorrowWithFilter1.OnSelectedBorrow += new System.Action<int>(this.ctrlReleaseBorrowWithFilter1_OnSelectedBorrow);
            // 
            // frmReleaseBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 618);
            this.Controls.Add(this.llShowBorrowInfo);
            this.Controls.Add(this.llShowBookCopies);
            this.Controls.Add(this.llShowAuthorsBook);
            this.Controls.Add(this.llAddFine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlReleaseBorrowWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmReleaseBorrow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Borrow";
            this.Activated += new System.EventHandler(this.frmReleaseBorrow_Activated);
            this.Load += new System.EventHandler(this.frmReleaseBorrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlReleaseBorrowWithFilter ctrlReleaseBorrowWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llAddFine;
        private System.Windows.Forms.LinkLabel llShowAuthorsBook;
        private System.Windows.Forms.LinkLabel llShowBookCopies;
        private System.Windows.Forms.LinkLabel llShowBorrowInfo;
    }
}
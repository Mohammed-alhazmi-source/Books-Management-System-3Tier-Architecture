namespace BMS.Books
{
    partial class frmBookCopiesHistory
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBookCardWithFilter1 = new BMS.Books.Controls.ctrlBookCardWithFilter();
            this.ctrlBookCopiesHistory1 = new BMS.Books.BookCopies.Controls.ctrlBookCopiesHistory();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(884, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.books_96px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(453, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Copies";
            // 
            // ctrlBookCardWithFilter1
            // 
            this.ctrlBookCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlBookCardWithFilter1.FilterEnabled = true;
            this.ctrlBookCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCardWithFilter1.Location = new System.Drawing.Point(149, 19);
            this.ctrlBookCardWithFilter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctrlBookCardWithFilter1.Name = "ctrlBookCardWithFilter1";
            this.ctrlBookCardWithFilter1.Size = new System.Drawing.Size(935, 378);
            this.ctrlBookCardWithFilter1.TabIndex = 2;
            this.ctrlBookCardWithFilter1.OnSelectedBook += new System.Action<int>(this.ctrlBookCardWithFilter1_OnSelectedBook);
            // 
            // ctrlBookCopiesHistory1
            // 
            this.ctrlBookCopiesHistory1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCopiesHistory1.Font = new System.Drawing.Font("Segoe UI Black", 7F);
            this.ctrlBookCopiesHistory1.Location = new System.Drawing.Point(12, 388);
            this.ctrlBookCopiesHistory1.Name = "ctrlBookCopiesHistory1";
            this.ctrlBookCopiesHistory1.Size = new System.Drawing.Size(1064, 255);
            this.ctrlBookCopiesHistory1.TabIndex = 1;
            // 
            // frmBookCopiesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlBookCardWithFilter1);
            this.Controls.Add(this.ctrlBookCopiesHistory1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmBookCopiesHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Copies History";
            this.Load += new System.EventHandler(this.frmBookCopiesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BookCopies.Controls.ctrlBookCopiesHistory ctrlBookCopiesHistory1;
        private Controls.ctrlBookCardWithFilter ctrlBookCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
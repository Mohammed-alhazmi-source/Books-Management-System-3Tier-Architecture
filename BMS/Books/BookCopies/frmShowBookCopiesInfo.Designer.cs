namespace BMS.Books.BookCopies
{
    partial class frmShowBookCopiesInfo
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
            this.ctrlBookCopiesCard1 = new BMS.Books.BookCopies.Controls.ctrlBookCopiesCard();
            this.SuspendLayout();
            // 
            // ctrlBookCopiesCard1
            // 
            this.ctrlBookCopiesCard1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCopiesCard1.Location = new System.Drawing.Point(30, 35);
            this.ctrlBookCopiesCard1.Name = "ctrlBookCopiesCard1";
            this.ctrlBookCopiesCard1.Size = new System.Drawing.Size(929, 447);
            this.ctrlBookCopiesCard1.TabIndex = 0;
            // 
            // frmShowBookCopiesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 494);
            this.Controls.Add(this.ctrlBookCopiesCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmShowBookCopiesInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowBookCopiesInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlBookCopiesCard ctrlBookCopiesCard1;
    }
}
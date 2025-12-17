namespace BMS.Books.Controls
{
    partial class ctrlNewBorrowOrNewReserve
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetBorrowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetReserveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBookCardWithFilter1 = new BMS.Books.Controls.ctrlBookCardWithFilter();
            this.ctrlBookCopiesHistory1 = new BMS.Books.BookCopies.Controls.ctrlBookCopiesHistory();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetBorrowItem,
            this.SetReserveItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 102);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // SetBorrowItem
            // 
            this.SetBorrowItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SetBorrowItem.Image = global::BMS.Properties.Resources.borrow_book_32px;
            this.SetBorrowItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetBorrowItem.Name = "SetBorrowItem";
            this.SetBorrowItem.Size = new System.Drawing.Size(196, 38);
            this.SetBorrowItem.Text = "Set Borrow";
            this.SetBorrowItem.Visible = false;
            this.SetBorrowItem.Click += new System.EventHandler(this.SetBorrowItem_Click);
            // 
            // SetReserveItem
            // 
            this.SetReserveItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SetReserveItem.Image = global::BMS.Properties.Resources.reservation_32px;
            this.SetReserveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetReserveItem.Name = "SetReserveItem";
            this.SetReserveItem.Size = new System.Drawing.Size(196, 38);
            this.SetReserveItem.Text = "Set Reserve";
            this.SetReserveItem.Visible = false;
            this.SetReserveItem.Click += new System.EventHandler(this.SetReserveItem_Click);
            // 
            // ctrlBookCardWithFilter1
            // 
            this.ctrlBookCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardWithFilter1.FilterEnabled = true;
            this.ctrlBookCardWithFilter1.Font = new System.Drawing.Font("Stencil", 6F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCardWithFilter1.Location = new System.Drawing.Point(90, -20);
            this.ctrlBookCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlBookCardWithFilter1.Name = "ctrlBookCardWithFilter1";
            this.ctrlBookCardWithFilter1.Size = new System.Drawing.Size(937, 310);
            this.ctrlBookCardWithFilter1.TabIndex = 2;
            this.ctrlBookCardWithFilter1.OnSelectedBook += new System.Action<int>(this.ctrlBookCardWithFilter1_OnSelectedBook);
            // 
            // ctrlBookCopiesHistory1
            // 
            this.ctrlBookCopiesHistory1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCopiesHistory1.Font = new System.Drawing.Font("Stencil", 6F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCopiesHistory1.Location = new System.Drawing.Point(30, 283);
            this.ctrlBookCopiesHistory1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctrlBookCopiesHistory1.Name = "ctrlBookCopiesHistory1";
            this.ctrlBookCopiesHistory1.SelectedContextMenuStrip = this.contextMenuStrip1;
            this.ctrlBookCopiesHistory1.Size = new System.Drawing.Size(1057, 194);
            this.ctrlBookCopiesHistory1.TabIndex = 1;
            // 
            // ctrlNewBorrowOrNewReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBookCardWithFilter1);
            this.Controls.Add(this.ctrlBookCopiesHistory1);
            this.Name = "ctrlNewBorrowOrNewReserve";
            this.Size = new System.Drawing.Size(1106, 475);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BookCopies.Controls.ctrlBookCopiesHistory ctrlBookCopiesHistory1;
        private ctrlBookCardWithFilter ctrlBookCardWithFilter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SetBorrowItem;
        private System.Windows.Forms.ToolStripMenuItem SetReserveItem;
    }
}

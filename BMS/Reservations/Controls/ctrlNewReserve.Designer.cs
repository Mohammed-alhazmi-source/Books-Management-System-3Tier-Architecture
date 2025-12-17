namespace BMS.Reservations.Controls
{
    partial class ctrlNewReserve
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
            this.ctrlBookCardWithFilter1 = new BMS.Books.Controls.ctrlBookCardWithFilter();
            this.ctrlBookCopiesHistory1 = new BMS.Books.BookCopies.Controls.ctrlBookCopiesHistory();
            this.cmsReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetReserveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBookCardWithFilter1
            // 
            this.ctrlBookCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardWithFilter1.FilterEnabled = true;
            this.ctrlBookCardWithFilter1.Font = new System.Drawing.Font("Stencil", 6F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCardWithFilter1.Location = new System.Drawing.Point(85, 1);
            this.ctrlBookCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlBookCardWithFilter1.Name = "ctrlBookCardWithFilter1";
            this.ctrlBookCardWithFilter1.Size = new System.Drawing.Size(937, 310);
            this.ctrlBookCardWithFilter1.TabIndex = 3;
            this.ctrlBookCardWithFilter1.OnSelectedBook += new System.Action<int>(this.ctrlBookCardWithFilter1_OnSelectedBook);
            // 
            // ctrlBookCopiesHistory1
            // 
            this.ctrlBookCopiesHistory1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCopiesHistory1.Font = new System.Drawing.Font("Stencil", 6F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCopiesHistory1.Location = new System.Drawing.Point(25, 304);
            this.ctrlBookCopiesHistory1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctrlBookCopiesHistory1.Name = "ctrlBookCopiesHistory1";
            this.ctrlBookCopiesHistory1.SelectedContextMenuStrip = this.cmsReservations;
            this.ctrlBookCopiesHistory1.Size = new System.Drawing.Size(1057, 194);
            this.ctrlBookCopiesHistory1.TabIndex = 4;
            // 
            // cmsReservations
            // 
            this.cmsReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetReserveItem});
            this.cmsReservations.Name = "cmsReservations";
            this.cmsReservations.Size = new System.Drawing.Size(186, 42);
            this.cmsReservations.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReservations_Opening);
            // 
            // SetReserveItem
            // 
            this.SetReserveItem.Enabled = false;
            this.SetReserveItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.SetReserveItem.Image = global::BMS.Properties.Resources.reservation_32px;
            this.SetReserveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SetReserveItem.Name = "SetReserveItem";
            this.SetReserveItem.Size = new System.Drawing.Size(185, 38);
            this.SetReserveItem.Text = "Set Reserve";
            this.SetReserveItem.Click += new System.EventHandler(this.SetReserveItem_Click);
            // 
            // ctrlNewReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBookCopiesHistory1);
            this.Controls.Add(this.ctrlBookCardWithFilter1);
            this.Name = "ctrlNewReserve";
            this.Size = new System.Drawing.Size(1106, 515);
            this.cmsReservations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Books.Controls.ctrlBookCardWithFilter ctrlBookCardWithFilter1;
        private Books.BookCopies.Controls.ctrlBookCopiesHistory ctrlBookCopiesHistory1;
        private System.Windows.Forms.ContextMenuStrip cmsReservations;
        private System.Windows.Forms.ToolStripMenuItem SetReserveItem;
    }
}

namespace BMS.Books.BookCopies
{
    partial class frmAddCopiesToBook
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
            this.ctrlBookCardWithFilter1 = new BMS.Books.Controls.ctrlBookCardWithFilter();
            this.nudCopiesCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowBookCopiesHistory = new System.Windows.Forms.LinkLabel();
            this.llShowBookDetials = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCopiesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlBookCardWithFilter1
            // 
            this.ctrlBookCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookCardWithFilter1.FilterEnabled = true;
            this.ctrlBookCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.ctrlBookCardWithFilter1.Location = new System.Drawing.Point(11, 63);
            this.ctrlBookCardWithFilter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ctrlBookCardWithFilter1.Name = "ctrlBookCardWithFilter1";
            this.ctrlBookCardWithFilter1.Size = new System.Drawing.Size(925, 376);
            this.ctrlBookCardWithFilter1.TabIndex = 0;
            this.ctrlBookCardWithFilter1.OnSelectedBook += new System.Action<int>(this.ctrlBookCardWithFilter1_OnSelectedBook);
            // 
            // nudCopiesCount
            // 
            this.nudCopiesCount.Font = new System.Drawing.Font("Tahoma", 13F);
            this.nudCopiesCount.Location = new System.Drawing.Point(495, 443);
            this.nudCopiesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCopiesCount.Name = "nudCopiesCount";
            this.nudCopiesCount.Size = new System.Drawing.Size(120, 28);
            this.nudCopiesCount.TabIndex = 1;
            this.nudCopiesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(383, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copies Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(340, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Copies To Book";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::BMS.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(849, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(705, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowBookCopiesHistory
            // 
            this.llShowBookCopiesHistory.AutoSize = true;
            this.llShowBookCopiesHistory.Enabled = false;
            this.llShowBookCopiesHistory.Font = new System.Drawing.Font("Tahoma", 13F);
            this.llShowBookCopiesHistory.Location = new System.Drawing.Point(75, 498);
            this.llShowBookCopiesHistory.Name = "llShowBookCopiesHistory";
            this.llShowBookCopiesHistory.Size = new System.Drawing.Size(218, 22);
            this.llShowBookCopiesHistory.TabIndex = 6;
            this.llShowBookCopiesHistory.TabStop = true;
            this.llShowBookCopiesHistory.Text = "Show Book Copies History";
            this.llShowBookCopiesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowBookCopiesHistory_LinkClicked);
            // 
            // llShowBookDetials
            // 
            this.llShowBookDetials.AutoSize = true;
            this.llShowBookDetials.Enabled = false;
            this.llShowBookDetials.Font = new System.Drawing.Font("Tahoma", 13F);
            this.llShowBookDetials.Location = new System.Drawing.Point(299, 498);
            this.llShowBookDetials.Name = "llShowBookDetials";
            this.llShowBookDetials.Size = new System.Drawing.Size(157, 22);
            this.llShowBookDetials.TabIndex = 7;
            this.llShowBookDetials.TabStop = true;
            this.llShowBookDetials.Text = "Show Book Detials";
            this.llShowBookDetials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowBookDetials_LinkClicked);
            // 
            // frmAddCopiesToBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(999, 542);
            this.Controls.Add(this.llShowBookDetials);
            this.Controls.Add(this.llShowBookCopiesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCopiesCount);
            this.Controls.Add(this.ctrlBookCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmAddCopiesToBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Copies To Book";
            this.Load += new System.EventHandler(this.frmAddCopiesToBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCopiesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Books.Controls.ctrlBookCardWithFilter ctrlBookCardWithFilter1;
        private System.Windows.Forms.NumericUpDown nudCopiesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowBookCopiesHistory;
        private System.Windows.Forms.LinkLabel llShowBookDetials;
    }
}
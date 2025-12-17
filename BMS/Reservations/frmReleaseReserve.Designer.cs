namespace BMS.Reservations
{
    partial class frmReleaseReserve
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
            this.tcReservations = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpReserveInfo = new System.Windows.Forms.TabPage();
            this.ctrlReserveCardWithFilter1 = new BMS.Reservations.Controls.ctrlReserveCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowReserveInfo = new System.Windows.Forms.LinkLabel();
            this.llShowBookCopies = new System.Windows.Forms.LinkLabel();
            this.llShowAuthorsBook = new System.Windows.Forms.LinkLabel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcReservations.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpReserveInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcReservations
            // 
            this.tcReservations.Controls.Add(this.tpPersonInfo);
            this.tcReservations.Controls.Add(this.tpReserveInfo);
            this.tcReservations.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tcReservations.Location = new System.Drawing.Point(12, 29);
            this.tcReservations.Name = "tcReservations";
            this.tcReservations.SelectedIndex = 0;
            this.tcReservations.Size = new System.Drawing.Size(1094, 505);
            this.tcReservations.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPersonInfo.Controls.Add(this.btnNextTab);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 30);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1086, 431);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "PersonInfo";
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(756, 385);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(176, 38);
            this.btnNextTab.TabIndex = 2;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(4, 23);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(958, 384);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnSelectedPerson);
            // 
            // tpReserveInfo
            // 
            this.tpReserveInfo.BackColor = System.Drawing.Color.White;
            this.tpReserveInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReserveInfo.Controls.Add(this.btnClose);
            this.tpReserveInfo.Controls.Add(this.llShowAuthorsBook);
            this.tpReserveInfo.Controls.Add(this.ctrlReserveCardWithFilter1);
            this.tpReserveInfo.Controls.Add(this.llShowBookCopies);
            this.tpReserveInfo.Controls.Add(this.btnRelease);
            this.tpReserveInfo.Controls.Add(this.llShowReserveInfo);
            this.tpReserveInfo.Location = new System.Drawing.Point(4, 30);
            this.tpReserveInfo.Name = "tpReserveInfo";
            this.tpReserveInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReserveInfo.Size = new System.Drawing.Size(1086, 471);
            this.tpReserveInfo.TabIndex = 1;
            this.tpReserveInfo.Text = "Reserve Info";
            // 
            // ctrlReserveCardWithFilter1
            // 
            this.ctrlReserveCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlReserveCardWithFilter1.FilterEnable = true;
            this.ctrlReserveCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.ctrlReserveCardWithFilter1.Location = new System.Drawing.Point(-10, 29);
            this.ctrlReserveCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlReserveCardWithFilter1.Name = "ctrlReserveCardWithFilter1";
            this.ctrlReserveCardWithFilter1.PersonID = -1;
            this.ctrlReserveCardWithFilter1.Size = new System.Drawing.Size(1088, 378);
            this.ctrlReserveCardWithFilter1.TabIndex = 0;
            this.ctrlReserveCardWithFilter1.OnSelectedReserve += new System.Action<int>(this.ctrlReserveCardWithFilter1_OnSelectedReserve);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Location = new System.Drawing.Point(755, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowReserveInfo
            // 
            this.llShowReserveInfo.AutoSize = true;
            this.llShowReserveInfo.Enabled = false;
            this.llShowReserveInfo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowReserveInfo.Location = new System.Drawing.Point(351, 435);
            this.llShowReserveInfo.Name = "llShowReserveInfo";
            this.llShowReserveInfo.Size = new System.Drawing.Size(168, 23);
            this.llShowReserveInfo.TabIndex = 10;
            this.llShowReserveInfo.TabStop = true;
            this.llShowReserveInfo.Text = "Show Reserve Info";
            this.llShowReserveInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowReserveInfo_LinkClicked);
            // 
            // llShowBookCopies
            // 
            this.llShowBookCopies.AutoSize = true;
            this.llShowBookCopies.Enabled = false;
            this.llShowBookCopies.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowBookCopies.Location = new System.Drawing.Point(183, 435);
            this.llShowBookCopies.Name = "llShowBookCopies";
            this.llShowBookCopies.Size = new System.Drawing.Size(162, 23);
            this.llShowBookCopies.TabIndex = 9;
            this.llShowBookCopies.TabStop = true;
            this.llShowBookCopies.Text = "Show Book Copies";
            this.llShowBookCopies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowBookCopies_LinkClicked);
            // 
            // llShowAuthorsBook
            // 
            this.llShowAuthorsBook.AutoSize = true;
            this.llShowAuthorsBook.Enabled = false;
            this.llShowAuthorsBook.Font = new System.Drawing.Font("Tahoma", 14F);
            this.llShowAuthorsBook.Location = new System.Drawing.Point(5, 435);
            this.llShowAuthorsBook.Name = "llShowAuthorsBook";
            this.llShowAuthorsBook.Size = new System.Drawing.Size(172, 23);
            this.llShowAuthorsBook.TabIndex = 8;
            this.llShowAuthorsBook.TabStop = true;
            this.llShowAuthorsBook.Text = "Show Authors Book";
            this.llShowAuthorsBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowAuthorsBook_LinkClicked);
            // 
            // btnRelease
            // 
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnRelease.Location = new System.Drawing.Point(915, 419);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(154, 37);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "Release Reserve";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(422, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Reserve";
            // 
            // frmReleaseReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmReleaseReserve";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Reservation";
            this.Activated += new System.EventHandler(this.frmReleaseReserve_Activated);
            this.Load += new System.EventHandler(this.frmReleaseReserve_Load);
            this.tcReservations.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpReserveInfo.ResumeLayout(false);
            this.tpReserveInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcReservations;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpReserveInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlReserveCardWithFilter ctrlReserveCardWithFilter1;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.LinkLabel llShowReserveInfo;
        private System.Windows.Forms.LinkLabel llShowBookCopies;
        private System.Windows.Forms.LinkLabel llShowAuthorsBook;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}
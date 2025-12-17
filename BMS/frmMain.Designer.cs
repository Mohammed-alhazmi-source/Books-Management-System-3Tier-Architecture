namespace BMS
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManagementApplicationsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBorrowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementBorrowingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseBorrowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ReservationsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReservationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementReservationsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseReserveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FinesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementFinesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementCategoriesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementBooksItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementAuthorsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementUsersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUserInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SignOutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagementApplicationsItem,
            this.ManagementCategoriesItem,
            this.ManagementBooksItem,
            this.PeopleItem,
            this.ManagementAuthorsItem,
            this.ManagementUsersItem,
            this.AccountSettingsItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1256, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManagementApplicationsItem
            // 
            this.ManagementApplicationsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BorrowingItem,
            this.toolStripSeparator2,
            this.ReservationsItem,
            this.toolStripSeparator3,
            this.FinesItem});
            this.ManagementApplicationsItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ManagementApplicationsItem.Image = global::BMS.Properties.Resources.Manage_Applications_64;
            this.ManagementApplicationsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementApplicationsItem.Name = "ManagementApplicationsItem";
            this.ManagementApplicationsItem.Size = new System.Drawing.Size(197, 68);
            this.ManagementApplicationsItem.Text = "Applications";
            // 
            // BorrowingItem
            // 
            this.BorrowingItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBorrowItem,
            this.ManagementBorrowingItem,
            this.ReleaseBorrowItem});
            this.BorrowingItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.BorrowingItem.Image = global::BMS.Properties.Resources.borrow_book_32px;
            this.BorrowingItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrowingItem.Name = "BorrowingItem";
            this.BorrowingItem.Size = new System.Drawing.Size(322, 38);
            this.BorrowingItem.Text = "Management Borrow ";
            // 
            // AddBorrowItem
            // 
            this.AddBorrowItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBorrowItem.Name = "AddBorrowItem";
            this.AddBorrowItem.Size = new System.Drawing.Size(312, 38);
            this.AddBorrowItem.Text = "Add Borrow";
            this.AddBorrowItem.Click += new System.EventHandler(this.AddBorrowItem_Click);
            // 
            // ManagementBorrowingItem
            // 
            this.ManagementBorrowingItem.Image = global::BMS.Properties.Resources.borrow_book_32px;
            this.ManagementBorrowingItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementBorrowingItem.Name = "ManagementBorrowingItem";
            this.ManagementBorrowingItem.Size = new System.Drawing.Size(312, 38);
            this.ManagementBorrowingItem.Text = "Management Borrowing";
            this.ManagementBorrowingItem.Click += new System.EventHandler(this.ManagementBorrowingItem_Click);
            // 
            // ReleaseBorrowItem
            // 
            this.ReleaseBorrowItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReleaseBorrowItem.Name = "ReleaseBorrowItem";
            this.ReleaseBorrowItem.Size = new System.Drawing.Size(312, 38);
            this.ReleaseBorrowItem.Text = "Release Borrow";
            this.ReleaseBorrowItem.Click += new System.EventHandler(this.ReleaseBorrowItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(319, 6);
            // 
            // ReservationsItem
            // 
            this.ReservationsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddReservationItem,
            this.ManagementReservationsItem,
            this.ReleaseReserveItem});
            this.ReservationsItem.Image = global::BMS.Properties.Resources.reservation_32px;
            this.ReservationsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReservationsItem.Name = "ReservationsItem";
            this.ReservationsItem.Size = new System.Drawing.Size(322, 38);
            this.ReservationsItem.Text = "Management Reservation";
            // 
            // AddReservationItem
            // 
            this.AddReservationItem.Name = "AddReservationItem";
            this.AddReservationItem.Size = new System.Drawing.Size(330, 38);
            this.AddReservationItem.Text = "Add Reservation";
            this.AddReservationItem.Click += new System.EventHandler(this.AddReservationItem_Click);
            // 
            // ManagementReservationsItem
            // 
            this.ManagementReservationsItem.Image = global::BMS.Properties.Resources.reservation_32px;
            this.ManagementReservationsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementReservationsItem.Name = "ManagementReservationsItem";
            this.ManagementReservationsItem.Size = new System.Drawing.Size(330, 38);
            this.ManagementReservationsItem.Text = "Management Reservations";
            this.ManagementReservationsItem.Click += new System.EventHandler(this.ManagementReservationsItem_Click);
            // 
            // ReleaseReserveItem
            // 
            this.ReleaseReserveItem.Name = "ReleaseReserveItem";
            this.ReleaseReserveItem.Size = new System.Drawing.Size(330, 38);
            this.ReleaseReserveItem.Text = "Release Reserve";
            this.ReleaseReserveItem.Click += new System.EventHandler(this.ReleaseReserveItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(319, 6);
            // 
            // FinesItem
            // 
            this.FinesItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFineItem,
            this.ManagementFinesItem});
            this.FinesItem.Image = global::BMS.Properties.Resources.money_32;
            this.FinesItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FinesItem.Name = "FinesItem";
            this.FinesItem.Size = new System.Drawing.Size(322, 38);
            this.FinesItem.Text = "Management Fine";
            // 
            // AddFineItem
            // 
            this.AddFineItem.Name = "AddFineItem";
            this.AddFineItem.Size = new System.Drawing.Size(249, 32);
            this.AddFineItem.Text = "Add Fine";
            this.AddFineItem.Click += new System.EventHandler(this.AddFineItem_Click);
            // 
            // ManagementFinesItem
            // 
            this.ManagementFinesItem.Name = "ManagementFinesItem";
            this.ManagementFinesItem.Size = new System.Drawing.Size(249, 32);
            this.ManagementFinesItem.Text = "Management Fines";
            this.ManagementFinesItem.Click += new System.EventHandler(this.ManagementFinesItem_Click);
            // 
            // ManagementCategoriesItem
            // 
            this.ManagementCategoriesItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ManagementCategoriesItem.Image = global::BMS.Properties.Resources.categorize_64;
            this.ManagementCategoriesItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementCategoriesItem.Name = "ManagementCategoriesItem";
            this.ManagementCategoriesItem.Size = new System.Drawing.Size(181, 68);
            this.ManagementCategoriesItem.Text = "Categories";
            this.ManagementCategoriesItem.Click += new System.EventHandler(this.ManagementCategoriesItem_Click);
            // 
            // ManagementBooksItem
            // 
            this.ManagementBooksItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ManagementBooksItem.Image = global::BMS.Properties.Resources.books_64px;
            this.ManagementBooksItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementBooksItem.Name = "ManagementBooksItem";
            this.ManagementBooksItem.Size = new System.Drawing.Size(141, 68);
            this.ManagementBooksItem.Text = "Books";
            this.ManagementBooksItem.Click += new System.EventHandler(this.ManagementBooksItem_Click);
            // 
            // PeopleItem
            // 
            this.PeopleItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PeopleItem.Image = global::BMS.Properties.Resources.People_64;
            this.PeopleItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PeopleItem.Name = "PeopleItem";
            this.PeopleItem.Size = new System.Drawing.Size(147, 68);
            this.PeopleItem.Text = "People";
            this.PeopleItem.Click += new System.EventHandler(this.PeopleItem_Click);
            // 
            // ManagementAuthorsItem
            // 
            this.ManagementAuthorsItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ManagementAuthorsItem.Image = global::BMS.Properties.Resources.Drivers_64;
            this.ManagementAuthorsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementAuthorsItem.Name = "ManagementAuthorsItem";
            this.ManagementAuthorsItem.Size = new System.Drawing.Size(157, 68);
            this.ManagementAuthorsItem.Text = "Authors";
            this.ManagementAuthorsItem.Click += new System.EventHandler(this.ManagementAuthorsItem_Click);
            // 
            // ManagementUsersItem
            // 
            this.ManagementUsersItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ManagementUsersItem.Image = global::BMS.Properties.Resources.Users_2_64;
            this.ManagementUsersItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagementUsersItem.Name = "ManagementUsersItem";
            this.ManagementUsersItem.Size = new System.Drawing.Size(135, 68);
            this.ManagementUsersItem.Text = "Users";
            this.ManagementUsersItem.Click += new System.EventHandler(this.ManagementUsersItem_Click);
            // 
            // AccountSettingsItem
            // 
            this.AccountSettingsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserInfoItem,
            this.ChangePasswordItem,
            this.toolStripSeparator1,
            this.SignOutItem});
            this.AccountSettingsItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AccountSettingsItem.Image = global::BMS.Properties.Resources.account_settings_64;
            this.AccountSettingsItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountSettingsItem.Name = "AccountSettingsItem";
            this.AccountSettingsItem.Size = new System.Drawing.Size(236, 68);
            this.AccountSettingsItem.Text = "Account Settings";
            // 
            // CurrentUserInfoItem
            // 
            this.CurrentUserInfoItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.CurrentUserInfoItem.Image = global::BMS.Properties.Resources.PersonDetails_32;
            this.CurrentUserInfoItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CurrentUserInfoItem.Name = "CurrentUserInfoItem";
            this.CurrentUserInfoItem.Size = new System.Drawing.Size(240, 38);
            this.CurrentUserInfoItem.Text = "Current User Info";
            this.CurrentUserInfoItem.Click += new System.EventHandler(this.CurrentUserInfoItem_Click);
            // 
            // ChangePasswordItem
            // 
            this.ChangePasswordItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ChangePasswordItem.Image = global::BMS.Properties.Resources.Password_32;
            this.ChangePasswordItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordItem.Name = "ChangePasswordItem";
            this.ChangePasswordItem.Size = new System.Drawing.Size(240, 38);
            this.ChangePasswordItem.Text = "Change Password";
            this.ChangePasswordItem.Click += new System.EventHandler(this.ChangePasswordItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // SignOutItem
            // 
            this.SignOutItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.SignOutItem.Image = global::BMS.Properties.Resources.sign_out_32__2;
            this.SignOutItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SignOutItem.Name = "SignOutItem";
            this.SignOutItem.Size = new System.Drawing.Size(240, 38);
            this.SignOutItem.Text = "Sign Out";
            this.SignOutItem.Click += new System.EventHandler(this.SignOutItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 74F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1256, 381);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 74F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(905, 238);
            this.label2.TabIndex = 5;
            this.label2.Text = "Books Management\r\nSystem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1256, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManagementApplicationsItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementAuthorsItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementUsersItem;
        private System.Windows.Forms.ToolStripMenuItem AccountSettingsItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentUserInfoItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SignOutItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementBooksItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementCategoriesItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowingItem;
        private System.Windows.Forms.ToolStripMenuItem AddBorrowItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementBorrowingItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ReservationsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FinesItem;
        private System.Windows.Forms.ToolStripMenuItem AddReservationItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementReservationsItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseBorrowItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseReserveItem;
        private System.Windows.Forms.ToolStripMenuItem AddFineItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementFinesItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
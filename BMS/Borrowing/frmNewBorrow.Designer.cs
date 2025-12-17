namespace BMS.Borrowing
{
    partial class frmNewBorrow
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcBorrowing = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpBookCopiesInfo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBorrowingDays = new System.Windows.Forms.NumericUpDown();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPricePreDay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBorrowingDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBookCopyID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlNewBorrowOrNewReserve1 = new BMS.Books.Controls.ctrlNewBorrowOrNewReserve();
            this.tcBorrowing.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpBookCopiesInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorrowingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(282, -4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(512, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Copies Borrowing";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcBorrowing
            // 
            this.tcBorrowing.Controls.Add(this.tpPersonInfo);
            this.tcBorrowing.Controls.Add(this.tpBookCopiesInfo);
            this.tcBorrowing.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tcBorrowing.Location = new System.Drawing.Point(12, 21);
            this.tcBorrowing.Name = "tcBorrowing";
            this.tcBorrowing.SelectedIndex = 0;
            this.tcBorrowing.Size = new System.Drawing.Size(1053, 635);
            this.tcBorrowing.TabIndex = 1;
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
            this.tpPersonInfo.Size = new System.Drawing.Size(1045, 601);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(792, 496);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(176, 38);
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
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(42, 65);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(958, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnSelectedPerson);
            // 
            // tpBookCopiesInfo
            // 
            this.tpBookCopiesInfo.BackColor = System.Drawing.Color.White;
            this.tpBookCopiesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBookCopiesInfo.Controls.Add(this.groupBox1);
            this.tpBookCopiesInfo.Controls.Add(this.ctrlNewBorrowOrNewReserve1);
            this.tpBookCopiesInfo.Location = new System.Drawing.Point(4, 30);
            this.tpBookCopiesInfo.Name = "tpBookCopiesInfo";
            this.tpBookCopiesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookCopiesInfo.Size = new System.Drawing.Size(1045, 601);
            this.tpBookCopiesInfo.TabIndex = 1;
            this.tpBookCopiesInfo.Text = "Book Copies Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudBorrowingDays);
            this.groupBox1.Controls.Add(this.lblDueDate);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblPricePreDay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBorrowingDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPersonID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBookCopyID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBorrowID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(10, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrow Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(747, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Borrowing Days:";
            // 
            // nudBorrowingDays
            // 
            this.nudBorrowingDays.Location = new System.Drawing.Point(880, 17);
            this.nudBorrowingDays.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBorrowingDays.Name = "nudBorrowingDays";
            this.nudBorrowingDays.Size = new System.Drawing.Size(120, 28);
            this.nudBorrowingDays.TabIndex = 27;
            this.nudBorrowingDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBorrowingDays.ValueChanged += new System.EventHandler(this.nudBorrowingDays_ValueChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(570, 58);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(45, 19);
            this.lblDueDate.TabIndex = 26;
            this.lblDueDate.Text = "[???]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::BMS.Properties.Resources.money_32;
            this.pictureBox8.Location = new System.Drawing.Point(828, 84);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(861, 86);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(48, 19);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "[$$$]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(732, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Price:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BMS.Properties.Resources.money_32;
            this.pictureBox7.Location = new System.Drawing.Point(535, 84);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BMS.Properties.Resources.User_32__2;
            this.pictureBox6.Location = new System.Drawing.Point(828, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(165, 84);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BMS.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(534, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(165, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMS.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(534, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(165, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPricePreDay
            // 
            this.lblPricePreDay.AutoSize = true;
            this.lblPricePreDay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPricePreDay.ForeColor = System.Drawing.Color.Black;
            this.lblPricePreDay.Location = new System.Drawing.Point(568, 86);
            this.lblPricePreDay.Name = "lblPricePreDay";
            this.lblPricePreDay.Size = new System.Drawing.Size(48, 19);
            this.lblPricePreDay.TabIndex = 13;
            this.lblPricePreDay.Text = "[$$$]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(430, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price Pre Day:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(864, 59);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(45, 19);
            this.lblCreatedBy.TabIndex = 11;
            this.lblCreatedBy.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(741, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Created By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(453, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Due Date:";
            // 
            // lblBorrowingDate
            // 
            this.lblBorrowingDate.AutoSize = true;
            this.lblBorrowingDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBorrowingDate.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowingDate.Location = new System.Drawing.Point(568, 26);
            this.lblBorrowingDate.Name = "lblBorrowingDate";
            this.lblBorrowingDate.Size = new System.Drawing.Size(45, 19);
            this.lblBorrowingDate.TabIndex = 7;
            this.lblBorrowingDate.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(408, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Borrowing Date:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(201, 85);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(45, 19);
            this.lblPersonID.TabIndex = 5;
            this.lblPersonID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Person ID:";
            // 
            // lblBookCopyID
            // 
            this.lblBookCopyID.AutoSize = true;
            this.lblBookCopyID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBookCopyID.ForeColor = System.Drawing.Color.Black;
            this.lblBookCopyID.Location = new System.Drawing.Point(201, 58);
            this.lblBookCopyID.Name = "lblBookCopyID";
            this.lblBookCopyID.Size = new System.Drawing.Size(45, 19);
            this.lblBookCopyID.TabIndex = 3;
            this.lblBookCopyID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Copy ID:";
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.AutoSize = true;
            this.lblBorrowID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBorrowID.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowID.Location = new System.Drawing.Point(201, 28);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(45, 19);
            this.lblBorrowID.TabIndex = 1;
            this.lblBorrowID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow ID:";
            // 
            // ctrlNewBorrowOrNewReserve1
            // 
            this.ctrlNewBorrowOrNewReserve1.BackColor = System.Drawing.Color.White;
            this.ctrlNewBorrowOrNewReserve1.DueDate = new System.DateTime(2025, 12, 17, 16, 43, 34, 266);
            this.ctrlNewBorrowOrNewReserve1.Font = new System.Drawing.Font("Sitka Small Semibold", 7F);
            this.ctrlNewBorrowOrNewReserve1.Location = new System.Drawing.Point(-40, 9);
            this.ctrlNewBorrowOrNewReserve1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlNewBorrowOrNewReserve1.Name = "ctrlNewBorrowOrNewReserve1";
            this.ctrlNewBorrowOrNewReserve1.PersonID = -1;
            this.ctrlNewBorrowOrNewReserve1.Size = new System.Drawing.Size(1085, 480);
            this.ctrlNewBorrowOrNewReserve1.TabIndex = 0;
            this.ctrlNewBorrowOrNewReserve1.VisibleSetBorrowItem = false;
            this.ctrlNewBorrowOrNewReserve1.VisibleSetReserveItem = false;
            this.ctrlNewBorrowOrNewReserve1.OnSelectedBorrow += new System.Action<bool>(this.ctrlBookCopies1_OnSelectedBorrow);
            // 
            // frmNewBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 661);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcBorrowing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewBorrow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Borrow";
            this.Activated += new System.EventHandler(this.frmAddUpdateBorrow_Activated);
            this.Load += new System.EventHandler(this.frmNewBorrow_Load);
            this.tcBorrowing.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpBookCopiesInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorrowingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcBorrowing;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpBookCopiesInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Books.Controls.ctrlNewBorrowOrNewReserve ctrlNewBorrowOrNewReserve1;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBorrowID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBorrowingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBookCopyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPricePreDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.NumericUpDown nudBorrowingDays;
        private System.Windows.Forms.Label label2;
    }
}
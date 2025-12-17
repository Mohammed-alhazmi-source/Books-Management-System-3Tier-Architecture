namespace BMS.Reservations
{
    partial class frmNewReserve
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
            this.tcReservations = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpBookCopiesInfo = new System.Windows.Forms.TabPage();
            this.ctrlNewReserve1 = new BMS.Reservations.Controls.ctrlNewReserve();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReserveDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBookCopyID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReserveID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcReservations.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpBookCopiesInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(467, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Reserve";
            // 
            // tcReservations
            // 
            this.tcReservations.Controls.Add(this.tpPersonInfo);
            this.tcReservations.Controls.Add(this.tpBookCopiesInfo);
            this.tcReservations.Font = new System.Drawing.Font("Tahoma", 13F);
            this.tcReservations.Location = new System.Drawing.Point(12, 45);
            this.tcReservations.Name = "tcReservations";
            this.tcReservations.SelectedIndex = 0;
            this.tcReservations.Size = new System.Drawing.Size(1053, 615);
            this.tcReservations.TabIndex = 1;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPersonInfo.Controls.Add(this.btnClose);
            this.tpPersonInfo.Controls.Add(this.btnNextTab);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 30);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1045, 581);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(673, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(828, 499);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(149, 37);
            this.btnNextTab.TabIndex = 1;
            this.btnNextTab.Text = "Next";
            this.btnNextTab.UseVisualStyleBackColor = true;
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(42, 105);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(958, 368);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnSelectedPerson);
            // 
            // tpBookCopiesInfo
            // 
            this.tpBookCopiesInfo.BackColor = System.Drawing.Color.White;
            this.tpBookCopiesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBookCopiesInfo.Controls.Add(this.ctrlNewReserve1);
            this.tpBookCopiesInfo.Controls.Add(this.groupBox1);
            this.tpBookCopiesInfo.Location = new System.Drawing.Point(4, 30);
            this.tpBookCopiesInfo.Name = "tpBookCopiesInfo";
            this.tpBookCopiesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookCopiesInfo.Size = new System.Drawing.Size(1045, 581);
            this.tpBookCopiesInfo.TabIndex = 1;
            this.tpBookCopiesInfo.Text = "Book Copies Info";
            // 
            // ctrlNewReserve1
            // 
            this.ctrlNewReserve1.BackColor = System.Drawing.Color.White;
            this.ctrlNewReserve1.Font = new System.Drawing.Font("Sitka Small Semibold", 7F);
            this.ctrlNewReserve1.Location = new System.Drawing.Point(-47, -18);
            this.ctrlNewReserve1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlNewReserve1.Name = "ctrlNewReserve1";
            this.ctrlNewReserve1.Size = new System.Drawing.Size(1106, 494);
            this.ctrlNewReserve1.TabIndex = 3;
            this.ctrlNewReserve1.OnSelectedReserve += new System.Action<bool>(this.ctrlNewReserve1_OnSelectedReserve);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblReserveDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBookCopyID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPersonID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblReserveID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(10, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserve Information";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BMS.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(708, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BMS.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(273, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(800, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(513, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(248, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(751, 65);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(45, 19);
            this.lblCreatedBy.TabIndex = 9;
            this.lblCreatedBy.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(611, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Created By:";
            // 
            // lblReserveDate
            // 
            this.lblReserveDate.AutoSize = true;
            this.lblReserveDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblReserveDate.ForeColor = System.Drawing.Color.Black;
            this.lblReserveDate.Location = new System.Drawing.Point(319, 65);
            this.lblReserveDate.Name = "lblReserveDate";
            this.lblReserveDate.Size = new System.Drawing.Size(45, 19);
            this.lblReserveDate.TabIndex = 7;
            this.lblReserveDate.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(160, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reserve Date:";
            // 
            // lblBookCopyID
            // 
            this.lblBookCopyID.AutoSize = true;
            this.lblBookCopyID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBookCopyID.ForeColor = System.Drawing.Color.Black;
            this.lblBookCopyID.Location = new System.Drawing.Point(843, 25);
            this.lblBookCopyID.Name = "lblBookCopyID";
            this.lblBookCopyID.Size = new System.Drawing.Size(45, 19);
            this.lblBookCopyID.TabIndex = 5;
            this.lblBookCopyID.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(687, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Copy ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(556, 26);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(45, 19);
            this.lblPersonID.TabIndex = 3;
            this.lblPersonID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(432, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Person ID:";
            // 
            // lblReserveID
            // 
            this.lblReserveID.AutoSize = true;
            this.lblReserveID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblReserveID.ForeColor = System.Drawing.Color.Black;
            this.lblReserveID.Location = new System.Drawing.Point(291, 25);
            this.lblReserveID.Name = "lblReserveID";
            this.lblReserveID.Size = new System.Drawing.Size(45, 19);
            this.lblReserveID.TabIndex = 1;
            this.lblReserveID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(160, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reserve ID:";
            // 
            // frmNewReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1077, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewReserve";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reserve";
            this.Activated += new System.EventHandler(this.frmNewReserve_Activated);
            this.Load += new System.EventHandler(this.frmNewReserve_Load);
            this.tcReservations.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpBookCopiesInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcReservations;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpBookCopiesInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReserveDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBookCopyID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReserveID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNextTab;
        private Controls.ctrlNewReserve ctrlNewReserve1;
    }
}
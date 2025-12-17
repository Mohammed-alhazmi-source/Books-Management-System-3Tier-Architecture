namespace BMS.Fines
{
    partial class frmNewFine
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
            this.components = new System.ComponentModel.Container();
            this.tcFines = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNextTab = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new BMS.People.Controls.ctrlPersonCardWithFilter();
            this.tpBorrowInfo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBorrowID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFineID = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlReleaseBorrowWithFilter1 = new BMS.Borrowing.Controls.ctrlReleaseBorrowWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFineFees = new System.Windows.Forms.Button();
            this.tcFines.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpBorrowInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFines
            // 
            this.tcFines.Controls.Add(this.tpPersonInfo);
            this.tcFines.Controls.Add(this.tpBorrowInfo);
            this.tcFines.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tcFines.Location = new System.Drawing.Point(0, 17);
            this.tcFines.Name = "tcFines";
            this.tcFines.SelectedIndex = 0;
            this.tcFines.Size = new System.Drawing.Size(1123, 626);
            this.tcFines.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPersonInfo.Controls.Add(this.btnNextTab);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 33);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1115, 589);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            // 
            // btnNextTab
            // 
            this.btnNextTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTab.Image = global::BMS.Properties.Resources.Next_32;
            this.btnNextTab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextTab.Location = new System.Drawing.Point(960, 531);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(147, 41);
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
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(77, 73);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(958, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnSelectedPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnSelectedPerson);
            // 
            // tpBorrowInfo
            // 
            this.tpBorrowInfo.BackColor = System.Drawing.Color.White;
            this.tpBorrowInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBorrowInfo.Controls.Add(this.groupBox1);
            this.tpBorrowInfo.Controls.Add(this.ctrlReleaseBorrowWithFilter1);
            this.tpBorrowInfo.Location = new System.Drawing.Point(4, 33);
            this.tpBorrowInfo.Name = "tpBorrowInfo";
            this.tpBorrowInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBorrowInfo.Size = new System.Drawing.Size(1115, 589);
            this.tpBorrowInfo.TabIndex = 1;
            this.tpBorrowInfo.Text = "Borrow Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFineAmount);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBorrowID);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPersonID);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFineID);
            this.groupBox1.Controls.Add(this.pictureBox12);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(32, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fine Information";
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFineAmount.Location = new System.Drawing.Point(301, 72);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(122, 32);
            this.txtFineAmount.TabIndex = 49;
            this.txtFineAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineAmount_KeyPress);
            this.txtFineAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineAmount_Validating);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(915, 75);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(51, 22);
            this.lblCreatedBy.TabIndex = 48;
            this.lblCreatedBy.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(765, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(135, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fine Amount:";
            // 
            // lblBorrowID
            // 
            this.lblBorrowID.AutoSize = true;
            this.lblBorrowID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblBorrowID.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowID.Location = new System.Drawing.Point(915, 31);
            this.lblBorrowID.Name = "lblBorrowID";
            this.lblBorrowID.Size = new System.Drawing.Size(51, 22);
            this.lblBorrowID.TabIndex = 44;
            this.lblBorrowID.Text = "[???]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(872, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(773, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Borrow ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(576, 31);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(51, 22);
            this.lblPersonID.TabIndex = 41;
            this.lblPersonID.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(533, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(440, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Person ID:";
            // 
            // lblFineID
            // 
            this.lblFineID.AutoSize = true;
            this.lblFineID.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblFineID.ForeColor = System.Drawing.Color.Black;
            this.lblFineID.Location = new System.Drawing.Point(145, 31);
            this.lblFineID.Name = "lblFineID";
            this.lblFineID.Size = new System.Drawing.Size(51, 22);
            this.lblFineID.TabIndex = 38;
            this.lblFineID.Text = "[???]";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::BMS.Properties.Resources.money_32;
            this.pictureBox12.Location = new System.Drawing.Point(256, 72);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(38, 31);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 37;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::BMS.Properties.Resources.User_32__2;
            this.pictureBox9.Location = new System.Drawing.Point(871, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(38, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 28;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(102, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fine ID:";
            // 
            // ctrlReleaseBorrowWithFilter1
            // 
            this.ctrlReleaseBorrowWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlReleaseBorrowWithFilter1.FilterEnabled = true;
            this.ctrlReleaseBorrowWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlReleaseBorrowWithFilter1.Location = new System.Drawing.Point(-8, 6);
            this.ctrlReleaseBorrowWithFilter1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlReleaseBorrowWithFilter1.Name = "ctrlReleaseBorrowWithFilter1";
            this.ctrlReleaseBorrowWithFilter1.Size = new System.Drawing.Size(1129, 463);
            this.ctrlReleaseBorrowWithFilter1.TabIndex = 0;
            this.ctrlReleaseBorrowWithFilter1.VisibleLinkFineFees = false;
            this.ctrlReleaseBorrowWithFilter1.VisibleMessageUser = false;
            this.ctrlReleaseBorrowWithFilter1.OnSelectedBorrow += new System.Action<int>(this.ctrlReleaseBorrowWithFilter1_OnSelectedBorrow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(484, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fine Fees";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnClose.Image = global::BMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(778, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnFineFees
            // 
            this.btnFineFees.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFineFees.Enabled = false;
            this.btnFineFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFineFees.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnFineFees.Image = global::BMS.Properties.Resources.Release_Detained_License_32;
            this.btnFineFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFineFees.Location = new System.Drawing.Point(931, 649);
            this.btnFineFees.Name = "btnFineFees";
            this.btnFineFees.Size = new System.Drawing.Size(188, 41);
            this.btnFineFees.TabIndex = 3;
            this.btnFineFees.Text = "Fine Fees";
            this.btnFineFees.UseVisualStyleBackColor = true;
            this.btnFineFees.Click += new System.EventHandler(this.btnFineFees_Click);
            // 
            // frmNewFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1129, 705);
            this.Controls.Add(this.btnFineFees);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcFines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewFine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Fine";
            this.Activated += new System.EventHandler(this.frmNewFine_Activated);
            this.Load += new System.EventHandler(this.frmNewFine_Load);
            this.tcFines.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpBorrowInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcFines;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpBorrowInfo;
        private Borrowing.Controls.ctrlReleaseBorrowWithFilter ctrlReleaseBorrowWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextTab;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBorrowID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFineID;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnFineFees;
    }
}
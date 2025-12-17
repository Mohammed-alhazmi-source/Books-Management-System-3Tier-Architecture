namespace BMS.Reservations.Controls
{
    partial class ctrlReserveCardWithFilter
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
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.txtBookCopyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValueFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlReserveCard1 = new BMS.Reservations.Controls.ctrlReserveCard();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtBookCopyID);
            this.gbFilters.Controls.Add(this.label2);
            this.gbFilters.Controls.Add(this.txtValueFilter);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Font = new System.Drawing.Font("Tahoma", 13F);
            this.gbFilters.ForeColor = System.Drawing.Color.DimGray;
            this.gbFilters.Location = new System.Drawing.Point(24, 24);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(1060, 100);
            this.gbFilters.TabIndex = 3;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // txtBookCopyID
            // 
            this.txtBookCopyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCopyID.Location = new System.Drawing.Point(769, 39);
            this.txtBookCopyID.Name = "txtBookCopyID";
            this.txtBookCopyID.Size = new System.Drawing.Size(130, 28);
            this.txtBookCopyID.TabIndex = 4;
            this.txtBookCopyID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookCopyID_KeyPress);
            this.txtBookCopyID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookCopyID_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(659, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Copy ID:";
            // 
            // txtValueFilter
            // 
            this.txtValueFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueFilter.Location = new System.Drawing.Point(321, 40);
            this.txtValueFilter.Name = "txtValueFilter";
            this.txtValueFilter.Size = new System.Drawing.Size(263, 28);
            this.txtValueFilter.TabIndex = 2;
            this.txtValueFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueFilter_KeyPress);
            this.txtValueFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtValueFilter_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Title",
            "ISBN",
            "Book ID",
            "Reserve ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(118, 39);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(197, 29);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::BMS.Properties.Resources.search_30px;
            this.btnFind.Location = new System.Drawing.Point(976, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 52);
            this.btnFind.TabIndex = 5;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlReserveCard1
            // 
            this.ctrlReserveCard1.BackColor = System.Drawing.Color.White;
            this.ctrlReserveCard1.Location = new System.Drawing.Point(65, 130);
            this.ctrlReserveCard1.Name = "ctrlReserveCard1";
            this.ctrlReserveCard1.Size = new System.Drawing.Size(979, 328);
            this.ctrlReserveCard1.TabIndex = 4;
            // 
            // ctrlReserveCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlReserveCard1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlReserveCardWithFilter";
            this.Size = new System.Drawing.Size(1108, 471);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBookCopyID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValueFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private ctrlReserveCard ctrlReserveCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

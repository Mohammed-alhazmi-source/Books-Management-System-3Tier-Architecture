using BMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BMS.Reservations.Controls
{
    public partial class ctrlReserveCardWithFilter : UserControl
    {
        public int ReserveID => ctrlReserveCard1.ReserveID;

        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get { return _FilterEnable; }
            set
            {
                _FilterEnable = value;
                gbFilters.Enabled = _FilterEnable;
            }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value;}
        }

        public event Action<int> OnSelectedReserve;

        public clsReserve SelectedReserveInfo => ctrlReserveCard1.SelectedReserveInfo;

        public void txtFilterFocus()          => txtValueFilter.Focus();
        public void txtBookCopyIDFocus()      => txtBookCopyID.Focus();

        public void LoadReserveInfo(int ReserveID)
        {
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Reserve ID");
            txtValueFilter.Text = ReserveID.ToString();
            ctrlReserveCard1.LoadReserveInfo(ReserveID);

            if(ctrlReserveCard1.SelectedReserveInfo != null)
            {
                txtBookCopyID.Text = ctrlReserveCard1.SelectedReserveInfo.BookCopyID.ToString();
                return;
            }

            txtBookCopyID.Text = "N/A";

        }

        public ctrlReserveCardWithFilter()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("ISBN");
        }

        public override bool ValidateChildren()
        {
            bool IsValid = true;

            if(string.IsNullOrEmpty(txtValueFilter.Text))
            {
                txtValueFilter_Validating(txtValueFilter, null);
                IsValid = false;
            }
            
            if(string.IsNullOrEmpty(txtBookCopyID.Text))
            {
                txtBookCopyID_Validating(txtBookCopyID, null);
                IsValid = false;
            }

            return IsValid;
        }

        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
                errorProvider1.SetError(Temp, "This Filed Is Required");
            else
                errorProvider1.SetError(Temp, null);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            switch (cbFilterBy.Text)
            {
                case "ISBN":
                    ctrlReserveCard1.LoadReserveInfoByISBNAndBookCopyID(txtValueFilter.Text, Convert.ToInt32(txtBookCopyID.Text), _PersonID);
                    break;

                case "Title":
                    ctrlReserveCard1.LoadReserveInfoByTitleAndBookCopyID(txtValueFilter.Text, Convert.ToInt32(txtBookCopyID.Text), _PersonID);
                    break;

                case "Book ID":
                    ctrlReserveCard1.LoadReserveInfoByBookIDAndBookCopyID(Convert.ToInt32(txtValueFilter.Text), Convert.ToInt32(txtBookCopyID.Text), _PersonID);
                    break;

                case "Reserve ID":
                    LoadReserveInfo(Convert.ToInt32(txtValueFilter.Text));
                    break;
            }

            if (OnSelectedReserve != null && FilterEnable)
                OnSelectedReserve(ctrlReserveCard1.ReserveID);
        }

        private void txtValueFilter_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmptyTextBox(sender, e);
        }

        private void txtBookCopyID_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmptyTextBox(sender, e);
        }

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();
        }

        private void txtBookCopyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValueFilter.Clear();
        }
    }
}
using BMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BMS.Borrowing.Controls
{
    public partial class ctrlReleaseBorrowWithFilter : UserControl
    {
        public event Action<int> OnSelectedBorrow;

        public int BorrowID => ctrlBorrowCard1.BorrowID;
        public clsBorrow SelectedBorrowInfo => ctrlBorrowCard1.SelectedBorrowInfo;

        public bool VisibleLinkFineFees
        {
            get { return ctrlBorrowCard1.VisibleLinkFineFees; }
            set { ctrlBorrowCard1.VisibleLinkFineFees = value; }
        }

        public bool IsBorrowLate => ctrlBorrowCard1.IsLate;

        public bool VisibleMessageUser
        {
            get { return ctrlBorrowCard1.VisibleMessageUser; }
            set { ctrlBorrowCard1.VisibleMessageUser = value; }
        }

        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
                errorProvider1.SetError(Temp, "This Filed Is Required");

            else
                errorProvider1.SetError(Temp, null);
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

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set 
            { 
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public void txtFilterValue() => txtValueFilter.Focus();
        public void txtCopyID() => txtBookCopyID.Focus();

        public void LoadBorrowInfo(int BorrowID)
        {            
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("Borrow ID");
            txtValueFilter.Text = BorrowID.ToString();
            txtBookCopyID.Text = "0";
            btnFind.PerformClick();
        }

        public ctrlReleaseBorrowWithFilter()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("ISBN");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            switch (cbFilterBy.Text)
            {
                case "Title":
                    ctrlBorrowCard1.LoadBorrowInfoByTitleAndCopyID(txtValueFilter.Text.Trim(), Convert.ToInt32(txtBookCopyID.Text));
                    break;

                case "ISBN":
                    ctrlBorrowCard1.LoadBorrowInfoByISBNAndCopyID(txtValueFilter.Text.Trim(), Convert.ToInt32(txtBookCopyID.Text));
                    break;

                case "Book ID":
                    ctrlBorrowCard1.LoadBorrowInfoByBookIDAndCopyID(Convert.ToInt32(txtValueFilter.Text.Trim()), Convert.ToInt32(txtBookCopyID.Text));
                    break;

                case "Borrow ID":
                    ctrlBorrowCard1.LoadBorrowInfo(Convert.ToInt32(txtValueFilter.Text.Trim()));
                    txtBookCopyID.Text = ctrlBorrowCard1.BookCopyID.ToString();
                    break;
            }

            if (OnSelectedBorrow != null && FilterEnabled)
                OnSelectedBorrow(ctrlBorrowCard1.BorrowID);
        }

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();

            if (cbFilterBy.Text == "Book ID" || cbFilterBy.Text == "Borrow ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtBookCopyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();

            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtValueFilter_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmptyTextBox(sender, e);
        }

        private void txtBookCopyID_Validating(object sender, CancelEventArgs e)
        {
            _ValidateEmptyTextBox(sender, e);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValueFilter.Clear();
        }
    }
}
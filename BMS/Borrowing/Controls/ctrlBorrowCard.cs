using BMS.Fines;
using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Borrowing.Controls
{
    public partial class ctrlBorrowCard : UserControl
    {
        private int _BorrowID = -1;
        public int BorrowID => _BorrowID;

        private int _BookCopyID = -1;
        public int BookCopyID => _BookCopyID;

        private bool _VisibleMessageUser = false;
        public bool VisibleMessageUser
        {
            get { return _VisibleMessageUser; }
            set 
            {
                _VisibleMessageUser = value;
                lblMessageUser.Visible = _VisibleMessageUser;
            }
        }

        private bool _VisibleLinkFineFees = false;
        public bool VisibleLinkFineFees
        {
            get { return _VisibleLinkFineFees; }
            set
            {
                _VisibleLinkFineFees = value;
                llAddFine.Visible = _VisibleLinkFineFees;
            }
        }

        private bool _IsLate = false;
        public bool IsLate
        {
            get { return _IsLate; }
        }

        private clsBorrow _Borrow = null;
        public clsBorrow SelectedBorrowInfo => _Borrow;

        private void _ResetDefaultValues()
        {
            lblBorrowID.Text = "[???]";
            lblPersonName.Text = "N/A";
            lblBookName.Text = "[???]";
            lblBookCopyID.Text = "[???]";
            lblBorrowingDate.Text = "[???]";
            lblDueDate.Text = "[???]";
            lblActualReturnDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblReleasedBy.Text = "[???]";
            lblPricePreDay.Text = "[$$$]";
            lblBorrowingDays.Text = "[???]";
            lblTotalPrice.Text = "[$$$]";
            lblIsBorrowed.Text = "N/A";
            lblIsLate.Text = "N/A";
            lblPriceAfterReturned.Text = "[$$$]";
        }

        private void _FillBorrowInfoInControls()
        {
            _BookCopyID = _Borrow.BookCopyID;
            _BorrowID = _Borrow.BorrowID;
            lblBorrowID.Text = _Borrow.BorrowID.ToString();
            lblPersonName.Text = _Borrow.PersonInfo.FullName;
            lblBookName.Text = _Borrow.BookCopyInfo.Title;
            lblBookCopyID.Text = _Borrow.BookCopyID.ToString();
            lblBorrowingDate.Text = clsFormat.DateToString(_Borrow.BorrowingDate);
            lblDueDate.Text = clsFormat.DateToString(_Borrow.DueDate);
            lblActualReturnDate.Text = _Borrow.ActualReturnDate == new DateTime(1, 1, 1) ? "N/A" : clsFormat.DateToString(_Borrow.ActualReturnDate);
            lblCreatedBy.Text = _Borrow.CreateUserInfo.UserName;
            lblReleasedBy.Text = _Borrow.ReleaseUserInfo == null ? "[???]" : _Borrow.ReleaseUserInfo.UserName;
            lblPricePreDay.Text = ((int)clsSetting.GetDefaultPricePreDay()).ToString();
            short BorrowingDays = (short)(_Borrow.DueDate.Day - _Borrow.BorrowingDate.Day);
            lblBorrowingDays.Text = BorrowingDays.ToString();           
            lblIsBorrowed.Text = _Borrow.IsActive ? "No" : "Yes";
            _IsLate =  _Borrow.ActualReturnDate > _Borrow.DueDate ? true : false;
            lblIsLate.Text = _Borrow.ActualReturnDate == new DateTime(1, 1, 1) ? "Unknow" : _IsLate ? "Yes" : "No";
            lblTotalPrice.Text = ((int)clsSetting.GetDefaultPricePreDay() * BorrowingDays).ToString();

            lblPriceAfterReturned.Text = _IsLate ? ((int)(_Borrow.ActualReturnDate.Day - _Borrow.DueDate.Day) *  clsSetting.GetDefaultPricePreDay()).ToString() : "0";
            llAddFine.Visible = _IsLate;
            lblMessageUser.Visible = _Borrow.IsActive;
        }

        public void LoadBorrowInfo(int BorrowID)
        {
            _BorrowID = BorrowID;
            _Borrow = clsBorrow.Find(_BorrowID);

            if(_Borrow == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Borrow With ID = {_BorrowID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BorrowID = -1;
                return;
            }

            _FillBorrowInfoInControls();
        }

        public void LoadBorrowInfoByBookIDAndCopyID(int BookID, int BookCopyID)
        {
            _Borrow = clsBorrow.FindByBookIDAndCopyID(BookID, BookCopyID);

            if (_Borrow == null)
            {
                _ResetDefaultValues();
                //MessageBox.Show($"Not Found Borrow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BorrowID = -1;
                return;
            }

            _FillBorrowInfoInControls();
        }

        public void LoadBorrowInfoByISBNAndCopyID(string ISBN, int BookCopyID)
        {
            _Borrow = clsBorrow.FindByISBNAndCopyID(ISBN, BookCopyID);

            if (_Borrow == null)
            {
                _ResetDefaultValues();
                //MessageBox.Show($"Not Found Borrow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BorrowID = -1;
                return;
            }

            _FillBorrowInfoInControls();
        }

        public void LoadBorrowInfoByTitleAndCopyID(string Title, int BookCopyID)
        {
            _Borrow = clsBorrow.FindByTitleAndCopyID(Title, BookCopyID);

            if (_Borrow == null)
            {
                _ResetDefaultValues();
                //MessageBox.Show($"Not Found Borrow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BorrowID = -1;
                return;
            }

            _FillBorrowInfoInControls();
        }


        public ctrlBorrowCard()
        {
            InitializeComponent();
        }

        private void llAddFine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Borrow == null)
                return;

            frmNewFine newFine = new frmNewFine(_Borrow.BorrowID, _Borrow.PersonID);
            newFine.OnFineFees += NewFine_OnFineFees;
            newFine.ShowDialog();
        }

        private void NewFine_OnFineFees()
        {
            llAddFine.Visible = false;
        }
    }
}
using BMS.Books;
using BMS.Books.BookCopies;
using BMS.Books_Authors;
using BMS.Fines;
using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Borrowing
{
    public partial class frmReleaseBorrow : Form
    {
        private int _BorrowID = -1;

        public event Action OnReleased;

        public frmReleaseBorrow()
        {
            InitializeComponent();
        }

        public frmReleaseBorrow(int BorrowID)
        {
            InitializeComponent();
            _BorrowID = BorrowID;
        }

        private void frmReleaseBorrow_Load(object sender, EventArgs e)
        {
            if(_BorrowID == -1)
            {
                ctrlReleaseBorrowWithFilter1.FilterEnabled = true;
            }

            else
            {
                ctrlReleaseBorrowWithFilter1.LoadBorrowInfo(_BorrowID);
                ctrlReleaseBorrowWithFilter1.FilterEnabled = false;
            }
        }

        private void frmReleaseBorrow_Activated(object sender, EventArgs e)
        {
            ctrlReleaseBorrowWithFilter1.txtCopyID();
            ctrlReleaseBorrowWithFilter1.txtFilterValue();
        }

        private void ctrlReleaseBorrowWithFilter1_OnSelectedBorrow(int BorrowID)
        {
            _BorrowID = BorrowID;

            if(_BorrowID == -1)
            {
                btnRelease.Enabled = false;
                llShowBookCopies.Enabled = false;
                llShowAuthorsBook.Enabled = false;
                llShowBorrowInfo.Enabled = false;
                ctrlReleaseBorrowWithFilter1.VisibleMessageUser = false;
                ctrlReleaseBorrowWithFilter1.txtFilterValue();
                return;
            }

            if (clsFine.IsPersonFineFeesToBorrow(ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.PersonID, _BorrowID))
            {
                ctrlReleaseBorrowWithFilter1.VisibleLinkFineFees = false;
                MessageBox.Show("This Borrow Is Fine Fees", "Fined Fees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.IsActive)
            {                
                btnRelease.Enabled = false;
                llShowBookCopies.Enabled = true;
                llShowAuthorsBook.Enabled = true;
                llShowBorrowInfo.Enabled = false;
                ctrlReleaseBorrowWithFilter1.txtFilterValue();
                return;
            }


            btnRelease.Enabled = true;
            llShowBookCopies.Enabled = true;
            llShowAuthorsBook.Enabled = true;
            ctrlReleaseBorrowWithFilter1.txtFilterValue();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.ActualReturnDate = DateTime.Now;
            ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.IsActive = true;
            ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.ReleaseByUserID = clsGlobal.CurrentUser.UserID;

            if(ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRelease.Enabled = false;
                llShowBorrowInfo.Enabled = true;
                ctrlReleaseBorrowWithFilter1.FilterEnabled = false;

                if (ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.ActualReturnDate > ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.DueDate)
                {
                    MessageBox.Show("عليك غرامة بسبب تاريخ تسليم الاستعارة", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    llAddFine.Visible = true;
                    return;
                }

                llAddFine.Visible = false;
                OnReleased?.Invoke();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llAddFine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo == null)
                return;

            frmNewFine newFine = new frmNewFine(ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.BorrowID,
                ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.PersonID);
            newFine.ShowDialog();
        }

        private void llShowAuthorsBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowAuthorsBookHistory authorsBookHistory = new frmShowAuthorsBookHistory(ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.BookCopyInfo.BookID);
            authorsBookHistory.ShowDialog();
        }

        private void llShowBookCopies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBookCopiesHistory bookCopiesHistory = new frmBookCopiesHistory(ctrlReleaseBorrowWithFilter1.SelectedBorrowInfo.BookCopyInfo.BookID);
            bookCopiesHistory.ShowDialog();
        }

        private void llShowBorrowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBorrowInfo showBorrowInfo = new frmShowBorrowInfo(_BorrowID);
            showBorrowInfo.ShowDialog();
        }
    }
}
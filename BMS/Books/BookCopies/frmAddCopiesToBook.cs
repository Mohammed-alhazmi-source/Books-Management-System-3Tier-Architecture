using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Books.BookCopies
{
    public partial class frmAddCopiesToBook : Form
    {
        private int _BookID = -1;

        public frmAddCopiesToBook()
        {
            InitializeComponent();
            ctrlBookCardWithFilter1.FilterEnabled = true;
        }

        public frmAddCopiesToBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void frmAddCopiesToBook_Load(object sender, EventArgs e)
        {
            if(_BookID != -1)
            {
                ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
                ctrlBookCardWithFilter1.FilterEnabled = false;
            }
        }

        private void ctrlBookCardWithFilter1_OnSelectedBook(int BookID)
        {
            _BookID = BookID;

            if(_BookID == -1)
            {
                btnSave.Enabled = false;
                llShowBookCopiesHistory.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
            llShowBookCopiesHistory.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowBookCopiesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBookCopiesHistory bookCopiesHistory = new frmBookCopiesHistory(_BookID);
            bookCopiesHistory.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsBookCopy BookCopies  = new clsBookCopy();
            BookCopies.BookID = ctrlBookCardWithFilter1.SelectedBookInfo.BookID;
            BookCopies.BookCopiesCount = (int)nudCopiesCount.Value;
            BookCopies.IsActive = true;
            BookCopies.BookCopyName = ctrlBookCardWithFilter1.SelectedBookInfo.Title;

            if(BookCopies.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                llShowBookDetials.Enabled = true;
            }

            else
            {
                MessageBox.Show("Saved Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                llShowBookDetials.Enabled = false;
            }
        }

        private void llShowBookDetials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookInfo showBookInfo = new frmShowBookInfo(ctrlBookCardWithFilter1.SelectedBookInfo.BookID);
            showBookInfo.ShowDialog();
        }
    }
}
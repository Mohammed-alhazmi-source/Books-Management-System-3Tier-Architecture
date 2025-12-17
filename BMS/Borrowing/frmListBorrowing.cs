using BMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.Borrowing
{
    public partial class frmListBorrowing : Form
    {
        private DataView _BorrowingView;

        public frmListBorrowing()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _BorrowingView = clsBorrow.GetAllBorrowing().DefaultView;
            dgvBorrowing.DataSource = _BorrowingView;
            lblRecordsCount.Text = _BorrowingView.Count.ToString();
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Borrow ID": return BorrowID.Name;
                case "Book ID": return BookID.Name;
                case "Book Copy ID": return BookCopyID.Name;
                case "Book Name": return BookName.Name;
                case "Full Name": return BorrowedName.Name;
            }

            return "";
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                if (_BorrowingView != null)
                {
                    _BorrowingView.RowFilter = "";
                    lblRecordsCount.Text = _BorrowingView.Count.ToString();
                }
                return;
            }

            if(ColumnName == BorrowID.Name || ColumnName == BookID.Name || ColumnName == BookCopyID.Name)
            {
                if (_BorrowingView != null)
                {
                    _BorrowingView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                    lblRecordsCount.Text = _BorrowingView.Count.ToString();
                }
                return;
            }

            if (_BorrowingView != null)
            {
                _BorrowingView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _BorrowingView.Count.ToString();
            }
        }


        private void ReleaseBorrow_OnReleased() => _LoadData();

        private void NewBorrow_OnSavedBorrow() => _LoadData();

        private void frmListBorrowing_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
            cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");
        }

        private void ShowBorrowInfoItem_Click(object sender, EventArgs e)
        {
            frmShowBorrowInfo showBorrowInfo = new frmShowBorrowInfo((int)dgvBorrowing.CurrentRow.Cells[0].Value);
            showBorrowInfo.ShowDialog();
        }

        private void ReleaseBorrowItem_Click(object sender, EventArgs e)
        {
            frmReleaseBorrow releaseBorrow = new frmReleaseBorrow((int)dgvBorrowing.CurrentRow.Cells[0].Value);
            releaseBorrow.OnReleased += ReleaseBorrow_OnReleased;
            releaseBorrow.ShowDialog();
        }

        private void cmsBorrowing_Opening(object sender, CancelEventArgs e)
        {
            ReleaseBorrowItem.Enabled = !(bool)dgvBorrowing.CurrentRow.Cells["IsActive"].Value;
        }

        private void btnAddNewBorrow_Click(object sender, EventArgs e)
        {
            frmNewBorrow newBorrow = new frmNewBorrow();
            newBorrow.OnSavedBorrow += NewBorrow_OnSavedBorrow;
            newBorrow.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                cbFilterByActive.Visible = false;
                _BorrowingView.RowFilter = "";
                lblRecordsCount.Text = _BorrowingView.Count.ToString();
                return;
            }

            if(cbFilterBy.Text == "Is Active")
            {
                cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");
                txtFilterValue.Visible = false;
                cbFilterByActive.Visible = true;
                _BorrowingView.RowFilter = "";
                lblRecordsCount.Text = _BorrowingView.Count.ToString();
                return;
            }

            cbFilterByActive.Visible = false;
            txtFilterValue.Visible = true;
            _BorrowingView.RowFilter = "";
            lblRecordsCount.Text = _BorrowingView.Count.ToString();
            txtFilterValue.Clear();
        }

        private void cbFilterByActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterByActive.Text == "All")
            {
                if (_BorrowingView != null)
                {
                    _BorrowingView.RowFilter = "";
                    lblRecordsCount.Text = _BorrowingView.Count.ToString();
                }

                return;
            }

            if (_BorrowingView != null)
            {
                _BorrowingView.RowFilter = string.Format("[{0}] = {1}", IsActive.Name, cbFilterByActive.Text == "Yes" ? true : false);
                lblRecordsCount.Text = _BorrowingView.Count.ToString();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Book ID" || cbFilterBy.Text == "Borrow ID" || cbFilterBy.Text == "Book Copy ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            else
                e.Handled = char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
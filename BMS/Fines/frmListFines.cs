using BMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace BMS.Fines
{
    public partial class frmListFines : Form
    {
        private DataTable _FinesTable = null;
        private DataView _FinesView;

        public frmListFines()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _FinesTable = clsFine.GetAllFines();

            if (_FinesTable == null)
                return;

            _FinesView = _FinesTable.DefaultView;
            dgvFines.DataSource = _FinesView;

            if(_FinesView != null )
            {
                lblRecordsCount.Text = _FinesView.Count.ToString();
                return;
            }

            lblRecordsCount.Text = "0";
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Fine ID": return FineID.Name;
                case "Person ID": return PersonID.Name;
                case "Borrow ID": return BorrowID.Name;
                case "Full Name": return FullName.Name;
                case "Book Name": return BookName.Name;
                case "Book Copy ID": return BookCopyID.Name;
            }
            return "";
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                if(_FinesView != null)
                {
                    _FinesView.RowFilter = "";
                    lblRecordsCount.Text = _FinesView.Count.ToString();
                    return;
                }              
            }

            if (ColumnName == FineID.Name || ColumnName == PersonID.Name || ColumnName == BorrowID.Name 
                || ColumnName == BookCopyID.Name)
            {
                if (_FinesView != null)
                {
                    _FinesView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                    lblRecordsCount.Text = _FinesView.Count.ToString();
                    return;
                }
            }

            if (_FinesView != null)
            {
                _FinesView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _FinesView.Count.ToString();
                return;
            }
        }

        private void frmListFines_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                if (_FinesView != null)
                {
                    _FinesView.RowFilter = "";
                    lblRecordsCount.Text = _FinesView.Count.ToString();
                    return;
                }
                return;
            }

            txtFilterValue.Visible = true;
            if (_FinesView != null)
            {
                _FinesView.RowFilter = "";
                lblRecordsCount.Text = _FinesView.Count.ToString();
                return;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Fine ID" || cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Borrow ID" ||
                cbFilterBy.Text == "Book Copy ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void ShowFineInfoItem_Click(object sender, EventArgs e)
        {
            frmShowFineInfo showFineInfo = new frmShowFineInfo((int)dgvFines.CurrentRow.Cells["FineID"].Value);
            showFineInfo.ShowDialog();
        }

        private void btnAddFine_Click(object sender, EventArgs e)
        {
            frmNewFine newFine = new frmNewFine();
            newFine.OnFineFees += NewFine_OnFineFees;
            newFine.ShowDialog();
        }

        private void NewFine_OnFineFees()
        {
            _LoadData();
        }
    }
}
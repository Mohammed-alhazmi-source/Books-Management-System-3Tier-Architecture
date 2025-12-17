using BMS_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BMS.Reservations
{
    public partial class frmListReservations : Form
    {
        private DataView _ReservationsView;

        public frmListReservations()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _ReservationsView = clsReserve.GetAllReservations().DefaultView;
            dgvReservations.DataSource = _ReservationsView;

            if (_ReservationsView != null)
            {
                lblRecordsCount.Text = _ReservationsView.Count.ToString();
                return;
            }

            lblRecordsCount.Text = "0";
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                if (_ReservationsView != null)
                {
                    _ReservationsView.RowFilter = "";
                    lblRecordsCount.Text = _ReservationsView.Count.ToString();
                }
                return;
            }

            if(ColumnName == ReservationID.Name || ColumnName == BookCopyID.Name)
            {
                if (_ReservationsView != null)
                {
                    _ReservationsView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                    lblRecordsCount.Text = _ReservationsView.Count.ToString();
                }
                return;
            }

            if (_ReservationsView != null)
            {
                _ReservationsView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _ReservationsView.Count.ToString();
            }
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Reserve ID":   return ReservationID.Name;
                case "Full Name":    return FullName.Name;
                case "Book Name":    return BookName.Name;
                case "Book Copy ID": return BookCopyID.Name;
            }
            return "";
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {
            _LoadData();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
            cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");
        }

        private void btnAddReserve_Click(object sender, EventArgs e)
        {
            frmNewReserve newReserve = new frmNewReserve();
            newReserve.OnSavedReserved += NewReserve_OnSavedReserved;
            newReserve.ShowDialog();
        }

        private void NewReserve_OnSavedReserved()
        {
            _LoadData();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                cbFilterByActive.Visible = false;

                if (_ReservationsView != null)
                {
                    _ReservationsView.RowFilter = "";
                    lblRecordsCount.Text = _ReservationsView.Count.ToString();
                }
                return;
            }

            if(cbFilterBy.Text == "Is Reserved")
            {
                cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");

                txtFilterValue.Visible = false;
                cbFilterByActive.Visible = true;

                if (_ReservationsView != null)
                {
                    _ReservationsView.RowFilter = "";
                    lblRecordsCount.Text = _ReservationsView.Count.ToString();
                }
                return;
            }


            txtFilterValue.Clear();
            txtFilterValue.Visible = true;
            cbFilterByActive.Visible = false;

            if (_ReservationsView != null)
            {
                _ReservationsView.RowFilter = "";
                lblRecordsCount.Text = _ReservationsView.Count.ToString();
            }
        }

        private void cbFilterByActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterByActive.Text == "All")
            {
                if (_ReservationsView != null)
                {
                    _ReservationsView.RowFilter = "";
                    lblRecordsCount.Text = _ReservationsView.Count.ToString();
                }
                return;
            }

            if (_ReservationsView != null)
            {
                _ReservationsView.RowFilter = string.Format("[{0}] = {1}", ReservationStatus.Name, cbFilterByActive.Text == "Yes" ? true : false);
                lblRecordsCount.Text = _ReservationsView.Count.ToString();
            }
        }

        private void cmsReservations_Opening(object sender, CancelEventArgs e)
        {
            ReleaseReserveItem.Enabled = !(bool)dgvReservations.CurrentRow.Cells["ReservationStatus"].Value;
        }

        private void ShowReserveInfoItem_Click(object sender, EventArgs e)
        {
            frmShowReserveInfo showReserveInfo = new frmShowReserveInfo((int)dgvReservations.CurrentRow.Cells["ReservationID"].Value);
            showReserveInfo.ShowDialog();
        }

        private void ReleaseReserveItem_Click(object sender, EventArgs e)
        {
            frmReleaseReserve releaseReserve =
                new frmReleaseReserve(
                    (int)dgvReservations.CurrentRow.Cells["ReservationID"].Value,
                    (int)dgvReservations.CurrentRow.Cells["PersonID"].Value
                    );
            releaseReserve.OnReleasedReserve += ReleaseReserve_OnReleasedReserve;
            releaseReserve.ShowDialog();
        }

        private void ReleaseReserve_OnReleasedReserve()
        {
            _LoadData();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Reserve ID" || cbFilterBy.Text == "Book Copy ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }
    }
}
using BMS.Books;
using BMS.Books_Authors;
using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Reservations
{
    public partial class frmReleaseReserve : Form
    {
        private int _PersonID = -1;
        private int _ReserveID = -1;

        public event Action OnReleasedReserve;

        public frmReleaseReserve()
        {
            InitializeComponent();
        }

        public frmReleaseReserve(int ReserveID, int PersonID)
        {
            InitializeComponent();
            _ReserveID = ReserveID;
            _PersonID = PersonID;
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;

            if(_PersonID == -1)
            {
                ctrlReserveCardWithFilter1.PersonID = -1;
                ctrlPersonCardWithFilter1.txtValueFilterFocus();
                return;
            }


            ctrlReserveCardWithFilter1.PersonID = PersonID;
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmReleaseReserve_Load(object sender, EventArgs e)
        {

            if(_ReserveID == -1)
            {
                ctrlReserveCardWithFilter1.FilterEnable = true;
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                tpReserveInfo.Enabled = false;
            }

            else
            {
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                ctrlReserveCardWithFilter1.LoadReserveInfo(_ReserveID);
                ctrlReserveCardWithFilter1.FilterEnable = false;
                ctrlPersonCardWithFilter1.FilterEnabled = false;

                if(ctrlReserveCardWithFilter1.SelectedReserveInfo != null)
                {
                    llShowAuthorsBook.Enabled = true;
                    llShowBookCopies.Enabled = true;
                }
                tpReserveInfo.Enabled = true;
            }
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                tcReservations.SelectedTab = tcReservations.TabPages["tpReserveInfo"];
                tpReserveInfo.Enabled = true;
                ctrlReserveCardWithFilter1.txtFilterFocus();
                return;
            }

            MessageBox.Show("Please Select A Person,", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmReleaseReserve_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void ctrlReserveCardWithFilter1_OnSelectedReserve(int ReserveID)
        {
            _ReserveID = ReserveID;

            if(_ReserveID == -1)
            {
                btnRelease.Enabled = false;
                llShowAuthorsBook.Enabled = false;                
                llShowBookCopies.Enabled = false;
                return;
            }

            if(!ctrlReserveCardWithFilter1.SelectedReserveInfo.IsBookCopyReserved())
            {
                MessageBox.Show("Not Reserved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            btnRelease.Enabled = true;
            llShowAuthorsBook.Enabled = true;
            llShowBookCopies.Enabled = true;
            ctrlReserveCardWithFilter1.FilterEnable = true;
            ctrlReserveCardWithFilter1.txtFilterFocus();
        }

        private void llShowAuthorsBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowAuthorsBookHistory showAuthorsBookHistory =
                new frmShowAuthorsBookHistory(ctrlReserveCardWithFilter1.SelectedReserveInfo.BookInfo.BookID);
            showAuthorsBookHistory.ShowDialog();
        }

        private void llShowBookCopies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBookCopiesHistory bookCopiesHistory = 
                new frmBookCopiesHistory(ctrlReserveCardWithFilter1.SelectedReserveInfo.BookInfo.BookID);
            bookCopiesHistory.ShowDialog();
        }

        private void llShowReserveInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowReserveInfo showReserveInfo = new frmShowReserveInfo(_ReserveID);
            showReserveInfo.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ctrlReserveCardWithFilter1.SelectedReserveInfo.ReleaseReserveDate = DateTime.Now;
            ctrlReserveCardWithFilter1.SelectedReserveInfo.ReleasedByUserID = clsGlobal.CurrentUser.UserID;
            ctrlReserveCardWithFilter1.SelectedReserveInfo.ReserveStatus = true;

            if(ctrlReserveCardWithFilter1.SelectedReserveInfo.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRelease.Enabled = false;
                llShowReserveInfo.Enabled = true;
                ctrlReserveCardWithFilter1.FilterEnable = false;
                OnReleasedReserve?.Invoke();
                return;
            }

            MessageBox.Show("Not Saved Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRelease.Enabled = true;
            llShowReserveInfo.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
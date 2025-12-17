using BMS.GlobalClasses;
using System;
using System.Windows.Forms;

namespace BMS.Reservations
{
    public partial class frmNewReserve : Form
    {
        private int _PersonID = -1;

        public frmNewReserve()
        {
            InitializeComponent();
        }

        public event Action OnSavedReserved;     

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                tcReservations.SelectedTab = tcReservations.TabPages["tpBookCopiesInfo"];
                tpBookCopiesInfo.Enabled = true;
                ctrlNewReserve1.txtFilterFocus();
                tpBookCopiesInfo.Enabled = true;
                ctrlNewReserve1.PersonID = _PersonID;
                lblPersonID.Text = ctrlPersonCardWithFilter1.PersonID.ToString();
                lblReserveDate.Text = clsFormat.DateToString(DateTime.Now);
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                return;
            }

            MessageBox.Show("Please Select A Person,", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmNewReserve_Load(object sender, EventArgs e)
        {
            tpBookCopiesInfo.Enabled = false;
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;

            if(_PersonID == -1)
            {
                tpBookCopiesInfo.Enabled = false;
                ctrlPersonCardWithFilter1.txtValueFilterFocus();
                return;
            }

            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmNewReserve_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ctrlNewReserve1_OnSelectedReserve(bool IsReserved)
        {
            if (IsReserved)
            {
                lblReserveID.Text = ctrlNewReserve1.SelectedReserveInfo.ReserveID.ToString();
                lblBookCopyID.Text = ctrlNewReserve1.SelectedReserveInfo.BookCopyID.ToString();
                OnSavedReserved?.Invoke();
                return;
            }

            lblReserveID.Text = "[???]";
            lblBookCopyID.Text = "[???]";
        }
    }
}
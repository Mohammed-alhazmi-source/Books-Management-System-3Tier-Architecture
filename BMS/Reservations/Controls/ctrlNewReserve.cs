using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BMS.Reservations.Controls
{
    public partial class ctrlNewReserve : UserControl
    {
        private int _BookID = -1;

        private clsReserve _Reserve = null;
        public clsReserve SelectedReserveInfo => _Reserve;

        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
            set {  _PersonID = value; }
        }

        public event Action<bool> OnSelectedReserve;

        public ctrlNewReserve()
        {
            InitializeComponent();
            SetReserveItem.Visible = false;
        }

        public void txtFilterFocus()
        {
            ctrlBookCardWithFilter1.txtFilterFocus();
        }

        private void _LoadBookInfo()
        {
            ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
        }

        private void _LoadBookCopiesInfo()
        {
            ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
        }

        public void LoadBookInfoWithCopies(int BookID)
        {
            _BookID = BookID;

            _LoadBookInfo();
            _LoadBookCopiesInfo();
        }

        private void cmsReservations_Opening(object sender, CancelEventArgs e)
        {
            SetReserveItem.Enabled = !ctrlBookCopiesHistory1.IsBookCopyActive && _PersonID != -1;
        }

        private void ctrlBookCardWithFilter1_OnSelectedBook(int BookID)
        {
            _BookID = BookID;

            if(_BookID == -1)
            {
                ctrlBookCopiesHistory1.Clear();
                ctrlBookCardWithFilter1.txtFilterFocus();
                SetReserveItem.Visible = false;
                return;
            }

            if (clsReserve.IsBookCopyReserved(_PersonID, ctrlBookCardWithFilter1.SelectedBookInfo.BookID))
            {
                MessageBox.Show("This Person Have Reserve To BookCopy One ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetReserveItem.Visible = false;
                return;
            }

            ctrlBookCopiesHistory1.Clear();
            SetReserveItem.Visible = true;
            SetReserveItem.Enabled = true;
            ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
            ctrlBookCardWithFilter1.txtFilterFocus();
        }

        private void SetReserveItem_Click(object sender, EventArgs e)
        {
            if (clsReserve.IsBookCopyReserved(_PersonID, ctrlBookCardWithFilter1.SelectedBookInfo.BookID))
            {
                MessageBox.Show("This Person Have Reserve To BookCopy One ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure Of Reserve To This BookCopy?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;

            _Reserve = new clsReserve();

            _Reserve.PersonID = _PersonID;
            _Reserve.BookCopyID = ctrlBookCopiesHistory1.GetBookCopyID;
            _Reserve.ReserveDate = DateTime.Now;
            _Reserve.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Reserve.Save())
            {
                MessageBox.Show($"The Book Copy Is Reserve Successfully With ReserveID = {_Reserve.ReserveID}", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (OnSelectedReserve != null)
                    OnSelectedReserve.Invoke(true);
            }
        }
    }
}
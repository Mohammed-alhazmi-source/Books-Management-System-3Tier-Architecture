using BMS.Books.Controls;
using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Borrowing
{
    public partial class frmNewBorrow : Form
    {
        private int _PersonID = -1;
        public event Action OnSavedBorrow;

        public frmNewBorrow()
        {
            InitializeComponent();
            tpBookCopiesInfo.Enabled = false;
        }

        private void frmNewBorrow_Load(object sender, EventArgs e)
        {
            ctrlNewBorrowOrNewReserve1.DueDate = DateTime.Now.AddDays((int)nudBorrowingDays.Value);
            lblTotalPrice.Text = ((int)clsSetting.GetDefaultPricePreDay() * (int)nudBorrowingDays.Value).ToString();
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                ctrlNewBorrowOrNewReserve1.PersonID = _PersonID;
                lblPersonID.Text = "[???]";
                return;
            }


            lblPersonID.Text = _PersonID.ToString();
            ctrlNewBorrowOrNewReserve1.PersonID = _PersonID;
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {          
            if (_PersonID != -1)
            {                
                tcBorrowing.SelectedTab = tcBorrowing.TabPages["tpBookCopiesInfo"];
                tpBookCopiesInfo.Enabled = true;
                ctrlNewBorrowOrNewReserve1.txtFilterFocus();
                tpBookCopiesInfo.Enabled = true;
                ctrlNewBorrowOrNewReserve1.VisibleSetBorrowItem = true;
                ctrlNewBorrowOrNewReserve1.VisibleSetReserveItem = false;
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                lblPricePreDay.Text = ((int)clsSetting.GetDefaultPricePreDay()).ToString();
                lblBorrowingDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
                return;
            }

            MessageBox.Show("Please Select A Person,", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmAddUpdateBorrow_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void ctrlBookCopies1_OnSelectedBorrow(bool IsBorrowed)
        {
            if (IsBorrowed)
            {
                lblBorrowID.Text = ctrlNewBorrowOrNewReserve1.SelectedBorrowInfo.BorrowID.ToString();
                lblDueDate.Text = ctrlNewBorrowOrNewReserve1.SelectedBorrowInfo.DueDate.ToString("dd/MMM/yyyy");
                lblBookCopyID.Text = ctrlNewBorrowOrNewReserve1.SelectedBorrowInfo.BookCopyID.ToString();                
                lblTotalPrice.Text = (Convert.ToInt32(lblPricePreDay.Text) * (ctrlNewBorrowOrNewReserve1.DueDate.Day - ctrlNewBorrowOrNewReserve1.SelectedBorrowInfo.BorrowingDate.Day)).ToString();
                OnSavedBorrow?.Invoke();
                return;
            }


            lblBorrowID.Text = "[???]";
            lblBookCopyID.Text = "[???]";
            lblDueDate.Text = "[???]";
        }

        private void nudBorrowingDays_ValueChanged(object sender, EventArgs e)
        {
            ctrlNewBorrowOrNewReserve1.DueDate = DateTime.Now.AddDays((int)nudBorrowingDays.Value);
            lblTotalPrice.Text = ((int)clsSetting.GetDefaultPricePreDay() * (int)nudBorrowingDays.Value).ToString();
        }
    }
}
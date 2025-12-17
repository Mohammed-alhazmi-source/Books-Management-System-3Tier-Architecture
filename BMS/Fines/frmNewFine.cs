using BMS.GlobalClasses;
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

namespace BMS.Fines
{
    public partial class frmNewFine : Form
    {
        private int _PersonID = -1;
        private int _BorrowID = -1;

        public event Action OnFineFees;


        public frmNewFine()
        {
            InitializeComponent();
        }

        public frmNewFine(int BorrowID, int PersonID)
        {
            InitializeComponent();
            _BorrowID = BorrowID;
            _PersonID = PersonID;
        }

        private void frmNewFine_Load(object sender, EventArgs e)
        {
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            if(_BorrowID == -1 || _PersonID == -1)
            {
                ctrlPersonCardWithFilter1.FilterEnabled = true;
                ctrlReleaseBorrowWithFilter1.FilterEnabled = true;
                return;
            }

            tcFines.SelectedTab = tcFines.TabPages[1];
            ctrlReleaseBorrowWithFilter1.LoadBorrowInfo(_BorrowID);
            ctrlReleaseBorrowWithFilter1.FilterEnabled = false;

            tcFines.SelectedTab = tcFines.TabPages[0];
            ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            tpBorrowInfo.Enabled = false;
        }

        public override bool ValidateChildren()
        {
            if(string.IsNullOrEmpty(txtFineAmount.Text))
            {
                txtFineAmount_Validating(txtFineAmount, null);
                return false;
            }

            return true;
        }

        private void ctrlReleaseBorrowWithFilter1_OnSelectedBorrow(int BorrowID)
        {
            _BorrowID = BorrowID;
            ctrlReleaseBorrowWithFilter1.VisibleLinkFineFees = false;
            ctrlReleaseBorrowWithFilter1.VisibleMessageUser = false;

            if(_BorrowID == -1)
            {
                btnFineFees.Enabled = false;
                lblBorrowID.Text = "[???]";
                lblFineID.Text = "[???]";
                txtFineAmount.Text = "";
                return;
            }

            lblBorrowID.Text = _BorrowID.ToString();

            if (!ctrlReleaseBorrowWithFilter1.IsBorrowLate)
            {
                btnFineFees.Enabled = false;
                errorProvider1.SetError(txtFineAmount, null);
                txtFineAmount.Enabled = false;
                return;
            }
            
            if(clsFine.IsPersonFineFeesToBorrow(_PersonID, _BorrowID))
            {
                btnFineFees.Enabled = false;
                txtFineAmount.Enabled = false;
                lblFineID.Text = clsFine.FindByPersonIDAndBorrowID(_PersonID, _BorrowID).FineID.ToString();
                MessageBox.Show("This Borrow Is Fine Fees", "Fined Fees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtFineAmount.Enabled = true;
            errorProvider1.SetError(txtFineAmount, "This Filed Is Required");
            btnFineFees.Enabled = true;
            ctrlReleaseBorrowWithFilter1.txtFilterValue();
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;

            if(_PersonID == -1)
            {
                lblPersonID.Text = "[???]";
                return;
            }

            lblPersonID.Text = _PersonID.ToString();
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                MessageBox.Show("Please Select A Person", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tpBorrowInfo.Enabled = false;
                return;
            }

            tcFines.SelectedTab = tcFines.TabPages["tpBorrowInfo"];
            tpBorrowInfo.Enabled = true;
            //txtFineAmount.Focus();
            ctrlReleaseBorrowWithFilter1.txtFilterValue();
        }

        private void txtFineAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtFineAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineAmount.Text))
                errorProvider1.SetError(txtFineAmount, "This Filed Is Required");

            else
                errorProvider1.SetError(txtFineAmount, null);
        }

        private void frmNewFine_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnFineFees_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            clsFine Fine = new clsFine();

            Fine.PersonID = ctrlPersonCardWithFilter1.PersonID;
            Fine.BorrowID = ctrlReleaseBorrowWithFilter1.BorrowID;
            Fine.FineAmount = Convert.ToDecimal(txtFineAmount.Text);
            Fine.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if(Fine.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblFineID.Text = Fine.FineID.ToString();
                txtFineAmount.ReadOnly = true;
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlReleaseBorrowWithFilter1.FilterEnabled = false;
                OnFineFees?.Invoke();
                return;
            }

            MessageBox.Show("Not Saved Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
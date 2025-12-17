using BMS_Business;
using System.Windows.Forms;

namespace BMS.Fines.Controls
{
    public partial class ctrlFindCard : UserControl
    {
        private int _FineID = -1;
        public int FineID => _FineID;

        private clsFine _Fine = null;
        public clsFine SelectedFineInfo => _Fine;

        private void _ResetDefaultValues()
        {
            lblFineID.Text = "[???]";
            lblPersonID.Text = "[???]";
            lblBorrowID.Text = "[???]";
            lblFineAmount.Text = "[$$$]";
            lblCreatedBy.Text = "[???]";
        }

        private void _FillFineInfoInControls()
        {
            ctrlPersonCard1.LoadPersonInfo(_Fine.PersonID);
            ctrlBorrowCard1.LoadBorrowInfo(_Fine.BorrowID);
            ctrlBorrowCard1.VisibleLinkFineFees = false;
            ctrlBorrowCard1.VisibleMessageUser = false;

            _FineID = _Fine.FineID;
            lblFineID.Text = _Fine.FineID.ToString();
            lblPersonID.Text = _Fine.PersonID.ToString();
            lblBorrowID.Text = _Fine.BorrowID.ToString();
            lblFineAmount.Text = ((int)_Fine.FineAmount).ToString();
            lblCreatedBy.Text = _Fine.UserInfo.UserName;
        }

        public void LoadFineInfo(int FineID)
        {
            _Fine = clsFine.Find(FineID);

            if(_Fine == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Fine With ID = {FineID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _FineID = -1;
                return;
            }

            _FillFineInfoInControls();
        }

        public ctrlFindCard()
        {
            InitializeComponent();
        }
    }
}
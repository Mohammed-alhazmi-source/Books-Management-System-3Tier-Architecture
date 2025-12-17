using BMS_Business;
using System.Windows.Forms;

namespace BMS.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID = -1;
        public int UserID => _UserID;

        private clsUser _User = null;
        public clsUser SelectedUserInfo => _User;

        public int PersonID => ctrlPersonCard1.PersonID;

        private void _ResetDefaultValues()
        {
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

        private void _FillUserInfoInControls()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

        public void LoadByUserID(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);

            if(_User == null)
            {
                _ResetDefaultValues();                
                MessageBox.Show($"No User With ID = {UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _UserID = -1;
                return;
            }

            _FillUserInfoInControls();
        }

        public void LoadByPersonID(int PersonID)
        {
            _User = clsUser.FindByPersonID(PersonID);

            if (_User == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Person With ID = {PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _UserID = -1;
                return;
            }

            _FillUserInfoInControls();
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }
    }
}
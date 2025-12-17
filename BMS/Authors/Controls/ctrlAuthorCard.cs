using BMS_Business;
using System.Windows.Forms;

namespace BMS.Authors.Controls
{
    public partial class ctrlAuthorCard : UserControl
    {
        private int _AuthorID = -1;
        public int AuthorID => _AuthorID;

        public int PersonID => ctrlPersonCard1.PersonID;
        public clsPerson SelectedPersonInfo => ctrlPersonCard1.SelectedPersonInfo;

        private clsAuthor _Author = null;
        public clsAuthor SelectedAuthorInfo => _Author;

        private void _ResetDefaultValues()
        {
            lblAuthorID.Text = "[???]";
            lblPersonID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        public void LoadAuthorInfoByID(int AuthorID)
        {
            _Author = clsAuthor.FindByAuthorID(AuthorID);

            if(_Author == null)
            {
                MessageBox.Show($"No Author With ID = {AuthorID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                ctrlPersonCard1.ShowLinkEditPersonInfo = false;
                _AuthorID = -1;
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(_Author.PersonID);
            lblAuthorID.Text = _Author.AuthorID.ToString();
            lblPersonID.Text = _Author.PersonID.ToString();
            lblCreatedBy.Text = _Author.UserInfo.UserName;
        }

        public void LoadAuthorInfoByPersonId(int PersonID)
        {
            _Author = clsAuthor.FindByPersonID(PersonID);

            if (_Author == null)
            {
                MessageBox.Show($"No Author With ID = {PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                ctrlPersonCard1.ShowLinkEditPersonInfo = false;
                _AuthorID = -1;
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(_Author.PersonID);
            lblAuthorID.Text = _Author.AuthorID.ToString();
            lblPersonID.Text = _Author.PersonID.ToString();
            lblCreatedBy.Text = _Author.UserInfo.UserName;
        }

        public ctrlAuthorCard()
        {
            InitializeComponent();
        }
    }
}
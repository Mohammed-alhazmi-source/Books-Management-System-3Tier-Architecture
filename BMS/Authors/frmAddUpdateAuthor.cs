using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Authors
{
    public partial class frmAddUpdateAuthor : Form
    {
        private clsEnums.enMode _Mode = clsEnums.enMode.Add;
        private int _PersonID = -1;
        private clsAuthor _Author = null;
        public event Action DataBack;

        public frmAddUpdateAuthor()
        {
            InitializeComponent();
            _Mode = clsEnums.enMode.Add;
        }

        public frmAddUpdateAuthor(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = clsEnums.enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == clsEnums.enMode.Add)
            {
                lblTitle.Text = "Add New Author";
                _Author = new clsAuthor();
            }
            else
                lblTitle.Text = "Update Author";

            lblAuthorID.Text = "[???]";
            lblPersonID.Text = "[???]";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void _LoadAuthorInfo()
        {
            _Author = clsAuthor.FindByPersonID(_PersonID);

            if(_Author == null)
            {
                MessageBox.Show("No Author With ID = " + _PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            lblAuthorID.Text = _Author.AuthorID.ToString();
            lblPersonID.Text = _Author.PersonID.ToString();
            lblCreatedBy.Text = _Author.UserInfo.UserName;
        }

        private void frmAddUpdateAuthor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == clsEnums.enMode.Update)
                _LoadAuthorInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Author.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Author.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Author.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAuthorID.Text = _Author.AuthorID.ToString();
                _Mode = clsEnums.enMode.Update;
                lblTitle.Text = "Update Author";
                DataBack?.Invoke();
            }
            
            else
                MessageBox.Show("Saved Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                btnSave.Enabled = false;
                ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = false;
                lblPersonID.Text = "[???]";
                return;
            }

            ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = true;
            lblPersonID.Text = _PersonID.ToString();

            if (clsAuthor.IsAuthorExistForPerson(_PersonID))
            {
                btnSave.Enabled = false;
                //MessageBox.Show("Selected Person Already Has A Author, Choose Another One.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsGlobal.CurrentUser.PersonInfo.PersonID == _PersonID)
            {
                btnSave.Enabled = false;
                MessageBox.Show("Selected Person Has A User, Choose Another One.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSave.Enabled = true;
        }

        private void frmAddUpdateAuthor_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
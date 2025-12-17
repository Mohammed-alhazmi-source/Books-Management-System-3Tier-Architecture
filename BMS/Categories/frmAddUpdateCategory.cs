using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BMS.Categories
{
    public partial class frmAddUpdateCategory : Form
    {
        private clsEnums.enMode _Mode = clsEnums.enMode.Add;
        private int _CategoryID = -1;
        private clsCategory _Category = null;

        public event Action DataBack;

        public frmAddUpdateCategory()
        {
            InitializeComponent();
            _Mode = clsEnums.enMode.Add;
        }

        public frmAddUpdateCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            _Mode = clsEnums.enMode.Update;
        }

        private void _Visible(bool Value)
        {
            lblCreatedBy.Visible = Value;
            pbUser.Visible = Value;
            lblCreatedBy.Visible = Value;
            lblControlCreatedBy.Visible = Value;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == clsEnums.enMode.Add)
            {
                lblTitle.Text = "Add New Category";
                lblCategoryID.Text = "[???]";
                _Visible(false);
                _Category = new clsCategory();
            }

            else
            {
                _Visible(true);
                lblTitle.Text = "Update Category";
            }

            txtCategoryName.Text = "";
            ckbIsActive.Checked = true;
        }

        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
                errorProvider1.SetError(txtCategoryName, "This Filed Is Required");

            else
                errorProvider1.SetError(txtCategoryName, null);
        }

        public override bool ValidateChildren()
        {
            if(string.IsNullOrEmpty(txtCategoryName.Text))
            {
                txtCategoryName_Validating(txtCategoryName, null);
                return false;
            }

            return true;
        }

        private void _ValidateCategoryName(CancelEventArgs e)
        {
            if (clsCategory.IsExist(txtCategoryName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCategoryName, "Category Name Is Used Another Category");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCategoryName, null);
            }
        }

        private void _LoadCategoryInfo()
        {
            _Category = clsCategory.Find(_CategoryID);

            if(_Category == null)
            {
                MessageBox.Show($"No Category With ID = {_CategoryID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            lblCategoryID.Text = _Category.CategoryID.ToString();
            txtCategoryName.Text = _Category.CategoryName;
            ckbIsActive.Checked = _Category.IsActive;
            lblCreatedBy.Text = _Category.UserInfo.UserName;
        }

        private void frmAddUpdateCategory_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == clsEnums.enMode.Update)
                _LoadCategoryInfo();
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                _ValidateEmptyTextBox(sender, e);
                return;
            }

            if (_Mode == clsEnums.enMode.Update && txtCategoryName.Text != _Category.CategoryName)
            {
                _ValidateCategoryName(e);
                return;
            }

            if (_Mode != clsEnums.enMode.Update)
                _ValidateCategoryName(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            _Category.CategoryName = txtCategoryName.Text.Trim();
            _Category.IsActive = ckbIsActive.Checked;
            _Category.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Category.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCategoryID.Text = _Category.CategoryID.ToString();

                _Mode = clsEnums.enMode.Update;
                lblTitle.Text = "Update Category";
                DataBack?.Invoke();
            }

            else
                MessageBox.Show("Saved Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateCategory_Activated(object sender, EventArgs e)
        {
            txtCategoryName.Focus();
            //txtCategoryName_Validating(txtCategoryName, null);
        }
    }
}
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Categories.Controls
{
    public partial class ctrlCategoryCard : UserControl
    {
        private int _CategoryID = -1;
        public int CategoryID => _CategoryID;

        private bool _LinkEnabled = true;
        public bool LinkEnabled
        {
            get { return _LinkEnabled; }
            set
            {
                _LinkEnabled = value;
                llEditCategoryInfo.Enabled = _LinkEnabled;
            }
        }

        private clsCategory _Category = null;
        public clsCategory SelectedCategoryInfo => _Category;

        public event Action OnEdit;

        private void _ResetDefaultValues()
        {
            lblCategoryID.Text = "[???]";
            lblCategoryName.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        public void LoadCategoryInfo(int CategoryID)
        {
            _Category = clsCategory.Find(CategoryID);

            if(_Category == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Category With ID = {CategoryID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _CategoryID = -1;
                llEditCategoryInfo.Enabled = false;
                return;
            }

            _CategoryID = CategoryID;
            llEditCategoryInfo.Enabled = true;
            lblCategoryID.Text = _Category.CategoryID.ToString();
            lblCategoryName.Text = _Category.CategoryName;
            lblIsActive.Text = _Category.IsActive ? "Yes" : "No";
            lblCreatedBy.Text = _Category.UserInfo.UserName;
        }

        public ctrlCategoryCard()
        {
            InitializeComponent();
        }

        private void llEditCategoryInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateCategory EditCategory = new frmAddUpdateCategory(_CategoryID);
            EditCategory.DataBack += EditCategory_DataBack;
            EditCategory.ShowDialog();
        }

        private void EditCategory_DataBack()
        {
            LoadCategoryInfo(_CategoryID);
            OnEdit?.Invoke();
        }
    }
}
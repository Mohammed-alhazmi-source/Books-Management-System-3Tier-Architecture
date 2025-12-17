using BMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace BMS.Categories
{
    public partial class frmListCategories : Form
    {
        private DataView _CategoriesView;
        private DataTable _dtCategories = null;

        public frmListCategories()
        {
            InitializeComponent();
        }       

        private void _LoadCategories()
        {
            _dtCategories = clsCategory.GetAllCategories();

            if(_dtCategories != null)
            {
                _CategoriesView = _dtCategories.DefaultView;
                dgvCategories.DataSource = _CategoriesView;
                lblRecordsCount.Text = _CategoriesView.Count.ToString();
            }
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                if (_CategoriesView != null)
                {
                    _CategoriesView.RowFilter = "";
                    lblRecordsCount.Text = _CategoriesView.Count.ToString();
                }
                return;
            }

            if(cbFilterBy.Text == "Category ID")
            {
                if (_CategoriesView != null)
                {
                    _CategoriesView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                    lblRecordsCount.Text = _CategoriesView.Count.ToString();
                }
                return;
            }

            if (_CategoriesView != null)
            {
                _CategoriesView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _CategoriesView.Count.ToString();
            }
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Category ID":   return CategoryID.Name;
                case "Category Name": return CategoryName.Name;
            }
            return "";
        }

        private void _Visible(bool ComboBox, bool TextBox)
        {
            cbFilterByActive.Visible = ComboBox;
            txtFilterValue.Visible = TextBox;
        }

        private void frmListCategories_Load(object sender, EventArgs e)
        {
            _LoadCategories();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
            cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");
        }

        private void Category_DataBack() => _LoadCategories();

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory AddCategory = new frmAddUpdateCategory();
            AddCategory.DataBack += Category_DataBack;
            AddCategory.ShowDialog();
        }

        private void ShowCategoryDetailsItem_Click(object sender, EventArgs e)
        {
            frmShowCategoryInfo showCategoryInfo = new frmShowCategoryInfo((int)dgvCategories.CurrentRow.Cells["CategoryID"].Value);
            showCategoryInfo.EditCategory += Category_DataBack;
            showCategoryInfo.ShowDialog();
        }

        private void AddNewCategoryItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory AddCategory = new frmAddUpdateCategory();
            AddCategory.DataBack += Category_DataBack;
            AddCategory.ShowDialog();
        }

        private void EditCategoryItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCategory UpdateCategory = new frmAddUpdateCategory((int)dgvCategories.CurrentRow.Cells["CategoryID"].Value);
            UpdateCategory.DataBack += Category_DataBack;
            UpdateCategory.ShowDialog();
        }

        private void DeleteCategoryItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete This Category?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;

            if (clsCategory.DeleteCategory((int)dgvCategories.CurrentRow.Cells["CategoryID"].Value))
            {
                MessageBox.Show("Deleted Data Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadCategories();
                return;
            }

            MessageBox.Show("Deleted Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                _Visible(false, false);
                if(_CategoriesView != null)
                {
                    _CategoriesView.RowFilter = "";
                    lblRecordsCount.Text = _CategoriesView.Count.ToString();
                }
                return;
            }

            if(cbFilterBy.Text == "Is Active")
            {
                _Visible(true, false);
                cbFilterByActive.SelectedIndex = cbFilterByActive.FindString("All");
                if (_CategoriesView != null)
                {
                    _CategoriesView.RowFilter = "";
                    lblRecordsCount.Text = _CategoriesView.Count.ToString();
                }
                return;
            }

            _Visible(false, true);
            if (_CategoriesView != null)
            {
                _CategoriesView.RowFilter = "";
                lblRecordsCount.Text = _CategoriesView.Count.ToString();
            }
        }

        private void cbFilterByActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByActive.Text == "All")
            {
                if (_CategoriesView != null)
                {
                    _CategoriesView.RowFilter = "";
                    lblRecordsCount.Text = _CategoriesView.Count.ToString();
                }
                return;
            }

            bool Active = cbFilterByActive.Text == "Yes" ? true : false;
            if (_CategoriesView != null)
            {
                _CategoriesView.RowFilter = string.Format("[{0}] = {1}", IsActive.Name, Active);
                lblRecordsCount.Text = _CategoriesView.Count.ToString();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Category ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
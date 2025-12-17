using BMS.Books_Authors;
using BMS.People;
using BMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace BMS.Authors
{
    public partial class frmListAuthors : Form
    {
        DataView _AuthorsView;

        public frmListAuthors()
        {
            InitializeComponent();
        }
        private void _LoadAuthors()
        {
            _AuthorsView = clsAuthor.GetAllAuthors().DefaultView;
            dgvAuthors.DataSource = _AuthorsView;
            lblRecordsCount.Text = _AuthorsView.Count.ToString();
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Author ID": return AuthorID.Name;
                case "Person ID": return PersonID.Name;
                case "National No.": return NationalNo.Name;
                case "Nationality": return Nationality.Name;
                case "Full Name": return FullName.Name;
                case "Gender": return Gender.Name;
            }

            return "";
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || ColumnName == "None" || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _AuthorsView.RowFilter = "";
                lblRecordsCount.Text = _AuthorsView.Count.ToString();
                return;
            }

            if(ColumnName == PersonID.Name || ColumnName == AuthorID.Name)
            {
                _AuthorsView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _AuthorsView.Count.ToString();
                return;
            }

            _AuthorsView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = _AuthorsView.Count.ToString();
        }

        private void frmListAuthors_Load(object sender, EventArgs e)
        {
            _LoadAuthors();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor AddAuthor = new frmAddUpdateAuthor();
            AddAuthor.DataBack += Author_DataBack;
            AddAuthor.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPersonDetailsItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo showPersonInfo = new frmShowPersonInfo((int)dgvAuthors.CurrentRow.Cells["PersonID"].Value);
            showPersonInfo.ShowDialog();
        }

        private void ShowAuthorDetailsItem_Click(object sender, EventArgs e)
        {
            frmShowAuthorInfo showAuthorInfo = new frmShowAuthorInfo((int)dgvAuthors.CurrentRow.Cells["PersonID"].Value);
            showAuthorInfo.ShowDialog();
        }

        private void AddNewAuthorItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor NewAuthor = new frmAddUpdateAuthor();
            NewAuthor.DataBack += Author_DataBack;
            NewAuthor.ShowDialog();
        }

        private void Author_DataBack()
        {
            _LoadAuthors();
        }

        private void EditAuthorItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor UpdateAuthor = new frmAddUpdateAuthor((int)dgvAuthors.CurrentRow.Cells["PersonID"].Value);
            UpdateAuthor.DataBack += Author_DataBack;
            UpdateAuthor.ShowDialog();
        }

        private void DeleteAuthorItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete The Author?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;

            if (clsAuthor.DeleteAuthor((int)dgvAuthors.CurrentRow.Cells["AuthorID"].Value))
                MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Deleted Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowBooksHistoryItem_Click(object sender, EventArgs e)
        {
            frmShowBooksAuthorHistory booksAuthorHistory = new frmShowBooksAuthorHistory((int)dgvAuthors.CurrentRow.Cells["AuthorID"].Value);
            booksAuthorHistory.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                _AuthorsView.RowFilter = "";
                lblRecordsCount.Text = _AuthorsView.Count.ToString();
                return;
            }

            txtFilterValue.Visible = true;
            _AuthorsView.RowFilter = "";
            lblRecordsCount.Text = _AuthorsView.Count.ToString();
            txtFilterValue.Clear();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Author ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
using BMS_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BMS.Books.Controls
{
    public partial class ctrlBookCardWithFilter : UserControl
    {
        public event Action<int> OnSelectedBook;

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public int BookID => ctrlBookCard1.BookID;
        public string ISBN => ctrlBookCard1.ISBN;

        public clsBook SelectedBookInfo => ctrlBookCard1.SelectedBookInfo;

        public void txtFilterFocus()
        {
            txtFilterValue.Focus();
        }

        public void LoadBookInfo(string ISBN)
        {            
            txtFilterValue.Text = ISBN;
            btnFind.PerformClick();
        }

        public void LoadBookInfoByTitle(string Title)
        {
            txtFilterValue.Text = Title;
            btnFind.PerformClick();
        }

        public void LoadBookInfo(int BookID)
        {            
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = BookID.ToString();
            btnFind.PerformClick();
        }

        public ctrlBookCardWithFilter()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook AddBook = new frmAddUpdateBook();
            AddBook.DataBack += AddBook_DataBack;
            AddBook.ShowDialog();
        }

        private void AddBook_DataBack(int BookID)
        {
            LoadBookInfo(BookID);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
                errorProvider1.SetError(txtFilterValue, "This Is Required");

            else
                errorProvider1.SetError(txtFilterValue, null);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();

            if (cbFilterBy.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                txtFilterValue_Validating(null, null);
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "ISBN":
                    ctrlBookCard1.LoadBookInfo(txtFilterValue.Text.Trim());
                    break;

                case "Book ID":
                    ctrlBookCard1.LoadBookInfo(Convert.ToInt32(txtFilterValue.Text.Trim()));
                    break;

                case "Title":
                    ctrlBookCard1.LoadBookInfoByTitle(txtFilterValue.Text.Trim());
                    break;
            }

            if (OnSelectedBook != null && FilterEnabled)
                OnSelectedBook(ctrlBookCard1.BookID);
        }
    }
}
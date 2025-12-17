using BMS.Books.BookCopies;
using BMS.Books_Authors;
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

namespace BMS.Books
{
    public partial class frmListBooks : Form
    {
        private DataView _BooksView;

        public frmListBooks()
        {
            InitializeComponent();
        }

        private void _LoadBooksData()
        {
            _BooksView = clsBook.GetAllBooks().DefaultView;
            dgvBooks.DataSource = _BooksView;            
        }

        private void _FilterBy(string ColumnName)
        {
            if (string.IsNullOrEmpty(ColumnName) || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                if (_BooksView != null)
                {
                    _BooksView.RowFilter = "";
                    lblRecordsCount.Text = _BooksView.Count.ToString();
                }
                return;
            }

            if(cbFilterBy.Text == "Book ID")
            {
                if (_BooksView != null)
                {
                    _BooksView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
                    lblRecordsCount.Text = _BooksView.Count.ToString();
                }
                return;
            }

            if (_BooksView != null)
            {
                _BooksView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtFilterValue.Text.Trim());
                lblRecordsCount.Text = _BooksView.Count.ToString();
            }
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "Book ID": return BookID.Name;
                case "Title": return Title.Name;
                case "ISBN":return ISBN.Name;
                case "Category Name": return CategoryName.Name;
                case "National No.": return NationalNo.Name;
                case "Author Name": return AuthorName.Name;
            }

            return "";
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            _LoadBooksData();
            cbFilterBy.SelectedIndex = cbFilterBy.FindString("None");
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook AddBook = new frmAddUpdateBook();
            AddBook.DataBack += Book_DataBack;
            AddBook.ShowDialog();
        }

        private void Book_DataBack(int BookID)
        {
            _LoadBooksData();
        }

        private void ShowBookDetialsItem_Click(object sender, EventArgs e)
        {
            frmShowBookInfo showBookInfo = new frmShowBookInfo((int)dgvBooks.CurrentRow.Cells[0].Value);
            showBookInfo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAuthorsToBookItem_Click(object sender, EventArgs e)
        {
            frmAddAuthorsToBook addAuthorsToBook = new frmAddAuthorsToBook((int)dgvBooks.CurrentRow.Cells[0].Value);
            addAuthorsToBook.ShowDialog();
        }

        private void ShowBookAuthorsItem_Click(object sender, EventArgs e)
        {
            frmShowAuthorsBookHistory showAuthorsBookHistory = new frmShowAuthorsBookHistory((int)dgvBooks.CurrentRow.Cells["BookID"].Value);
            showAuthorsBookHistory.ShowDialog();
        }

        private void AddNewBookItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook AddBook = new frmAddUpdateBook();
            AddBook.DataBack += Book_DataBack;
            AddBook.ShowDialog();
        }

        private void EditBookItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook UpdateBook = new frmAddUpdateBook((int)dgvBooks.CurrentRow.Cells[0].Value);
            UpdateBook.DataBack += Book_DataBack;
            UpdateBook.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;

                if(_BooksView != null)
                {
                    _BooksView.RowFilter = "";
                    lblRecordsCount.Text = _BooksView.Count.ToString();
                }
                return;
            }

            txtFilterValue.Visible = true;

            if (_BooksView != null)
            {
                _BooksView.RowFilter = "";
                txtFilterValue.Clear();
                lblRecordsCount.Text = _BooksView.Count.ToString();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void ShowBookCopiesItem_Click(object sender, EventArgs e)
        {
            frmBookCopiesHistory bookCopiesHistory = new frmBookCopiesHistory((int)dgvBooks.CurrentRow.Cells["BookID"].Value);
            bookCopiesHistory.ShowDialog();
        }

        private void DeleteBookItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete This Book", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;

            if (clsBook.DeleteBook((int)dgvBooks.CurrentRow.Cells["BookID"].Value))
            {
                MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Deleted Failed", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddCopiesToBookItem_Click(object sender, EventArgs e)
        {
            frmAddCopiesToBook addCopiesToBook = new frmAddCopiesToBook((int)dgvBooks.CurrentRow.Cells["BookID"].Value);
            addCopiesToBook.ShowDialog();
        }
    }
}
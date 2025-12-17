using BMS.Books;
using BMS.Books.BookCopies;
using BMS_Business;
using System.Data;
using System.Windows.Forms;

namespace BMS.Books_Authors.Controls
{
    public partial class ctrlShowBooksAuthorHistory : UserControl
    {
        private int _AuthorID = -1;
        private DataTable _dtAuthorBooks = null;

        public ctrlShowBooksAuthorHistory()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            if (dgvBooks == null)
                return;

            dgvBooks.Rows.Clear();
            lblRecordsCount.Text = "0";
        }

        public void LoadBooksHistoryInfo(int AuthorID)
        {
            _AuthorID = AuthorID;
            _dtAuthorBooks = clsAuthor.GetBooksAuthorHistory(_AuthorID);

            if (_dtAuthorBooks == null)
                return;

            dgvBooks.DataSource = _dtAuthorBooks;
            lblRecordsCount.Text = _dtAuthorBooks.Rows.Count.ToString();
        }

        private void ShowBookDetialsItem_Click(object sender, System.EventArgs e)
        {
            frmShowBookInfo showBookInfo = new frmShowBookInfo((int)dgvBooks.CurrentRow.Cells["BookID"].Value);
            showBookInfo.ShowDialog();
        }

        private void ShowBookCopiesItem_Click(object sender, System.EventArgs e)
        {
            frmBookCopiesHistory bookCopiesHistory = new frmBookCopiesHistory((int)dgvBooks.CurrentRow.Cells["BookID"].Value);
            bookCopiesHistory.ShowDialog();
        }
    }
}
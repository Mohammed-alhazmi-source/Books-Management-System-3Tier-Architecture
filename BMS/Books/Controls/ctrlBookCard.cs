using BMS.GlobalClasses;
using BMS.Properties;
using BMS_Business;
using System.IO;
using System.Windows.Forms;

namespace BMS.Books.Controls
{
    public partial class ctrlBookCard : UserControl
    {
        private int _BookID = -1;
        public int BookID => _BookID;

        private string _ISBN = "";
        public string ISBN => _ISBN;

        private clsBook _Book = null;
        public clsBook SelectedBookInfo => _Book;

        private void _LoadBookImage()
        {
            if(_Book == null)
            {
                pbBookImage.Image = Resources.book_96px;
                return;
            }

            if(string.IsNullOrEmpty(_Book.ImagePath))
            {
                pbBookImage.Image = Resources.book_96px;
                return;
            }

            if(File.Exists(_Book.ImagePath))
            {
                pbBookImage.ImageLocation = _Book.ImagePath;
                return;
            }

            pbBookImage.ImageLocation = $"Image Path Not Found {_Book.ImagePath}";
        }

        private void _ResetDefaultValues()
        {
            lblBookID.Text = "[???]";
            lblTitle.Text = "[???]";
            lblISBN.Text = "[???]";
            lblCategory.Text = "[???]";
            lblAdditionalDetials.Text = "[???]";
            lblPublisherDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblCopiesCount.Text = "[???]";
            _LoadBookImage();
        }

        private void _FillBookInfoInControls()
        {
            _BookID = _Book.BookID;
            _ISBN = _Book.ISBN;
            lblBookID.Text = _Book.BookID.ToString();
            lblTitle.Text = _Book.Title;
            lblISBN.Text = _Book.ISBN;
            lblCategory.Text = _Book.CategoryInfo.CategoryName;
            lblAdditionalDetials.Text = _Book.AdditionalDetials;
            lblPublisherDate.Text = clsFormat.DateToString(_Book.PublisherDate);
            lblCreatedBy.Text = _Book.UserInfo.UserName;
            lblCopiesCount.Text = _Book.GetBookCopiesCount().ToString();
            _LoadBookImage();
        }

        public void LoadBookInfo(int BookID)
        {
            _Book = clsBook.FindByID(BookID);

            if(_Book == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Book With ID = {BookID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BookID = -1;
                llEditBookInfo.Enabled = false;
                return;
            }

            llEditBookInfo.Enabled = true;
            _FillBookInfoInControls();
        }

        public void LoadBookInfo(string ISBN)
        {
            _Book = clsBook.FindByISBN(ISBN);

            if (_Book == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Book With ISBN = {ISBN}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BookID = -1;
                llEditBookInfo.Enabled = false;
                return;
            }

            llEditBookInfo.Enabled = true;
            _FillBookInfoInControls();
        }

        public void LoadBookInfoByTitle(string Title)
        {
            _Book = clsBook.FindByTitle(Title);

            if (_Book == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"No Book With Title = {Title}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BookID = -1;
                llEditBookInfo.Enabled = false;
                return;
            }

            llEditBookInfo.Enabled = true;
            _FillBookInfoInControls();
        }


        public ctrlBookCard()
        {
            InitializeComponent();            
        }

        private void llEditBookInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateBook EditBook = new frmAddUpdateBook(_BookID);
            EditBook.DataBack += EditBook_DataBack;
            EditBook.ShowDialog();
        }

        private void EditBook_DataBack(int BookID)
        {
            LoadBookInfo(BookID);
        }
    }
}
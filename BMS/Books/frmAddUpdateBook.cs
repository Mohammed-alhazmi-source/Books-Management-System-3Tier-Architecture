using BMS.Categories;
using BMS.GlobalClasses;
using BMS.Properties;
using BMS_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BMS.Books
{
    public partial class frmAddUpdateBook : Form
    {
        private clsEnums.enMode _Mode = clsEnums.enMode.Add;
       
        private int _BookID = -1;
        private int _PersonID = -1;

        private clsBook _Book = null;
        private clsBookCopy _BookCopy = null;
        private clsBookAuthor _BookAuthor = null;

        public event Action<int> DataBack;

        public frmAddUpdateBook()
        {
            InitializeComponent();
            _Mode = clsEnums.enMode.Add;
        }

        public frmAddUpdateBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            _Mode = clsEnums.enMode.Update;
        }

        private void _FillCategoriesInComboBox()
        {
            DataTable dtCategories = clsCategory.GetAllCategoriesActive();
            foreach (DataRow Row in dtCategories.Rows)
            {
                cbCategories.Items.Add(Row["CategoryName"]);
            }
            cbCategories.SelectedIndex = 0;
        }

        private void _ResetDefaultValues()
        {
            _FillCategoriesInComboBox();

            if (_Mode == clsEnums.enMode.Add)
            {
                lblTitle.Text = "Add New Book";
                lblBookID.Text = "[???]";
                lblBookCopiesCount.Text = "0";
                _Book = new clsBook();
                _BookCopy = new clsBookCopy();
                _BookAuthor = new clsBookAuthor();
            }
            else
                lblTitle.Text = "Update Book";

            txtISBN.Text = "";
            tpBookInfo.Enabled = false;
            txtTitle.Text = "";
            dtpPublisherDate.MinDate = DateTime.Now;
            dtpPublisherDate.Value = dtpPublisherDate.MinDate;
            txtAdditionalDetials.Text = "";
            pbBookImage.Image = Resources.book_96px;
        }

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

            if(!string.IsNullOrEmpty(_Book.ImagePath))
            {
                if(File.Exists(_Book.ImagePath))
                {
                    pbBookImage.ImageLocation = _Book.ImagePath;
                    btnRemoveImage.Visible = true;
                    return;
                }
            }

            pbBookImage.ImageLocation = $"Not Found Image Path = {_Book.ImagePath}";
        }

        private void _LoadBookInfo()
        {
            _Book = clsBook.FindByID(_BookID);

            if(_Book == null)
            {
                MessageBox.Show($"No Book With ID = {_BookID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BookID = -1;
                btnSave.Enabled = false;
                return;
            }

            if (DateTime.Compare(_Book.PublisherDate, DateTime.Now) < 0)
                dtpPublisherDate.MinDate = _Book.PublisherDate;
            else
                dtpPublisherDate.MinDate = DateTime.Now;

            dtpPublisherDate.Value = _Book.PublisherDate;

            ctrlPersonCardWithFilter1.LoadPersonInfo(clsBookAuthor.FindByBookID(_BookID).AuthorInfo.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            nudBookCopies.Enabled = false;
            lblBookID.Text = _Book.BookID.ToString();
            txtTitle.Text = _Book.Title;
            txtISBN.Text = _Book.ISBN;
            cbCategories.SelectedIndex = cbCategories.FindString(_Book.CategoryInfo.CategoryName);
            txtAdditionalDetials.Text = _Book.AdditionalDetials;
            lblBookCopiesCount.Text = _Book.GetBookCopiesCount().ToString();
            _LoadBookImage();
        }

        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if(string.IsNullOrEmpty(Temp.Text))
                errorProvider1.SetError(Temp, "This Filed Is Required");

            else
                errorProvider1.SetError(Temp, null);
        }

        public override bool ValidateChildren()
        {
            bool IsValid = true;

            if(string.IsNullOrEmpty(txtTitle.Text))
            {
                txtTitle_Validating(txtTitle, null);
                IsValid = false;
            }

            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                txtISBN_Validating(txtISBN, null);
                IsValid = false;
            }

            return IsValid;
        }

        private bool _HandleBookImage()
        {
            string SourceFile = "";
            if (pbBookImage.ImageLocation == null)
            {
                if (!string.IsNullOrEmpty(_Book.ImagePath))
                {
                    File.Delete(_Book.ImagePath);
                    return true;
                }
                return true;
            }

            if (string.IsNullOrEmpty(_Book.ImagePath))
            {
                if (pbBookImage.ImageLocation != null)
                {
                    SourceFile = pbBookImage.ImageLocation;
                    if (clsUtil.CopyImageToFolderImages(ref SourceFile, "E:\\BMS_Books_Images"))
                    {
                        pbBookImage.ImageLocation = SourceFile;
                        return true;
                    }
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(_Book.ImagePath))
            {
                if (_Book.ImagePath != pbBookImage.ImageLocation)
                {
                    try
                    {
                        File.Delete(_Book.ImagePath);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    SourceFile = pbBookImage.ImageLocation;
                    if (clsUtil.CopyImageToFolderImages(ref SourceFile, "E:\\BMS_Books_Images"))
                    {
                        pbBookImage.ImageLocation = SourceFile;
                        return true;
                    }
                    return false;
                }
            }

            return true;
        }

        private void frmAddUpdateBook_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == clsEnums.enMode.Update)
                _LoadBookInfo();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTitle.Text))
            {
                _ValidateEmptyTextBox(sender, e);
                return;
            }

            // Mode = Update
            if(_Mode == clsEnums.enMode.Update)
            {
                if(txtTitle.Text != _Book.Title)
                {
                    if (clsBook.IsBookExistByTitle(txtTitle.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtTitle, "Title Is Used Another Book");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtTitle, null);
                    }
                }
                return;
            }

            // Mode = Add
            if (clsBook.IsBookExistByTitle(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title Is Used Another Book");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtISBN.Text))
            {
                _ValidateEmptyTextBox(sender, e);
                return;
            }

            // Mode = Update;
            if(_Mode == clsEnums.enMode.Update)
            {
                if(txtISBN.Text != _Book.ISBN)
                {
                    if (clsBook.IsBookExistByTitle(txtTitle.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtISBN, "ISBN Is Used Another Book");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtISBN, null);
                    }
                }
                return;
            }

            // Mode = Add;
            if (clsBook.IsBookExistByISBN(txtISBN.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtISBN, "ISBN Is Used Another Book");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtISBN, null);
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif";
            openFile.ShowDialog();

            if (!string.IsNullOrEmpty(openFile.FileName))
            {
                pbBookImage.ImageLocation = openFile.FileName;
                btnRemoveImage.Visible = true;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbBookImage.ImageLocation = null;
            btnRemoveImage.Visible = false;
            pbBookImage.Image = Resources.book_96px;
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
           _PersonID = PersonID;

            if(_PersonID == -1)
            {
                btnSave.Enabled = false;
                return;
            }

            ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = true;

            clsAuthor Author = clsAuthor.FindByPersonID(_PersonID);
            if (Author == null)
            {
                _PersonID = -1;
                MessageBox.Show("This Person Is Not Author, Choose Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if(_Mode == clsEnums.enMode.Update)
            {
                btnSave.Enabled = true;
                tpBookInfo.Enabled = true;
                tcBook.SelectedTab = tcBook.TabPages["tpBookInfo"];
                return;
            }

            if(_PersonID != -1)
            {
                btnSave.Enabled = true;
                tpBookInfo.Enabled = true;
                tcBook.SelectedTab = tcBook.TabPages["tpBookInfo"];
                return;
            }


            MessageBox.Show("Please Select A Person,", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (!_HandleBookImage())
                return;

            _Book.Title = txtTitle.Text;
            _Book.ISBN = txtISBN.Text;
            _Book.CategoryID = clsCategory.Find(cbCategories.Text).CategoryID;
            _Book.AdditionalDetials = txtAdditionalDetials.Text;
            _Book.PublisherDate = dtpPublisherDate.Value;
            _Book.ImagePath = (string.IsNullOrEmpty(pbBookImage.ImageLocation) ? "" : pbBookImage.ImageLocation);
            _Book.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Book.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBookID.Text = _Book.BookID.ToString();
                lblTitle.Text = "Update Book";
                DataBack?.Invoke(_Book.BookID);
            }
            else
            {
                MessageBox.Show("Saved Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == clsEnums.enMode.Add)
            {
                // Save Book Copies
                _BookCopy.BookID = _Book.BookID;
                _BookCopy.IsActive = true;
                _BookCopy.BookCopyName = _Book.Title;
                _BookCopy.BookCopiesCount = (int)nudBookCopies.Value;
                if (!_BookCopy.Save())
                    MessageBox.Show("Saved Data Book Copies Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                // Save Book And Author
                _BookAuthor.AuthorID = clsAuthor.FindByPersonID(_PersonID).AuthorID;
                _BookAuthor.BookID = _Book.BookID;
                if (!_BookAuthor.Save())
                    MessageBox.Show("Saved Data Book And Author Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblBookCopiesCount.Text = _Book.GetBookCopiesCount().ToString();
            _Mode = clsEnums.enMode.Update;
        }

        private void frmAddUpdateBook_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llAddCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateCategory AddCategory = new frmAddUpdateCategory();
            AddCategory.DataBack += AddCategory_DataBack;
            AddCategory.ShowDialog();
        }

        private void AddCategory_DataBack()
        {
            cbCategories.Items.Clear();
            _FillCategoriesInComboBox();
        }
    }
}
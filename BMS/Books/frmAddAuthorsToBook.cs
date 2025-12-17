using BMS.Authors;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Books
{
    public partial class frmAddAuthorsToBook : Form
    {
        private int _BookID = -1;
        private int _PersonID = -1;

        private clsBookAuthor _BookAuthor = null;
        private clsAuthor _Author = null;

        public frmAddAuthorsToBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            tpBookInfo.Enabled = false;
        }
      
        private void btnNextTab_Click(object sender, EventArgs e)
        {
            _Author = clsAuthor.FindByPersonID(_PersonID);

            if(_Author == null)
            {
                MessageBox.Show("This Person Is Not Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.txtValueFilterFocus();
                btnSave.Enabled = false;
                tpBookInfo.Enabled = false;
                return;
            }

            bool IsAuthor = clsBookAuthor.IsAuthorAndBookExist(_Author.AuthorID, _BookID);
            if (IsAuthor)
            {
                MessageBox.Show("This Author Is Exist, Choose Another One", "Selected Another One", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.txtValueFilterFocus();
                btnSave.Enabled = false;
                tpBookInfo.Enabled = false;
                return;
            }

            if (_PersonID != -1)
            {
                btnSave.Enabled = true;
                tpBookInfo.Enabled = true;
                tcAddAuthorsToBook.SelectedTab = tcAddAuthorsToBook.TabPages["tpBookInfo"];
                ctrlBookCardWithFilter1.txtFilterFocus();
                ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
                ctrlBookCardWithFilter1.FilterEnabled = false;
                return;
            }


            MessageBox.Show("Please Select A Person,", "Select A Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            _PersonID = PersonID;            

            if (_PersonID == -1)
            {
                btnSave.Enabled = false;
                tpBookInfo.Enabled = false;                
                return;
            }

            ctrlPersonCardWithFilter1.ShowLinkEditPersonInfo = true;
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void frmAddAuthorsToBook_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.txtValueFilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            _BookAuthor = new clsBookAuthor();
            _BookAuthor.BookID = _BookID;
            _BookAuthor.AuthorID = _Author.AuthorID;

            if (_BookAuthor.Save())
            {
                MessageBox.Show("Saved Data Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcAddAuthorsToBook.SelectedTab = tcAddAuthorsToBook.TabPages["tpAuthorInfo"];
                btnSave.Enabled = false;
                ctrlBookCardWithFilter1.txtFilterFocus();
            }

            else
                MessageBox.Show("Saved Data Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor AddAuthor = new frmAddUpdateAuthor();
            AddAuthor.ShowDialog();
        }
    }
}
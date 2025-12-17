using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Books_Authors
{
    public partial class frmShowBooksAuthorHistory : Form
    {
        private int _AuthorID = -1;
        private clsAuthor _Author = null;

        public frmShowBooksAuthorHistory()
        {
            InitializeComponent();
        }

        public frmShowBooksAuthorHistory(int AuthorID)
        {
            InitializeComponent();
            _AuthorID = AuthorID;
        }

        private void frmShowBooksAuthorHistory_Load(object sender, EventArgs e)
        {
            if (_AuthorID == -1)
                ctrlPersonCardWithFilter1.FilterEnabled = true;

            else
            {
                _Author = clsAuthor.FindByAuthorID(_AuthorID);
                
                if (_Author == null)
                    return;

                ctrlPersonCardWithFilter1.LoadPersonInfo(_Author.PersonID);
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlShowBooksAuthorHistory1.LoadBooksHistoryInfo(_AuthorID);
            }
        }

        private void ctrlPersonCardWithFilter1_OnSelectedPerson(int PersonID)
        {
            if (PersonID == -1)
                return;

            ctrlShowBooksAuthorHistory1.Clear();
            _Author = clsAuthor.FindByPersonID(PersonID);

            if (_Author == null)
                return;

            ctrlShowBooksAuthorHistory1.LoadBooksHistoryInfo(_Author.AuthorID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
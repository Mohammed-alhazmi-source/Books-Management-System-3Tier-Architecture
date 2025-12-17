using System;
using System.Windows.Forms;

namespace BMS.Books
{
    public partial class frmBookCopiesHistory : Form
    {
        private int _BookID = -1;

        public frmBookCopiesHistory()
        {
            InitializeComponent();
        }

        public frmBookCopiesHistory(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void frmBookCopiesHistory_Load(object sender, EventArgs e)
        {
            if (_BookID == -1)
                ctrlBookCardWithFilter1.FilterEnabled = true;
            else
            {
                ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
                ctrlBookCardWithFilter1.FilterEnabled = false;
                ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlBookCardWithFilter1_OnSelectedBook(int BookID)
        {
            _BookID  = BookID;

            if (_BookID == -1)
                return;

            ctrlBookCopiesHistory1.Clear();
            ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
        }
    }
}
using System;
using System.Windows.Forms;

namespace BMS.Books_Authors
{
    public partial class frmShowAuthorsBookHistory : Form
    {
        private int _BookID = -1;

        public frmShowAuthorsBookHistory(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void frmShowAuthorsBookHistory_Load(object sender, EventArgs e)
        {
            if(_BookID == -1)
                ctrlBookCardWithFilter1.FilterEnabled = true;

            else
            {
                ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
                ctrlBookCardWithFilter1 .FilterEnabled = false;
                ctrlAuthorsBookHistory1.LoadAuthorsHistoryInfo(_BookID);
            }
        }

        private void ctrlBookCardWithFilter1_OnSelectedBook(int BookID)
        {
            _BookID = BookID;

            if (_BookID == -1)
                return;

            ctrlAuthorsBookHistory1.Clear();
            ctrlAuthorsBookHistory1.LoadAuthorsHistoryInfo(_BookID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
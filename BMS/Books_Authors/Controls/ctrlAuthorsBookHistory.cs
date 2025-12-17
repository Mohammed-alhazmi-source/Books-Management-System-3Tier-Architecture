using BMS.Authors;
using BMS.People;
using BMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace BMS.Books_Authors.Controls
{
    public partial class ctrlAuthorsBookHistory : UserControl
    {
        private int _BookID = -1;
        private DataTable _dtAuthorsBookHistory = null;

        public ctrlAuthorsBookHistory()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            if (dgvAuthorsHistory == null)
                return;

            dgvAuthorsHistory.Rows.Clear();
            lblRecordsCount.Text = "0";
        }

        public void LoadAuthorsHistoryInfo(int BookID)
        {
            _dtAuthorsBookHistory = clsBook.GetAuthorsBookHistory(BookID);

            if (_dtAuthorsBookHistory == null)
                return;

            dgvAuthorsHistory.DataSource = _dtAuthorsBookHistory;
            lblRecordsCount.Text = dgvAuthorsHistory.Rows.Count.ToString();
        }

        private void ShowAuthorDetialsItem_Click(object sender, EventArgs e)
        {
            frmShowAuthorInfo showAuthorInfo = new frmShowAuthorInfo((int)dgvAuthorsHistory.CurrentRow.Cells["PersonID"].Value);
            showAuthorInfo.ShowDialog();
        }

        private void ShowPersonDetialsItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo showPersonInfo = new frmShowPersonInfo((int)dgvAuthorsHistory.CurrentRow.Cells["PersonID"].Value);
            showPersonInfo.ShowDialog();
        }
    }
}
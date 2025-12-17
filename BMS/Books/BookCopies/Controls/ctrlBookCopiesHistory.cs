using BMS_Business;
using System.Data;
using System.Windows.Forms;

namespace BMS.Books.BookCopies.Controls
{
    public partial class ctrlBookCopiesHistory : UserControl
    {
        private int _BookID = -1;
        DataTable _dtBookCopiesHistory = null;

        public bool IsBookCopyActive
        {
            get
            {
                if (dgvBookCopiesHistory.CurrentCell == null)
                    return false;

                return (bool)dgvBookCopiesHistory.CurrentRow.Cells["IsActive"].Value;
            }
        }

        public int GetBookCopyID
        {
            get
            {
                if (dgvBookCopiesHistory.CurrentCell != null)
                    return (int)dgvBookCopiesHistory.CurrentRow.Cells["BookCopyID"].Value;

                return -1;
            }
        }

        private ContextMenuStrip _ContextMenuStrip;
        public ContextMenuStrip SelectedContextMenuStrip
        {
            get { return _ContextMenuStrip; }
            set
            {
                _ContextMenuStrip = value;
                dgvBookCopiesHistory.ContextMenuStrip = _ContextMenuStrip;
            }
        }      

        public void Clear()
        {
            if (dgvBookCopiesHistory.DataSource == null)
                return;

            dgvBookCopiesHistory.DataSource = null;
            lblRecordsCount.Text = "0";
        }

        private void _InitializeColumnsDataGridView()
        {
            dgvBookCopiesHistory.Columns[0].Width = 100;
            dgvBookCopiesHistory.Columns[1].Width = 100;
            dgvBookCopiesHistory.Columns[2].Width = 215;
            dgvBookCopiesHistory.Columns[3].Width = 210;
            dgvBookCopiesHistory.Columns[4].Width = 200;
            dgvBookCopiesHistory.Columns[5].Width = 100;
        }

        public void LoadBookCopiesInfo(int BookID)
        {
            _BookID = BookID;
            _dtBookCopiesHistory = clsBook.GetBookCopiesHistory(_BookID);

            if (_dtBookCopiesHistory == null)
                return;

            dgvBookCopiesHistory.DataSource = _dtBookCopiesHistory;
            _InitializeColumnsDataGridView();
            lblRecordsCount.Text = _dtBookCopiesHistory.Rows.Count.ToString();
        }

        public ctrlBookCopiesHistory()
        {
            InitializeComponent();
        }       
    }
}
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

namespace BMS.Books.BookCopies.Controls
{
    public partial class ctrlBookCopiesForBorrowing : UserControl
    {

        private int _BookID = -1;
        DataTable _dtBookCopiesHistory = null;

        private ContextMenuStrip _ContextMenuStrip;
        public ContextMenuStrip SelectedContextMenuStrip
        {
            get { return _ContextMenuStrip; }
            set 
            {
                _ContextMenuStrip = value;
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

        public ctrlBookCopiesForBorrowing()
        {
            InitializeComponent();
        }
    }
}

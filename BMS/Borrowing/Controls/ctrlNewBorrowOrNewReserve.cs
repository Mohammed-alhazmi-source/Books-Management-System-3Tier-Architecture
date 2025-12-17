using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Books.Controls
{
    public partial class ctrlNewBorrowOrNewReserve : UserControl
    {        
        private int _BookID = -1;

        public clsBook SelectedBookInfo => ctrlBookCardWithFilter1.SelectedBookInfo;

        private clsBorrow _Borrow = null;
        public clsBorrow SelectedBorrowInfo => _Borrow;

        private clsReserve _Reserve = null;
        public clsReserve SelectedReserveInfo => _Reserve;

        private bool _VisibleSetBorrowItem = false;
        public bool VisibleSetBorrowItem
        {
            get { return _VisibleSetBorrowItem; }
            set
            {
                _VisibleSetBorrowItem = value;
                SetBorrowItem.Visible = _VisibleSetBorrowItem;
            }
        }

        private bool _VisibleSetReserveItem = false;
        public bool VisibleSetReserveItem
        {
            get { return _VisibleSetReserveItem; }
            set
            {
                _VisibleSetReserveItem = value;
                SetReserveItem.Visible = _VisibleSetReserveItem;
            }
        }

        private DateTime _DueDate = DateTime.Now.AddDays(clsSetting.GetDefaultDaysToBorrow());
        public DateTime DueDate
        {
            get { return  _DueDate; }
            set
            {
                _DueDate = value;                
            }
        }

        public event Action<bool> OnSelectedBorrow;

        public event Action<bool> OnSelectedReserve;

        private int _PersonID = -1;        
        public int PersonID
        {
            get { return _PersonID; }
            set 
            {
                _PersonID = value;
            }
        }

        public ctrlNewBorrowOrNewReserve()
        {
            InitializeComponent();
        }

        public void txtFilterFocus()
        {
            ctrlBookCardWithFilter1.txtFilterFocus();
        }

        private void _LoadBookInfo()
        {
            ctrlBookCardWithFilter1.LoadBookInfo(_BookID);
        }

        private void _LoadBookCopiesInfo()
        {
            ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
        }

        public void LoadBookInfoWithCopies(int BookID)
        {
            _BookID = BookID;

            _LoadBookInfo();
            _LoadBookCopiesInfo();
        }

        private void ctrlBookCardWithFilter1_OnSelectedBook(int BookID)
        {
            _BookID = BookID;

            if (_BookID == -1)
            {
                ctrlBookCopiesHistory1.Clear();
                return;
            }

            ctrlBookCopiesHistory1.Clear();

            if(_VisibleSetBorrowItem)
            {
                if (clsBorrow.DoesPersonHasBorrowForBookCopy(ctrlBookCardWithFilter1.SelectedBookInfo.BookID, _PersonID))
                {
                    MessageBox.Show("This Person Have BookCopy Is Borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //if (_VisibleSetReserveItem)
            //{
            //    if (clsReserve.IsBookCopyReserved(_PersonID, ctrlBookCardWithFilter1.SelectedBookInfo.BookID))
            //    {
            //        MessageBox.Show("This Person Have Reserve To BookCopy One ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}

            ctrlBookCopiesHistory1.LoadBookCopiesInfo(_BookID);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetBorrowItem.Enabled = (ctrlBookCopiesHistory1.IsBookCopyActive && _PersonID != -1);
            SetReserveItem.Enabled = (!ctrlBookCopiesHistory1.IsBookCopyActive && _PersonID != -1);
        }

        private void SetBorrowItem_Click(object sender, EventArgs e)
        {
            if (clsBorrow.DoesPersonHasBorrowForBookCopy(ctrlBookCardWithFilter1.SelectedBookInfo.BookID, _PersonID))
            {
                MessageBox.Show("This Person Have BookCopy Is Borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure Of Borrow To This BookCopy?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;           

            _Borrow = new clsBorrow();

            _Borrow.BookCopyID = ctrlBookCopiesHistory1.GetBookCopyID;
            _Borrow.PersonID = _PersonID;
            _Borrow.BorrowingDate = DateTime.Now;
            _Borrow.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Borrow.DueDate = _DueDate;

            if (_Borrow.Save())
            {
                MessageBox.Show($"The Book Copy Is Borrowed Successfully With BorrowID = {_Borrow.BorrowID}", "Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadBookCopiesInfo();

                if (OnSelectedBorrow != null)
                    OnSelectedBorrow.Invoke(true);
            }

            else
                MessageBox.Show("The Book Copy Is Not Borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetReserveItem_Click(object sender, EventArgs e)
        {
            if (clsReserve.IsBookCopyReserved(_PersonID, ctrlBookCardWithFilter1.SelectedBookInfo.BookID))
            {
                MessageBox.Show("This Person Have Reserve To BookCopy One ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure Of Reserve To This BookCopy?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Cancel)
                return;

            _Reserve = new clsReserve();

            _Reserve.PersonID = _PersonID;
            _Reserve.BookCopyID = ctrlBookCopiesHistory1.GetBookCopyID;
            _Reserve.ReserveDate = DateTime.Now;
            _Reserve.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            
            if (_Reserve.Save())
            {
                MessageBox.Show($"The Book Copy Is Reserve Successfully With ReserveID = {_Reserve.ReserveID}", "Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (OnSelectedReserve != null)
                    OnSelectedReserve.Invoke(true);
            }
        }
    }
}
using BMS.GlobalClasses;
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

namespace BMS.Reservations.Controls
{
    public partial class ctrlReserveCard : UserControl
    {
        private int _ReserveID = -1;
        public int ReserveID => _ReserveID;

        private clsReserve _Reserve = null;
        public clsReserve SelectedReserveInfo => _Reserve;

        private void _ResetDefaultValues()
        {
            lblReserveID.Text = "[???]";
            lblPersonName.Text = "[???]";
            lblBookName.Text = "[???]";
            lblBookCopyID.Text = "[???]";
            lblIsReserved.Text = "[???]";
            lblReserveDate.Text = "[???]";
            lblReleaseReserveDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void _FillReserveInfoInControls()
        {
            _ReserveID = _Reserve.ReserveID;
            lblReserveID.Text = _Reserve.ReserveID.ToString();
            lblPersonName.Text = _Reserve.PersonInfo.FullName;
            lblBookName.Text = _Reserve.BookInfo.Title;
            lblBookCopyID.Text = _Reserve.BookCopyID.ToString();
            lblIsReserved.Text = _Reserve.ReserveStatus ? "No" : "Yes";
            lblReserveDate.Text = clsFormat.DateToString(_Reserve.ReserveDate);
            lblReleaseReserveDate.Text = _Reserve.ReleaseReserveDate == new DateTime(1,1,1) ? "[???]" : clsFormat.DateToString(_Reserve.ReleaseReserveDate);
            lblCreatedBy.Text = _Reserve.CreatedByUserInfo.UserName;
        }

        public void LoadReserveInfo(int ReserveID)
        {
            _Reserve = clsReserve.Find(ReserveID);

            if(_Reserve == null)
            {
                _ResetDefaultValues();
                MessageBox.Show($"Not Found Reserve", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ReserveID = -1;
                return;
            }

            _FillReserveInfoInControls();
        }


        public void LoadReserveInfoByISBNAndBookCopyID(string ISBN, int BookCopyID, int PersonID)
        {
            _Reserve = clsReserve.FindByISBNAndBookCopyIDAndPersonID(ISBN, BookCopyID, PersonID);

            if (_Reserve == null)
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillReserveInfoInControls();
        }

        public void LoadReserveInfoByTitleAndBookCopyID(string Title, int BookCopyID, int PersonID)
        {
            _Reserve = clsReserve.FindByTitleAndBookCopyIDAndPersonID(Title, BookCopyID, PersonID);

            if (_Reserve == null)
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillReserveInfoInControls();
        }

        public void LoadReserveInfoByBookIDAndBookCopyID(int BookID, int BookCopyID, int PersonID)
        {
            _Reserve = clsReserve.FindByBookIDAndBookCopyIDAndPersonID(BookID, BookCopyID, PersonID);

            if (_Reserve == null)
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillReserveInfoInControls();
        }


        public ctrlReserveCard()
        {
            InitializeComponent();
        }
    }
}
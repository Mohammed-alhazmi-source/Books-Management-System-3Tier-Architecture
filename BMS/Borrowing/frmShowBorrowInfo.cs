using System.Windows.Forms;

namespace BMS.Borrowing
{
    public partial class frmShowBorrowInfo : Form
    {
        public frmShowBorrowInfo(int BorrowID)
        {
            InitializeComponent();
            ctrlBorrowCard1.LoadBorrowInfo(BorrowID);
            ctrlBorrowCard1.VisibleMessageUser = false;
        }
    }
}
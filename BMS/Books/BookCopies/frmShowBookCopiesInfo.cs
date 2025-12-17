using System.Windows.Forms;

namespace BMS.Books.BookCopies
{
    public partial class frmShowBookCopiesInfo : Form
    {
        private int _BookID = -1;
        public frmShowBookCopiesInfo(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            
            ctrlBookCopiesCard1.LoadBookCopiesInfo(_BookID);
        }
    }
}
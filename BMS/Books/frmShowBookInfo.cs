using System;
using System.Windows.Forms;

namespace BMS.Books
{
    public partial class frmShowBookInfo : Form
    {
        private int _BookID = -1;

        public frmShowBookInfo(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {
            ctrlBookCard1.LoadBookInfo(_BookID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System.Windows.Forms;

namespace BMS.Fines
{
    public partial class frmShowFineInfo : Form
    {
        private int _FineID = -1;

        public frmShowFineInfo()
        {
            InitializeComponent();
        }

        public frmShowFineInfo(int FineID)
        {
            InitializeComponent();
            _FineID = FineID;
            ctrlFindCard1.LoadFineInfo(_FineID);
        }

        private void btnClose_Click(object sender, System.EventArgs e) => Close();
    }
}
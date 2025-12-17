using System;
using System.Windows.Forms;

namespace BMS.Authors
{
    public partial class frmShowAuthorInfo : Form
    {
        private int _PersonID = -1;

        public frmShowAuthorInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowAuthorInfo_Load(object sender, EventArgs e)
        {
            ctrlAuthorCard1.LoadAuthorInfoByPersonId(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace BMS.People
{
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonID = -1;

        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
using System;
using System.Windows.Forms;

namespace BMS.Users
{
    public partial class frmShowCurrentUserInfo : Form
    {
        private int _UserID = -1;

        public frmShowCurrentUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmShowCurrentUserInfo_Load(object sender, EventArgs e) => ctrlUserCard1.LoadByUserID(_UserID);

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
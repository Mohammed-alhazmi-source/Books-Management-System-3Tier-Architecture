using System;
using System.Windows.Forms;

namespace BMS.Reservations
{
    public partial class frmShowReserveInfo : Form
    {
        private int _ReserveID = -1;

        public frmShowReserveInfo(int ReserveID)
        {
            InitializeComponent();
            _ReserveID = ReserveID;
            ctrlReserveCard1.LoadReserveInfo(_ReserveID);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
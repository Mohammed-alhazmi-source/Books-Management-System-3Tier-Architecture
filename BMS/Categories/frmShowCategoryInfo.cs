using System;
using System.Windows.Forms;

namespace BMS.Categories
{
    public partial class frmShowCategoryInfo : Form
    {
        private int _CategoryID = -1;

        public frmShowCategoryInfo(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
        }

        public event Action EditCategory;

        private void frmShowCategoryInfo_Load(object sender, EventArgs e)
        {
            ctrlCategoryCard1.LoadCategoryInfo(_CategoryID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlCategoryCard1_OnEdit()
        {
            EditCategory?.Invoke();
        }
    }
}
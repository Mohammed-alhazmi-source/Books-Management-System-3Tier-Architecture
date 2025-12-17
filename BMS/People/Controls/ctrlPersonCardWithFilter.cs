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

namespace BMS.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            ctrlPersonCard1.ShowLinkEditPersonInfo = false;
            cbFilterBy.SelectedIndex = 0;
        }

        public event Action<int> OnSelectedPerson;

        public int PersonID => ctrlPersonCard1.PersonID;

        public clsPerson SelectedPersonInfo => ctrlPersonCard1.SelectedPersonInfo;

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set 
            { 
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public bool ShowLinkEditPersonInfo
        {
            get { return ctrlPersonCard1.ShowLinkEditPersonInfo; }
            set { ctrlPersonCard1.ShowLinkEditPersonInfo =  value;}
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtValueFilter.Text = PersonID.ToString();
            btnFind.PerformClick();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            txtValueFilter.Text = NationalNo;
            btnFind.PerformClick();
        }

        public void txtValueFilterFocus() => txtValueFilter.Focus();       

        private void txtValueFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtValueFilter.Text))
                errorProvider1.SetError(txtValueFilter, "This Filed Is Required");
            else
                errorProvider1.SetError(txtValueFilter, null);
        }

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnFind.PerformClick();

            if(cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson AddPerson = new frmAddUpdatePerson();
            AddPerson.DataBack += AddPerson_DataBack;
            AddPerson.ShowDialog();
        }

        private void AddPerson_DataBack(int PersonID)
        {
            LoadPersonInfo(PersonID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValueFilter.Text))
            {
                txtValueFilter_Validating(null, null);
                return;
            }

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(Convert.ToInt32(txtValueFilter.Text.Trim()));
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtValueFilter.Text.Trim());
                    break;
            }

            if (OnSelectedPerson != null && FilterEnabled)
                OnSelectedPerson(ctrlPersonCard1.PersonID);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValueFilter.Clear();
        }
    }
}
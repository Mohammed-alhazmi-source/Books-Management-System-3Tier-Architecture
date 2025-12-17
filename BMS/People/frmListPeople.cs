using BMS_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace BMS.People
{
    public partial class frmListPeople : Form
    {
        public event Action<int> DataBack;
        private DataView _PeopleView;

        private void _LoadData()
        {
            _PeopleView = clsPerson.GetAllPeople().DefaultView;
            dgvPeople.DataSource = _PeopleView;
        }

        private void _FilterBy(string ColumnName)
        {
            if(string.IsNullOrEmpty(ColumnName) || ColumnName == "None" || string.IsNullOrEmpty(txtValueFilter.Text))
            {
                _PeopleView.RowFilter = "";
                lblRecordsCount.Text = _PeopleView.Count.ToString();
                return;
            }

            if(ColumnName == PersonID.Name)
            {
                _PeopleView.RowFilter = string.Format("[{0}] = {1}", ColumnName, Convert.ToInt32(txtValueFilter.Text.Trim()));
                lblRecordsCount.Text = _PeopleView.Count.ToString();
                return;
            }


            _PeopleView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnName, txtValueFilter.Text.Trim());
            lblRecordsCount.Text = _PeopleView.Count.ToString();
        }

        private string _GetColumnName()
        {
            switch (cbFilterBy.Text)
            {
                case "None": return "";
                case "Person ID":          return PersonID.Name;
                case "Full Name": return FullName.Name;
                case "Gender": return Gender.Name;
                case "National No.": return NationalNo.Name;
                case "Nationality": return Nationality.Name;
                case "Phone": return Phone.Name;
                case "Email": return Email.Name;
            }

            return "";
        }

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _LoadData();
            lblRecordsCount.Text = _PeopleView.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePerson = new frmAddUpdatePerson();
            addUpdatePerson.DataBack += AddUpdatePerson_DataBack;
            addUpdatePerson.ShowDialog();
        }

        private void AddUpdatePerson_DataBack(int PersonID)
        {
            _LoadData();
        }

        private void ShowPersonDetailsItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo showPersonInfo = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells["PersonID"].Value);
            showPersonInfo.ShowDialog();
        }

        private void AddNewPersonItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson AddPerson = new frmAddUpdatePerson();
            AddPerson.DataBack += AddUpdatePerson_DataBack;
            AddPerson.ShowDialog();
        }

        private void EditPersonItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson UpdatePerson = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells["PersonID"].Value);
            UpdatePerson.DataBack += AddUpdatePerson_DataBack;
            UpdatePerson.ShowDialog();
        }

        private void DeletePersonItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete This Person?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return;

            if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells["PersonID"].Value))
                MessageBox.Show("Deleted Successfully", "Succussed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("Deleted Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtValueFilter.Visible = false;
                _PeopleView.RowFilter = "";
                lblRecordsCount.Text = _PeopleView.Count.ToString();
                return;
            }

            txtValueFilter.Visible = true;
            _PeopleView.RowFilter = "";
            lblRecordsCount.Text = _PeopleView.Count.ToString();
            txtValueFilter.Clear();
        }

        private void txtValueFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterBy(_GetColumnName());
        }

        private void txtValueFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
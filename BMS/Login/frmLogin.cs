using BMS.GlobalClasses;
using BMS_Business;
using System;
using System.Windows.Forms;

namespace BMS.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private clsUser _User = null;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if(clsGlobal.GetStoredUserNameAndPasswordFromFile(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                ckbRememberMe.Checked = true;
                return;
            }

            ckbRememberMe.Checked = false;
        }

        private void ckbShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowHidePassword.Checked)
            {
                ckbShowHidePassword.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                ckbShowHidePassword.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void _Clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = clsUser.IsExist(txtUserName.Text, clsUtil.EncryptPassword(txtPassword.Text));
            
            if(_User == null)
            {
                MessageBox.Show("InValid UserName Or Password", "InValid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Clear();
                txtUserName.Focus();                
                return;
            }

            if (_User != null)
            {
                if (ckbRememberMe.Checked)
                    clsGlobal.RememberUserNameAndPassword(txtUserName.Text, clsUtil.EncryptPassword(txtPassword.Text));
                else
                    clsGlobal.RememberUserNameAndPassword("", "");

                if(!_User.IsActive)
                {
                    MessageBox.Show("Your Account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Clear();
                    return;
                }

                clsGlobal.CurrentUser = _User;
                this.Hide();
                frmMain Main = new frmMain(this);
                Main.ShowDialog();
            }
        }
    }
}
using BMS.Authors;
using BMS.Books;
using BMS.Borrowing;
using BMS.Categories;
using BMS.Fines;
using BMS.GlobalClasses;
using BMS.Login;
using BMS.People;
using BMS.Reservations;
using BMS.Users;
using System;
using System.Windows.Forms;

namespace BMS
{
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        public frmMain(frmLogin Login)
        {
            InitializeComponent();
            _frmLogin = Login;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).BitsPerPixel;

        }

        private void PeopleItem_Click(object sender, EventArgs e)
        {
            frmListPeople listPeople = new frmListPeople();
            listPeople.ShowDialog();
        }

        private void ManagementUsersItem_Click(object sender, EventArgs e)
        {
            frmListUsers listUsers = new frmListUsers();
            listUsers.ShowDialog();
        }

        private void SignOutItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Hide();
            _frmLogin.Show();
        }

        private void CurrentUserInfoItem_Click(object sender, EventArgs e)
        {
            frmShowCurrentUserInfo currentUserInfo = new frmShowCurrentUserInfo(clsGlobal.CurrentUser.UserID);
            currentUserInfo.Show();
        }

        private void ChangePasswordItem_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            changePassword.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManagementAuthorsItem_Click(object sender, EventArgs e)
        {
            frmListAuthors listAuthors = new frmListAuthors();
            listAuthors.ShowDialog();
        }

        private void ManagementCategoriesItem_Click(object sender, EventArgs e)
        {
            frmListCategories listCategories = new frmListCategories();
            listCategories.ShowDialog();
        }

        private void ManagementBooksItem_Click(object sender, EventArgs e)
        {
            frmListBooks listBooks = new frmListBooks();
            listBooks.ShowDialog();
        }

        private void AddBorrowItem_Click(object sender, EventArgs e)
        {
            frmNewBorrow AddBorrow = new frmNewBorrow();
            AddBorrow.ShowDialog();
        }

        private void ManagementBorrowingItem_Click(object sender, EventArgs e)
        {
            frmListBorrowing listBorrowing = new frmListBorrowing();
            listBorrowing.ShowDialog();
        }

        private void ReleaseBorrowItem_Click(object sender, EventArgs e)
        {
            frmReleaseBorrow releaseBorrow = new frmReleaseBorrow();
            releaseBorrow.ShowDialog();
        }

        private void AddReservationItem_Click(object sender, EventArgs e)
        {
            frmNewReserve newReserve = new frmNewReserve();
            newReserve.ShowDialog();
        }

        private void ManagementReservationsItem_Click(object sender, EventArgs e)
        {
            frmListReservations listReservations = new frmListReservations();
            listReservations.ShowDialog();
        }

        private void ReleaseReserveItem_Click(object sender, EventArgs e)
        {
            frmReleaseReserve releaseReserve = new frmReleaseReserve();
            releaseReserve.ShowDialog();
        }

        private void ManagementFinesItem_Click(object sender, EventArgs e)
        {
            frmListFines listFines = new frmListFines();
            listFines.ShowDialog();
        }

        private void AddFineItem_Click(object sender, EventArgs e)
        {
            frmNewFine newFine = new frmNewFine();
            newFine.ShowDialog();
        }
    }
}
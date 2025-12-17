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

namespace BMS.Books.BookCopies.Controls
{
    public partial class ctrlBookCopiesCard : UserControl
    {
        public int BookID => ctrlBookCard1.BookID;
        private clsBookCopy _BookCopies = null;
        public clsBookCopy SelectedBookCopyInfo => _BookCopies;

        public ctrlBookCopiesCard()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblBookCopiesCount.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        public void LoadBookCopiesInfo(int BookID)
        {
            clsBook Book = clsBook.FindByID(BookID);

            if(Book == null)
            {
                return;
            }

            ctrlBookCard1.LoadBookInfo(BookID);
            lblBookCopiesCount.Text = Book.GetBookCopiesCount().ToString();
            lblCreatedBy.Text = Book.UserInfo.UserName;
        }
    }
}
using BMS_DataAccess;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace BMS_Business
{
    public class clsBorrow
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int BorrowID {  get; set; }
        public int BookCopyID { get; set; }
        public int PersonID { get; set; }
        public DateTime BorrowingDate { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public bool IsActive { get; set; }
        public int ReleaseByUserID { get; set; }

        public clsBookCopy BookCopyInfo { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsUser CreateUserInfo { get; set; }
        public clsUser ReleaseUserInfo { get; set; }

        public clsBorrow()
        {
            BorrowID = -1;
            BookCopyID = -1;
            PersonID = -1;
            BorrowingDate = DateTime.Now;
            DueDate = BorrowingDate.AddDays(clsSetting.GetDefaultDaysToBorrow());
            ActualReturnDate = new DateTime(1, 1, 1);
            IsActive = false;
            ReleaseByUserID = -1;
            Mode = enMode.Add;
        }

        private clsBorrow
            (
                int BorrowID, int BookCopyID, int PersonID, DateTime BorrowingDate, int CreatedByUserID,
                DateTime DueDate, DateTime ActualReturnDate, bool IsActive, int ReleasedByUserID
            )
        {
            this.BorrowID = BorrowID;
            this.BookCopyID = BookCopyID;
            this.PersonID = PersonID;
            this.BorrowingDate = BorrowingDate;
            this.CreatedByUserID = CreatedByUserID;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            this.IsActive = IsActive;
            this.ReleaseByUserID = ReleasedByUserID;
            BookCopyInfo = clsBookCopy.Find(this.BookCopyID);
            PersonInfo = clsPerson.Find(this.PersonID);
            CreateUserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            ReleaseUserInfo = clsUser.FindByUserID(this.ReleaseByUserID);
            Mode = enMode.Update;
        }

        public static clsBorrow Find(int BorrowID)
        {
            int BookCopyID = -1, PersonID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime BorrowingDate = DateTime.Now, DueDate = BorrowingDate.AddDays(clsSetting.GetDefaultDaysToBorrow());
            DateTime ActualReturnDate = new DateTime(1, 1, 1);
            bool IsActive = false;

            bool IsFind = clsBorrowData.GetBorrowInfoByID
                (
                    BorrowID, ref BookCopyID, ref PersonID, ref BorrowingDate, ref CreatedByUserID,
                    ref DueDate, ref ActualReturnDate, ref IsActive, ref ReleasedByUserID
                );

            if (IsFind)
                return new clsBorrow
                    (
                        BorrowID, BookCopyID, PersonID, BorrowingDate, CreatedByUserID,
                        DueDate, ActualReturnDate, IsActive, ReleasedByUserID
                    );

            return null;
        }

        public static clsBorrow FindByBookIDAndCopyID(int BookID, int BookCopyID)
        {
            int BorrowID = -1, PersonID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime BorrowingDate = DateTime.Now, DueDate = BorrowingDate.AddDays(clsSetting.GetDefaultDaysToBorrow());
            DateTime ActualReturnDate = new DateTime(1, 1, 1);
            bool IsActive = false;

            bool IsFind = clsBorrowData.GetBorrowInfoByBookIDAndCopyID
                (
                    BookID, BookCopyID, ref BorrowID, ref PersonID, ref BorrowingDate, 
                    ref CreatedByUserID,
                    ref DueDate, ref ActualReturnDate, ref IsActive, ref ReleasedByUserID
                );

            if (IsFind)
                return new clsBorrow
                    (
                        BorrowID, BookCopyID, PersonID, BorrowingDate, CreatedByUserID,
                        DueDate, ActualReturnDate, IsActive, ReleasedByUserID
                    );

            return null;
        }


        public static clsBorrow FindByTitleAndCopyID(string Title, int BookCopyID)
        {
            int BorrowID = -1, PersonID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime BorrowingDate = DateTime.Now, DueDate = BorrowingDate.AddDays(clsSetting.GetDefaultDaysToBorrow());
            DateTime ActualReturnDate = new DateTime(1, 1, 1);
            bool IsActive = false;

            bool IsFind = clsBorrowData.GetBorrowInfoByTitleAndCopyID
                (
                    Title, BookCopyID, ref BorrowID, ref PersonID, ref BorrowingDate,
                    ref CreatedByUserID,
                    ref DueDate, ref ActualReturnDate, ref IsActive, ref ReleasedByUserID
                );

            if (IsFind)
                return new clsBorrow
                    (
                        BorrowID, BookCopyID, PersonID, BorrowingDate, CreatedByUserID,
                        DueDate, ActualReturnDate, IsActive, ReleasedByUserID
                    );

            return null;
        }

        public static clsBorrow FindByISBNAndCopyID(string ISBN, int BookCopyID)
        {
            int BorrowID = -1, PersonID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime BorrowingDate = DateTime.Now, DueDate = BorrowingDate.AddDays(clsSetting.GetDefaultDaysToBorrow());
            DateTime ActualReturnDate = new DateTime(1, 1, 1);
            bool IsActive = false;

            bool IsFind = clsBorrowData.GetBorrowInfoByISBNAndCopyID
                (
                    ISBN, BookCopyID, ref BorrowID, ref PersonID, ref BorrowingDate,
                    ref CreatedByUserID,
                    ref DueDate, ref ActualReturnDate, ref IsActive, ref ReleasedByUserID
                );

            if (IsFind)
                return new clsBorrow
                    (
                        BorrowID, BookCopyID, PersonID, BorrowingDate, CreatedByUserID,
                        DueDate, ActualReturnDate, IsActive, ReleasedByUserID
                    );

            return null;
        }

        private bool _AddNewBorrow()
        {
            this.BorrowID = clsBorrowData.AddNewBorrow(this.BookCopyID, this.PersonID, this.BorrowingDate,this.CreatedByUserID, this.DueDate);
            return (this.BorrowID != -1);
        }

        private bool _UpdateBorrow()
        {
            return clsBorrowData.UpdateBorrow(this.BorrowID, this.BookCopyID, this.ActualReturnDate, this.IsActive, this.ReleaseByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewBorrow())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateBorrow();
            }
            return false;
        }

        public static bool DeleteBorrow(int BorrowID) => clsBorrowData.DeleteBorrow(BorrowID);

        public static bool DoesPersonHasBorrowForBookCopy(int BookID, int PersonID)
        {
            return clsBorrowData.DoesPersonHasBorrowForBookCopy(BookID, PersonID);
        }

        public static DataTable GetAllBorrowing() => clsBorrowData.GetAllBorrowing();
    }
}
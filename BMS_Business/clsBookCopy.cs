using BMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BMS_Business
{
    public class clsBookCopy
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int BookCopyID {  get; set; }
        public string BookCopyName { get; set; }
        public int BookID { get; set; }
        public bool IsActive { get; set; }

        public string Title => clsBook.FindByID(this.BookID).Title;

        public int BookCopiesCount { get; set; }

        //public clsBook BookInfo { get; set; }

        public clsBookCopy()
        {
            BookCopyID = -1;
            BookCopyName = "";
            BookID = -1;
            IsActive = true;
            Mode = enMode.Add;
        }

        private clsBookCopy(int BookCopyID, string BookCopyName, int BookID, bool IsActive)
        {
            this.BookCopyID = BookCopyID;
            this.BookCopyName = BookCopyName;
            this.BookID = BookID;
            this.IsActive = IsActive;
            //BookInfo = clsBook.FindByID(this.BookID);
            Mode = enMode.Update;
        }

        public static clsBookCopy Find(int BookCopyID)
        {
            string BookCopyName = "";
            int BookID = -1;
            bool IsActive = true;

            bool IsFind = clsBookCopyData.GetBookCopyInfoByID(BookCopyID, ref BookCopyName, ref BookID, ref IsActive);

            if (IsFind)
                return new clsBookCopy(BookCopyID, BookCopyName, BookID, IsActive);

            return null;
        }

        private bool _AddNewBookCopy()
        {
            for(short Counter = 0; Counter < this.BookCopiesCount; Counter++)
            {
                this.BookCopyID = clsBookCopyData.AddBookCopy(this.BookID, $"{this.BookCopyName}_Copy", this.IsActive);

                if (this.BookCopyID == -1)
                    return false;
            }

            return true;
        }

        private bool _UpdateBookCopy()
        {
            return clsBookCopyData.UpdateBookCopy(this.BookCopyID, this.BookID, this.BookCopyName, this.IsActive);
        }

        public bool UpdateBookCopyStatus()
        {
            return clsBookCopyData.UpdateBookCopyStatus(this.BookCopyID, this.IsActive);
        }

        public static bool DeleteBookCopy(int BookCopyID)
        {
            return clsBookCopyData.DeleteBookCopy(BookCopyID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewBookCopy())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateBookCopy();
            }
            return false;
        }

        public static DataTable GetAllBookCopies()
        {
            return clsBookCopyData.GetAllBookCopies();
        }

        public static int GetBookCopiesCount(int BookID)
        {
            return clsBookCopyData.GetBookCopiesCount(BookID);
        }

        public static List<clsBookCopy> GetBookCopiesInfoByBookID(int BookID)
        {
            DataTable dtBookCopies = clsBookCopyData.GetBookCopiesInfoByBookID(BookID);

            clsBookCopy BookCopy = null;

            List<clsBookCopy> listBookCopies = new List<clsBookCopy>();

            if (dtBookCopies == null)
                return null;

            foreach (DataRow Row in dtBookCopies.Rows)
            {
                BookCopy = new clsBookCopy();
                BookCopy.BookCopyID = (int)Row["BookCopyID"];
                BookCopy.BookCopyName = (string)Row["BookCopyName"];
                BookCopy.BookID = (int)Row["BookID"];
                BookCopy.IsActive = (bool)Row["IsActive"];

                listBookCopies.Add(BookCopy);
                BookCopy = null;
            }

            return listBookCopies;
        }

        public static DataTable GetBookCopiesHistory(int BookID)
        {
            return clsBookCopyData.GetBookCopiesHistory(BookID);
        }
    }
}
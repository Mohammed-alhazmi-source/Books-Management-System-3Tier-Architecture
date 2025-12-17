using BMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace BMS_Business
{
    public class clsBook
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int CategoryID { get; set; }
        public string AdditionalDetials { get; set; }
        public DateTime PublisherDate { get; set; }
        public string ImagePath { get; set; }
        public int CreatedByUserID { get; set; }

        public clsCategory CategoryInfo { get; set; }
        public clsUser UserInfo { get; set; }
        public List<clsBookCopy> BookCopiesInfo { get; set; }

        public clsBook()
        {
            BookID = -1;
            Title = "";
            ISBN = "";
            CategoryID = -1;
            AdditionalDetials = "";
            PublisherDate = DateTime.Now;
            ImagePath = "";
            CreatedByUserID = -1;
            Mode = enMode.Add;
        }

        private clsBook(int BookID, string Title, string ISBN, int CategoryID, string AdditionalDetials, 
            DateTime PublisherDate, string ImagePath, int CreatedByUserID)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.ISBN = ISBN;
            this.CategoryID = CategoryID;
            this.AdditionalDetials = AdditionalDetials;
            this.PublisherDate = PublisherDate;
            this.ImagePath = ImagePath;
            this.CreatedByUserID = CreatedByUserID;
            CategoryInfo = clsCategory.Find(this.CategoryID);
            UserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            BookCopiesInfo = clsBookCopy.GetBookCopiesInfoByBookID(this.BookID);
            Mode = enMode.Update;
        }

        public static clsBook FindByID(int BookID)
        {
            string Title = "", ISBN = "", AdditionalDetials = "", ImagePath = "";
            int CategoryID = -1, CreatedByUserID = -1;
            DateTime PublisherDate = DateTime.Now;

            bool IsFind = clsBookData.GetBookInfoByID
                (
                    BookID, ref Title, ref ISBN, ref CategoryID, ref AdditionalDetials, ref PublisherDate,
                    ref ImagePath, ref CreatedByUserID
                );

            if (IsFind)
                return new clsBook(BookID, Title, ISBN, CategoryID, AdditionalDetials, PublisherDate,
                    ImagePath, CreatedByUserID);

            return null;
        }

        public static clsBook FindByTitle(string Title)
        {
            int CategoryID = -1, CreatedByUserID = -1, BookID = -1;
            string ISBN = "", AdditionalDetials = "", ImagePath = "";
            DateTime PublisherDate = DateTime.Now;

            bool IsFind = clsBookData.GetBookInfoByTitle
                (
                    Title, ref BookID, ref ISBN, ref CategoryID, ref AdditionalDetials, ref PublisherDate,
                    ref ImagePath, ref CreatedByUserID
                );

            if (IsFind)
                return new clsBook(BookID, Title, ISBN, CategoryID, AdditionalDetials, PublisherDate,
                    ImagePath, CreatedByUserID);

            return null;
        }

        public static clsBook FindByISBN(string ISBN)
        {
            int CategoryID = -1, CreatedByUserID = -1, BookID = -1;
            string Title = "", AdditionalDetials = "", ImagePath = "";
            DateTime PublisherDate = DateTime.Now;

            bool IsFind = clsBookData.GetBookInfoByISBN
                (
                    ISBN, ref BookID, ref Title, ref CategoryID, ref AdditionalDetials, ref PublisherDate,
                    ref ImagePath, ref CreatedByUserID
                );

            if (IsFind)
                return new clsBook(BookID, Title, ISBN, CategoryID, AdditionalDetials, PublisherDate,
                    ImagePath, CreatedByUserID);

            return null;
        }

        private bool _AddNewBook()
        {
            this.BookID = clsBookData.AddNewBook
                (
                    this.Title, this.ISBN, this.CategoryID, this.AdditionalDetials, this.PublisherDate,
                    this.ImagePath, this.CreatedByUserID
                );

            return (this.BookID != -1);
        }

        private bool _UpdateBook()
        {
            return clsBookData.UpdateBook(this.BookID, this.Title, this.CategoryID, this.AdditionalDetials, this.ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateBook();
            }
            return false;
        }

        public static bool DeleteBook(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }

        public static bool IsBookExistByISBN(string ISBN)
        {
            return clsBookData.IsBookExistByISBN(ISBN);
        }

        public static bool IsBookExistByTitle(string Title)
        {
            return clsBookData.IsBookExistByTitle(Title);
        }

        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }

        public static int GetBookCopiesCount(int BookID)
        {
            return clsBookCopy.GetBookCopiesCount(BookID);
        }

        public int GetBookCopiesCount()
        {
            return clsBookCopy.GetBookCopiesCount(this.BookID);
        }

        public static DataTable GetBookCopiesHistory(int BookID)
        {
            return clsBookCopy.GetBookCopiesHistory(BookID);
        }

        public DataTable GetBookCopiesHistory()
        {
            return clsBookCopy.GetBookCopiesHistory(this.BookID);
        }

        public static DataTable GetAuthorsBookHistory(int BookID)
        {
            return clsBookAuthor.GetAuthorsBookHistory(BookID);
        }

        public DataTable GetAuthorsBookHistory()
        {
            return clsBookAuthor.GetAuthorsBookHistory(this.BookID);
        }
    }
}
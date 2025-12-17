using BMS_DataAccess;
using System;
using System.Data;

namespace BMS_Business
{
    public class clsBookAuthor
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int Author_Book_ID { get; set; }
        public int AuthorID { get; set; }
        public int BookID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsAuthor AuthorInfo { get; set; }
        public clsBook BookInfo { get; set; }

        public clsBookAuthor()
        {
            Author_Book_ID = -1;
            AuthorID = -1;
            BookID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.Add;
        }

        private clsBookAuthor(int Author_Book_ID, int AuthorID, int BookID, DateTime CreatedDate)
        {
            this.Author_Book_ID = Author_Book_ID;
            this.AuthorID = AuthorID;
            this.BookID = BookID;
            this.CreatedDate = CreatedDate;
            AuthorInfo = clsAuthor.FindByAuthorID(this.AuthorID);
            BookInfo = clsBook.FindByID(this.BookID);
            Mode = enMode.Update;
        }

        public static clsBookAuthor Find(int Author_Book_ID)
        {
            int AuthorID = -1, BookID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFind = clsBookAuthorData.GetBookAuthorInfoByID(Author_Book_ID, ref AuthorID, ref BookID, ref CreatedDate);

            if (IsFind)
                return new clsBookAuthor(Author_Book_ID, AuthorID, BookID, CreatedDate);

            return null;
        }

        public static clsBookAuthor FindByAuthorID(int AuthorID)
        {
            int Author_Book_ID = -1, BookID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFind = clsBookAuthorData.GetAuthorInfoByAuthorID(AuthorID, ref Author_Book_ID, ref BookID, ref CreatedDate);

            if (IsFind)
                return new clsBookAuthor(Author_Book_ID, AuthorID, BookID, CreatedDate);

            return null;
        }

        public static clsBookAuthor FindByBookID(int BookID)
        {
            int Author_Book_ID = -1, AuthorID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFind = clsBookAuthorData.GetAuthorInfoByBookID(BookID, ref AuthorID, ref Author_Book_ID, ref CreatedDate);

            if (IsFind)
                return new clsBookAuthor(Author_Book_ID, AuthorID, BookID, CreatedDate);

            return null;
        }

        private bool _AddNewAuthor_Book()
        {
            this.Author_Book_ID = clsBookAuthorData.AddNewBookAndAuthor(AuthorID, BookID);
            return (this.Author_Book_ID != -1);
        }

        private bool _Update()
        {
            return clsBookAuthorData.Update(this.Author_Book_ID, this.AuthorID, this.BookID, this.CreatedDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewAuthor_Book())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _Update();
            }
            return false;
        }

        public static bool Delete(int Author_Book_ID)
        {
            return clsBookAuthorData.Delete(Author_Book_ID);
        }

        public static bool IsAuthorAndBookExist(int AuthorID, int BookID)
        {
            return clsBookAuthorData.IsAuthorAndBookExist(AuthorID, BookID);
        }

        public static bool IsAuthorExist(int  AuthorID)
        {
            return clsBookAuthorData.IsAuthorExist(AuthorID);
        }

        public static DataTable GetAllAuthorsAndBooks() => clsBookAuthorData.GetAllAuthorsAndBooks();

        public static DataTable GetAuthorsBookHistory(int BookID)
        {
            return clsBookAuthorData.GetAuthorsBookHistory(BookID);
        }

        public static DataTable GetBooksAuthorHistory(int AuthorID)
        {
            return clsBookAuthorData.GetBooksAuthorHistory(AuthorID);   
        }
    }
}
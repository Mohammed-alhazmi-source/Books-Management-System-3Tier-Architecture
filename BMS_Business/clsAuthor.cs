using BMS_DataAccess;
using System.Data;

namespace BMS_Business
{
    public class clsAuthor
    {        
        public enum enMode { Add = 0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int AuthorID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }

        public clsPerson PersonInfo { get; set; }
        public clsUser UserInfo { get; set; }

        public clsAuthor()
        {
            AuthorID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            Mode = enMode.Add;
        }

        private clsAuthor(int AuthorID, int PersonID, int CreatedByUserID)
        {
            this.AuthorID = AuthorID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            PersonInfo = clsPerson.Find(this.PersonID);
            UserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            Mode = enMode.Update;
        }

        public static clsAuthor FindByAuthorID(int AuthorID)
        {
            int PersonID = -1, CreatedByUserID = -1;

            bool IsFound = clsAuthorData.GetAuthorInfoByID(AuthorID, ref PersonID, ref CreatedByUserID);

            if (IsFound)
                return new clsAuthor(AuthorID, PersonID, CreatedByUserID);

            return null;
        }

        public static clsAuthor FindByPersonID(int PersonID)
        {
            int AuthorID = -1, CreatedByUserID = -1;

            bool IsFound = clsAuthorData.GetAuthorInfoByPersonID(PersonID, ref AuthorID, ref CreatedByUserID);

            if (IsFound)
                return new clsAuthor(AuthorID, PersonID, CreatedByUserID);

            return null;
        }

        private bool _AddNewAuthor()
        {
            this.AuthorID = clsAuthorData.AddNewAuthor(this.PersonID, this.CreatedByUserID);
            return (this.AuthorID != -1);
        }

        private bool _UpdateAuthor()
        {
            return clsAuthorData.UpdateAuthor(this.AuthorID, this.PersonID);
        }

        public static bool DeleteAuthor(int AuthorID)
        {
            return clsAuthorData.DeleteAuthor(AuthorID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewAuthor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateAuthor();
            }
            return false;
        }

        public static bool IsAuthorExistForPerson(int  PersonID)
        {
            return clsAuthorData.IsAuthorExistForPerson(PersonID);
        }

        public static DataTable GetAllAuthors()
        {
            return clsAuthorData.GetAllAuthors();
        }

        public static DataTable GetBooksAuthorHistory(int AuthorID)
        {
            return clsBookAuthorData.GetBooksAuthorHistory(AuthorID);
        }

        public DataTable GetBooksAuthorHistory()
        {
            return clsBookAuthorData.GetBooksAuthorHistory(this.AuthorID);
        }
    }
}
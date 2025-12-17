using BMS_DataAccess;
using System;
using System.Data;

namespace BMS_Business
{
    public class clsReserve
    {
        public enum enMode { Add = 0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int ReserveID {  get; set; }
        public int PersonID { get; set; }
        public int BookCopyID { get; set; }
        public DateTime ReserveDate { get; set; }
        public int CreatedByUserID { get; set; }
        public bool ReserveStatus { get; set; }
        public DateTime ReleaseReserveDate { get; set; }
        public int ReleasedByUserID { get; set; }

        public clsBook BookInfo => clsBook.FindByID(this.BookCopyInfo.BookID);

        public clsPerson PersonInfo { get; set; }
        public clsBookCopy BookCopyInfo { get; set; }
        public clsUser CreatedByUserInfo { get; set; }
        public clsUser ReleasedByUserInfo { get; set; }

        // GetReserveInfoByISBNAndBookCopyID
        public clsReserve()
        {
            ReserveID = -1;
            PersonID = -1;
            BookCopyID = -1;
            ReserveDate = DateTime.Now;
            CreatedByUserID = -1;
            ReserveStatus = false;
            ReleaseReserveDate = new DateTime(1, 1, 1);
            ReleasedByUserID = -1;
            Mode = enMode.Add;
        }

        private clsReserve
            (
                int ReserveID, int PersonID, int BookCopyID, DateTime ReserveDate, int CreatedByUserID,
                bool ReserveStatus, DateTime ReleaseReserveDate, int ReleasedByUserID
            )
        {
            this.ReserveID = ReserveID;
            this.PersonID = PersonID;
            this.BookCopyID = BookCopyID;
            this.ReserveDate = ReserveDate;
            this.CreatedByUserID = CreatedByUserID;
            this.ReserveStatus = ReserveStatus;
            this.ReleaseReserveDate = ReleaseReserveDate;
            this.ReleasedByUserID = ReleasedByUserID;
            PersonInfo = clsPerson.Find(this.PersonID);
            BookCopyInfo = clsBookCopy.Find(this.BookCopyID);
            CreatedByUserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            ReleasedByUserInfo = clsUser.FindByUserID(this.ReleasedByUserID);
            Mode = enMode.Update;
        }


        public static clsReserve Find(int ReserveID)
        {
            int PersonID = -1, BookCopyID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime ReserveDate = DateTime.Now, ReleaseReserveDate = new DateTime(1, 1, 1);
            bool ReserveStatus = false;

            bool IsFind = clsReserveData.GetReserveInfoByID
                            (
                                ReserveID, ref PersonID, ref BookCopyID, ref ReserveDate, ref CreatedByUserID,
                                ref ReserveStatus, ref ReleaseReserveDate, ref ReleasedByUserID
                            );

            if (IsFind)
                return new clsReserve
                    (
                        ReserveID, PersonID, BookCopyID, ReserveDate, CreatedByUserID, ReserveStatus,
                        ReleaseReserveDate, ReleasedByUserID
                    );

            return null;
        }



        public static clsReserve FindByISBNAndBookCopyIDAndPersonID(string ISBN, int BookCopyID, int PersonID)
        {
            int ReserveID = -1,CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime ReserveDate = DateTime.Now, ReleaseReserveDate = new DateTime(1, 1, 1);
            bool ReserveStatus = false;

            bool IsFind = clsReserveData.GetReserveInfoByISBNAndBookCopyID
                            (
                                ISBN,BookCopyID,PersonID, ref ReserveID, ref ReserveDate, ref CreatedByUserID,
                                ref ReserveStatus, ref ReleaseReserveDate, ref ReleasedByUserID
                            );

            if (IsFind)
                return new clsReserve
                    (
                        ReserveID, PersonID, BookCopyID, ReserveDate, CreatedByUserID, ReserveStatus,
                        ReleaseReserveDate, ReleasedByUserID
                    );

            return null;
        }


        public static clsReserve FindByTitleAndBookCopyIDAndPersonID(string Title, int BookCopyID, int PersonID)
        {
            int ReserveID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime ReserveDate = DateTime.Now, ReleaseReserveDate = new DateTime(1, 1, 1);
            bool ReserveStatus = false;

            bool IsFind = clsReserveData.GetReserveInfoByTitleAndBookCopyID
                            (
                                Title, BookCopyID, PersonID, ref ReserveID, ref ReserveDate, ref CreatedByUserID,
                                ref ReserveStatus, ref ReleaseReserveDate, ref ReleasedByUserID
                            );

            if (IsFind)
                return new clsReserve
                    (
                        ReserveID, PersonID, BookCopyID, ReserveDate, CreatedByUserID, ReserveStatus,
                        ReleaseReserveDate, ReleasedByUserID
                    );

            return null;
        }


        public static clsReserve FindByBookIDAndBookCopyIDAndPersonID(int BookID, int BookCopyID, int PersonID)
        {
            int ReserveID = -1, CreatedByUserID = -1, ReleasedByUserID = -1;
            DateTime ReserveDate = DateTime.Now, ReleaseReserveDate = new DateTime(1, 1, 1);
            bool ReserveStatus = false;

            bool IsFind = clsReserveData.GetReserveInfoByBookIDAndBookCopyID
                            (
                                BookID, BookCopyID, PersonID, ref ReserveID, ref ReserveDate, ref CreatedByUserID,
                                ref ReserveStatus, ref ReleaseReserveDate, ref ReleasedByUserID
                            );

            if (IsFind)
                return new clsReserve
                    (
                        ReserveID, PersonID, BookCopyID, ReserveDate, CreatedByUserID, ReserveStatus,
                        ReleaseReserveDate, ReleasedByUserID
                    );

            return null;
        }



        private bool _AddNewReserve()
        {
            this.ReserveID = clsReserveData.AddNewReserve(this.PersonID, this.BookCopyID, this.ReserveDate, this.CreatedByUserID, this.ReserveStatus);
            return (this.ReserveID != -1);
        }

        private bool _UpdateReserve()
        {
            return clsReserveData.UpdateReserve(this.ReserveID, this.ReleaseReserveDate, this.ReleasedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewReserve())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateReserve();
            }
            return false;
        }

        public static bool DeleteReserve(int ReserveID)
        {
            return clsReserveData.DeleteReserve(ReserveID);
        }

        public static bool IsBookCopyReserved(int PersonID, int BookID)
        {
            return clsReserveData.IsBookCopyReserved(PersonID, BookID);
        }

        public bool IsBookCopyReserved()
        {
            return clsReserveData.IsBookCopyReserved(PersonID, this.BookInfo.BookID);
        }

        public static DataTable GetAllReservations() => clsReserveData.GetAllReservations();
    }
}
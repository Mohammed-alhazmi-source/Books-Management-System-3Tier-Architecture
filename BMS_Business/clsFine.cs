using BMS_DataAccess;
using System.Data;

namespace BMS_Business
{
    public class clsFine
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int FineID {  get; set; }
        public int PersonID { get; set; }
        public int BorrowID { get; set; }
        public decimal FineAmount { get; set; }
        public int CreatedByUserID { get; set; }

        public clsBorrow BorrowInfo { get; set; }
        public clsUser UserInfo { get; set; }

        public clsFine()
        {
            FineID = -1;
            PersonID = -1;
            BorrowID = -1;
            FineAmount = 0;
            CreatedByUserID = -1;
            Mode = enMode.Add;
        }

        private clsFine (int FineID, int PersonID, int BorrowID, decimal FineAmount, int CreatedByUserID)
        {
            this.FineID = FineID;
            this.PersonID = PersonID;
            this.BorrowID = BorrowID;
            this.FineAmount = FineAmount;
            this.CreatedByUserID = CreatedByUserID;
            BorrowInfo = clsBorrow.Find(this.BorrowID);
            UserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            Mode = enMode.Update;
        }

        public static clsFine Find(int FineID)
        {
            int PersonID = -1, BorrowID = -1, CreatedByUserID = -1;
            decimal FineAmount = 0;

            bool IsFind = clsFineData.GetFineInfoByID(FineID, ref PersonID, ref BorrowID, ref FineAmount, ref CreatedByUserID);

            if (IsFind)
                return new clsFine(FineID, PersonID, BorrowID, FineAmount, CreatedByUserID);

            return null;
        }

        public static clsFine FindByPersonIDAndBorrowID(int PersonID, int BorrowID)
        {
            int FineID = -1, CreatedByUserID = -1;
            decimal FineAmount = 0;

            bool IsFind = clsFineData.GetFineInfoByPersonIDAndBorrowID
                (
                    PersonID, BorrowID, ref FineID, ref FineAmount, ref CreatedByUserID
                );

            if (IsFind)
                return new clsFine(FineID, PersonID, BorrowID, FineAmount, CreatedByUserID);

            return null;
        }


        private bool _AddNewFine()
        {
            this.FineID = clsFineData.AddNewFine(PersonID, BorrowID, FineAmount, CreatedByUserID);
            return (this.FineID != -1);
        }

        private bool _UpdateFine()
        {
            return clsFineData.UpdateFine(this.FineID, this.PersonID, this.BorrowID, this.FineAmount, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewFine())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateFine();
            }
            return false;
        }

        public static bool DeleteFine(int FineID) => clsFineData.DeleteFine(FineID);

        public static DataTable GetAllFines() => clsFineData.GetAllFines();

        public static bool IsPersonFineFeesToBorrow(int PersonID, int BorrowID)
        {
            return clsFineData.IsPersonFineFeesToBorrow(PersonID, BorrowID);
        }
    }
}
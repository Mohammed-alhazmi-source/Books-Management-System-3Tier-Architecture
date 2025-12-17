using BMS_DataAccess;
using System.Data;

namespace BMS_Business
{
    public class clsCategory
    {
        public enum enMode { Add =  0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int CategoryID {  get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser UserInfo { get; set; }

        public clsCategory()
        {
            CategoryID = -1;
            CategoryName = "";
            IsActive = true;
            CreatedByUserID = -1;
            Mode = enMode.Add;
        }

        private clsCategory(int CategoryID, string CategoryName, bool IsActive, int CreatedByUserID)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            UserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            Mode = enMode.Update;
        }

        public static clsCategory Find(int CategoryID)
        {
            string CategoryName = "";
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFind = clsCategoryData.GetCategoryInfoByID(CategoryID, ref CategoryName, ref IsActive, ref CreatedByUserID);

            if (IsFind)
                return new clsCategory(CategoryID, CategoryName, IsActive, CreatedByUserID);

            return null;
        }

        public static clsCategory Find(string CategoryName)
        {
            int CategoryID = -1;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFind = clsCategoryData.GetCategoryInfoByName(CategoryName, ref CategoryID, ref IsActive, ref CreatedByUserID);

            if (IsFind)
                return new clsCategory(CategoryID, CategoryName, IsActive, CreatedByUserID);

            return null;
        }

        private bool _AddNewCategory()
        {
            this.CategoryID = clsCategoryData.AddNewCategory(this.CategoryName, this.IsActive, this.CreatedByUserID);
            return (this.CategoryID != -1);
        }

        private bool _UpdateCategory()
        {
            return clsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName, this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewCategory())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update: return _UpdateCategory();
            }
            return false;
        }

        public static bool DeleteCategory(int CategoryID)
        {
            return clsCategoryData.DeleteCategory(CategoryID);
        }

        public static bool IsExist(string CategoryName)
        {
            return clsCategoryData.IsExist(CategoryName);
        }

        public static DataTable GetAllCategories()
        {
            return clsCategoryData.GetAllCategories();
        }

        public static DataTable GetAllCategoriesActive()
        {
            return clsCategoryData.GetAllCategoriesActive();
        }
    }
}
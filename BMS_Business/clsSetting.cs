using BMS_DataAccess;

namespace BMS_Business
{
    public class clsSetting
    {
        public enum enMode { Add = 0, Update = 1 };
        public enMode Mode = enMode.Add;

        public int SettingID {  get; set; }
        public int DefaultDaysToBorrow { get; set; }
        public decimal DefaultPricePreDay { get; set; }

        public static int GetDefaultDaysToBorrow()
        {
            return clsSettingData.GetDefaultDaysToBorrow();
        }

        public static decimal GetDefaultPricePreDay()
        {
            return clsSettingData.GetDefaultPricePreDay();
        }
    }
}
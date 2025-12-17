using System;

namespace BMS.GlobalClasses
{
    public class clsFormat
    {
        public static string DateToString(DateTime date) => date.ToString("dd/MMM/yyyy");
    }
}
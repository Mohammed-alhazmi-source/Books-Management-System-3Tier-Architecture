using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BMS.GlobalClasses
{
    public static class clsValidation
    {
        public static bool ValidateEmail(string EmailAddress)
        {
            if (EmailAddress.StartsWith("@")) return false;

            else if (EmailAddress.EndsWith("@")) return false;

            int Index = -1;
            if (EmailAddress.Contains("@"))
                Index = EmailAddress.IndexOf('@');

            if (Index == -1) return false;

            string PrefixEmail = EmailAddress.Substring(0, Index);
            EmailAddress = EmailAddress.Remove(0, Index);
            string EmailSyntax = EmailAddress.Substring(0, EmailAddress.Length);

            if (EmailSyntax == "@gmail.com" && !string.IsNullOrEmpty(PrefixEmail)) return true;

            return false;


            // منطق متقدم
            //if (string.IsNullOrWhiteSpace(Email))
            //    return false;

            //// نمط Regex المعياري للتحقق من معظم الإيميلات الصالحة
            //string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            //// استخدام الـ Regex.IsMatch
            //return Regex.IsMatch(Email, emailPattern);

        }

        //public static bool ValidateEmail(string emailAddress)
        //{
        //    var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        //    var regex = new Regex(pattern);

        //    return regex.IsMatch(emailAddress);
        //}

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }
    }
}
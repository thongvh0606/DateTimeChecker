using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    class Checker
    {
        public Checker()
        {

        }
        public static byte DaysInMonth(ushort year, byte month)
        {
            IList<byte> monthHave31Days = new byte[7] { 1, 3, 5, 7, 8, 10, 12 };
            IList<byte> monthHave30Days = new byte[4] { 4, 6, 9, 11 };
            if (monthHave31Days.Contains(month))
            {
                return 31;
            }
            else if (monthHave30Days.Contains(month))
            {
                return 30;
            }
            else if (month == 2)
            {
                if (year % 400 == 0)
                {
                    return 29;
                }
                else if (year % 100 == 0)
                {
                    return 28;//*********
                }
                else if (year % 4 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            return 0;
        }
        public static Boolean IsValiDate(ushort year, byte month, byte day)
        {
            if (month >= 1 && month <= 12)
            {
                if (day >= 1)
                {
                    if (day <= DaysInMonth(year, month))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}

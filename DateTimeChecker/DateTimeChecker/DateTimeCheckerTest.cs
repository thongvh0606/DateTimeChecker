using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeChecker;


namespace DateTimeChecker
{
    [TestFixture]
    class DateTimeCheckerTest
    {
        #region Test DaysInMonth Fuction without February
        [TestCase(0, 0)]
        [TestCase(1, 31)]
        [TestCase(3, 31)]
        [TestCase(4, 30)]
        [TestCase(6, 30)]
        [TestCase(12, 31)]
        [TestCase(13, 0)]
        public void DaysInMonthWithoutFebruary(byte month, byte expectedDays)
        {
            Assert.AreEqual(expectedDays, Checker.DaysInMonth(2000, month));
        }
        #endregion     

        #region Test DaysInMonth Fuction in February
        [TestCase(2, 28, 1111)]//not leap year
        //[TestCase(2, 29, 1000)]//leap year
        //[TestCase(2, 29, 3000)]//leap year
        [TestCase(2, 29, 1064)]//leap year - year divisible by 4
        [TestCase(2, 29, 2000)]//leap year - year divisible by 400
        [TestCase(2, 28, 2100)]//leap year - year divisible by 100 but not 400 -> not leap year        
        public void DaysInMonthFebruary(byte month, byte expectedDays, short year)
        {
            ushort y = (ushort)year;//exception in unitest
            Assert.AreEqual(expectedDays, Checker.DaysInMonth(y, month));
        }
        #endregion

        #region Test IsValidDate Function
        [TestCase(2000, 13, 29, false)]//Wrong month
        [TestCase(2000, 1, 32, false)]//Wrong day
        [TestCase(1111, 2, 29, false)]//Correct day
        [TestCase(2100, 2, 28, true)]//Correct day
        [TestCase(2100, 2, 29, false)]//Incorrect day --- 
        [TestCase(1000, 2, 1, true)]//Correct day        
        [TestCase(1234, 12, 31, true)]//Correct day
        public void IsValidDate(short year, byte monnth, byte day, bool expectedResult)
        {
            ushort y = (ushort)year;
            Assert.AreEqual(expectedResult, Checker.IsValiDate(y, monnth, day));
        }
        #endregion

    }


}

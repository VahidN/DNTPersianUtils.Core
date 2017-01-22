using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class PersianCultureTests
    {
        [TestMethod]
        public void Test_GetPersianWeekDayName_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.GetPersianWeekDayName();
            Assert.AreEqual(expected: "سه شنبه", actual: actual);
        }

        [TestMethod]
        public void Test_GetPersianMonthName_Works()
        {
            var actual = 10.GetPersianMonthName();
            Assert.AreEqual(expected: "دی", actual: actual);
        }

        [TestMethod]
        public void Test_PersianCulture_Works()
        {
            Assert.IsTrue(PersianCulture.Instance.Calendar is PersianCalendar);
            Assert.IsTrue(PersianCulture.Instance.DateTimeFormat.Calendar is PersianCalendar);
        }
    }
}
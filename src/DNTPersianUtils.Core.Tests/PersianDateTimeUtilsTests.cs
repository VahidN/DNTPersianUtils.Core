using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class PersianDateTimeUtilsTests
    {
        [TestMethod]
        public void Test_ToGregorianDateTime_Works()
        {
            var dt = "1395/11/3 7:30";
            var actual = dt.ToGregorianDateTime();
            Assert.AreEqual(expected: new DateTime(2017, 1, 22, 7, 30, 0), actual: actual.Value);
        }

        [TestMethod]
        public void Test_ToGregorianDateTime_Works_Correctly()
        {
            var dt = "1395/11/3 17:30";
            var actual = dt.ToGregorianDateTime();
            Assert.AreEqual(expected: new DateTime(2017, 1, 22, 17, 30, 0), actual: actual.Value);
        }

        [TestMethod]
        public void Test_ToLongPersianDateString_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.ToLongPersianDateString();
            Assert.AreEqual(expected: "21 دی 1395", actual: actual);
        }

        [TestMethod]
        public void Test_ToLongPersianDateTimeString_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.ToLongPersianDateTimeString();
            Assert.AreEqual(expected: "21 دی 1395، 10:20:02 ق.ظ", actual: actual);
        }

        [TestMethod]
        public void Test_ToShortPersianDateString_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.ToShortPersianDateString();
            Assert.AreEqual(expected: "1395/10/21", actual: actual);
        }

        [TestMethod]
        public void Test_ToShortPersianDateTimeString_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.ToShortPersianDateTimeString();
            Assert.AreEqual(expected: "1395/10/21 10:20", actual: actual);
        }
    }
}
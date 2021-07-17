using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class GenericsPersianDateTimeUtilsTests
    {
        [TestMethod]
        public void Test_ConvertToPersianDay_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var actual = dt.ConvertToPersianDay();
            Assert.AreEqual(expected: new PersianDay { Year = 1395, Month = 10, Day = 21 }, actual: actual);
        }
    }
}
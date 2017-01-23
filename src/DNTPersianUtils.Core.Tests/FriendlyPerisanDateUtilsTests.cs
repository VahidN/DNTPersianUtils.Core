using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class FriendlyPersianDateUtilsTests
    {
        [TestMethod]
        public void Test_DateTimeOffset_Works()
        {
            var iranStandardTimeZone = TimeZoneInfo.GetSystemTimeZones()
                                                   .First(timeZoneInfo => timeZoneInfo.StandardName.Contains("Iran"));
            Assert.AreEqual(expected: "Iran Standard Time", actual: iranStandardTimeZone.Id);

            var irTzi = TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");
            Assert.AreEqual(expected: "Iran Standard Time", actual: irTzi.Id);

            var utcNow = DateTime.UtcNow;
            var now = DateTime.Now;
            var utcOffset = iranStandardTimeZone.GetUtcOffset(utcNow);
            var dtoNow = new DateTimeOffset(now, utcOffset);

            Assert.AreEqual(expected: dtoNow.UtcDateTime, actual: utcNow);
        }

        [TestMethod]
        public void Test_ToFriendlyPersianDateTextify_With_DtoUtcNow_Works()
        {
            var dt = DateTimeOffset.UtcNow.AddMinutes(-3);
            var actual = dt.ToFriendlyPersianDateTextify();
            Console.WriteLine(actual);
            Assert.IsTrue(actual.Contains("دقیقه قبل"));
        }

        [TestMethod]
        public void Test_ToFriendlyPersianDateTextify_With_Now_Works()
        {
            var dt = DateTime.Now.AddMinutes(-3);
            var actual = dt.ToFriendlyPersianDateTextify();
            Console.WriteLine(actual);
            Assert.IsTrue(actual.Contains("دقیقه قبل"));
        }

        [TestMethod]
        public void Test_ToFriendlyPersianDateTextify_With_UtcNow_Works()
        {
            var dt = DateTime.UtcNow.AddMinutes(-3);
            var actual = dt.ToFriendlyPersianDateTextify();
            Console.WriteLine(actual);
            Assert.IsTrue(actual.Contains("دقیقه قبل"));
        }

        [TestMethod]
        public void Test_ToFriendlyPersianDateTextify_Works()
        {
            var dt = new DateTime(2017, 1, 10, 10, 20, 2);
            var comparisonBase = new DateTime(2017, 1, 20);
            var actual = dt.ToFriendlyPersianDateTextify(comparisonBase);
            Assert.AreEqual(expected: $"{UnicodeConstants.RleChar}۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰", actual: actual);
        }

        [TestMethod]
        public void Test_ToPersianDateTextify_Works()
        {
            var dt = new DateTime(2017, 1, 10);
            var actual = dt.ToPersianDateTextify();
            Assert.AreEqual(expected: "سه شنبه ۲۱ دی ۱۳۹۵", actual: actual);
        }
    }
}
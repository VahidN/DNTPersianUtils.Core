using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class FriendlyPersianDateUtilsTests
{
    [TestMethod]
    public void Test_DateTimeOffset_Works()
    {
        var iranStandardTimeZone = TimeZoneInfo.GetSystemTimeZones()
            .First(timeZoneInfo => timeZoneInfo.StandardName.Contains(value: "Iran"));

        Assert.IsTrue(iranStandardTimeZone.Id.StartsWith(value: "Iran", StringComparison.Ordinal));

        var irTzi = TimeZoneInfo.FindSystemTimeZoneById(id: "Iran Standard Time");
        Assert.IsTrue(irTzi.Id.StartsWith(value: "Iran", StringComparison.Ordinal));

        // This part will work if your local time is Iran's time
        /*
        var utcNow = DateTime.UtcNow;
        var now = DateTime.Now;
        var utcOffset = iranStandardTimeZone.GetUtcOffset(utcNow);
        var dtoNow = now.ToDateTimeOffset(utcOffset);

        Assert.AreEqual(expected: dtoNow.UtcDateTime.ToString("dd-MM-yyyy HH:mm:ss.fffff"), actual: utcNow.ToString("dd-MM-yyyy HH:mm:ss.fffff"));
        */
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_With_DtoUtcNow_Works()
    {
        var dt = DateTimeOffset.UtcNow.AddMinutes(minutes: -3);
        var actual = dt.ToFriendlyPersianDateTextify();
        Console.WriteLine(actual);
        Assert.IsTrue(actual.Contains(value: "دقیقه قبل"));
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_With_Now_Works()
    {
        var dt = DateTime.Now.AddMinutes(value: -3);
        var actual = dt.ToFriendlyPersianDateTextify();
        Console.WriteLine(actual);
        Assert.IsTrue(actual.Contains(value: "قبل"));
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_With_UtcNow_Works()
    {
        var dt = DateTime.UtcNow.AddMinutes(value: -3);
        var actual = dt.ToFriendlyPersianDateTextify();
        Console.WriteLine(actual);
        Assert.IsTrue(actual.Contains(value: "دقیقه قبل"));
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_Works()
    {
        var dt = new DateTime(year: 2017, month: 1, day: 10, hour: 10, minute: 20, second: 2);
        var comparisonBase = new DateTime(year: 2017, month: 1, day: 20);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase);
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل، سه‌شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰", actual);
    }

    [TestMethod]
    public void Test_ToPersianDateTextify_Works()
    {
        var dt = new DateTime(year: 2017, month: 1, day: 10);
        var actual = dt.ToPersianDateTextify();
        Assert.AreEqual(expected: "سه‌شنبه ۲۱ دی ۱۳۹۵", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_WithoutTime_Works()
    {
        var dt = new DateTime(year: 2017, month: 1, day: 10, hour: 10, minute: 20, second: 2);
        var comparisonBase = new DateTime(year: 2017, month: 1, day: 20);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase, appendHhMm: false);
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل، سه‌شنبه ۲۱ دی ۱۳۹۵", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_WithoutDate_Works()
    {
        var dt = new DateTime(year: 2017, month: 1, day: 10, hour: 10, minute: 20, second: 2);
        var comparisonBase = new DateTime(year: 2017, month: 1, day: 20);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase, appendHhMm: false, includePersianDate: false);
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianTimeSpanString_Works()
    {
        var dt = new TimeSpan(days: 1, hours: 2, minutes: 3, seconds: 4, milliseconds: 5);
        var actual = dt.ToFriendlyPersianTimeSpanString();
        Assert.AreEqual(expected: "\u202bیک روز و دو ساعت و سه دقیقه و چهار ثانیه", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_Example_1_Works()
    {
        var dt = new DateTime(year: 1387, month: 8, day: 3, hour: 1, minute: 1, second: 1, new PersianCalendar());
        var comparisonBase = new DateTime(year: 2025, month: 2, day: 11);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase);
        Assert.AreEqual(expected: "\u202b۱۶ سال و ۳ ماه قبل، جمعه ۳ آبان ۱۳۸۷، ساعت ۰۱:۰۱", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_Example_2_Works()
    {
        var dt = new DateTime(year: 1387, month: 11, day: 27, hour: 1, minute: 1, second: 1, new PersianCalendar());
        var comparisonBase = new DateTime(year: 2025, month: 2, day: 11);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase);
        Assert.AreEqual(expected: "\u202b۱۵ سال و ۱۱ ماه قبل، یکشنبه ۲۷ بهمن ۱۳۸۷، ساعت ۰۱:۰۱", actual);
    }
}
﻿using System;
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
                                               .First(timeZoneInfo => timeZoneInfo.StandardName.Contains("Iran"));
        Assert.IsTrue(iranStandardTimeZone.Id.StartsWith("Iran", StringComparison.Ordinal));

        var irTzi = TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");
        Assert.IsTrue(irTzi.Id.StartsWith("Iran", StringComparison.Ordinal));

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
        Assert.IsTrue(actual.Contains("قبل"));
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
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل، سه‌شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰", actual);
    }

    [TestMethod]
    public void Test_ToPersianDateTextify_Works()
    {
        var dt = new DateTime(2017, 1, 10);
        var actual = dt.ToPersianDateTextify();
        Assert.AreEqual("سه‌شنبه ۲۱ دی ۱۳۹۵", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_WithoutTime_Works()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var comparisonBase = new DateTime(2017, 1, 20);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase, false);
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل، سه‌شنبه ۲۱ دی ۱۳۹۵", actual);
    }

    [TestMethod]
    public void Test_ToFriendlyPersianDateTextify_WithoutDate_Works()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var comparisonBase = new DateTime(2017, 1, 20);
        var actual = dt.ToFriendlyPersianDateTextify(comparisonBase, false, includePersianDate: false);
        Assert.AreEqual($"{UnicodeConstants.RleChar}۱۰ روز قبل", actual);
    }
}
using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranTimeZoneInfoTests
{
    [TestMethod]
    public void Test_IranDaylightTime_works()
    {
        var irTz = IranTimeZoneInfo.Instance;
        var isDaylightSavingTime = irTz.IsDaylightSavingTime(new DateTime(1402, 01, 13, new PersianCalendar()));
        Assert.IsFalse(isDaylightSavingTime);

        isDaylightSavingTime = irTz.IsDaylightSavingTime(new DateTime(1401, 01, 13, new PersianCalendar()));
        Assert.IsTrue(isDaylightSavingTime);

        isDaylightSavingTime = irTz.IsDaylightSavingTime(new DateTime(1400, 01, 13, new PersianCalendar()));
        Assert.IsTrue(isDaylightSavingTime);
    }
}
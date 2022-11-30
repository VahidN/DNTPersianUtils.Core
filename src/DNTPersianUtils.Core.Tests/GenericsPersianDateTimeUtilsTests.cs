using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class GenericsPersianDateTimeUtilsTests
{
    [TestMethod]
    public void Test_ConvertToPersianDay_Works()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.ConvertToPersianDay();
        Assert.AreEqual(new PersianDay { Year = 1395, Month = 10, Day = 21 }, actual);
    }

    [TestMethod]
    public void Test_UpdateTimeOfDayPart_Works_With_DateTime()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        var expected = new DateTime(2017, 1, 10, 11, 10, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_UpdateTimeOfDayPart_Works_With_Nullable_DateTime_With_Value()
    {
        DateTime? dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        DateTime? expected = new DateTime(2017, 1, 10, 11, 10, 0);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_UpdateTimeOfDayPart_Works_With_Nullable_DateTime()
    {
        DateTime? dt = null;
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        DateTime? expected = null;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_UpdateTimeOfDayPart_Works_With_Nullable_DateTimeOffset()
    {
        DateTimeOffset? dt = null;
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        DateTimeOffset? expected = null;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_UpdateTimeOfDayPart_Works_With_DateTimeOffset()
    {
        var dt = new DateTimeOffset(2017, 1, 10, 10, 20, 2, TimeSpan.FromHours(3.5));
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        var expected = new DateTimeOffset(2017, 1, 10, 11, 10, 0, TimeSpan.FromHours(3.5));
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Test_GetTimeOfDayPart_Works()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.GetTimeOfDayPart();
        Assert.AreEqual(new TimeSpan(10, 20, 2), actual);
    }
}
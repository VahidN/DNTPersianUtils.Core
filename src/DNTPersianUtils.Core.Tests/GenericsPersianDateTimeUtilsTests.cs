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
    public void Test_UpdateTimeOfDayPart_Works()
    {
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.UpdateTimeOfDayPart(new TimeSpan(11, 10, 0));
        var expected = new DateTime(2017, 1, 10, 11, 10, 0);
        Assert.AreEqual(expected, actual);
    }
}
using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranTimeZoneInfoTests
{
    [DataTestMethod, DataRow(1356, 01, 13, true), DataRow(1370, 01, 13, true), DataRow(1385, 01, 13, false),
     DataRow(1386, 01, 13, false), DataRow(1399, 01, 13, true), DataRow(1399, 07, 13, false),
     DataRow(1400, 01, 13, true), DataRow(1400, 07, 13, false), DataRow(1401, 01, 13, true),
     DataRow(1402, 01, 13, false), DataRow(1403, 01, 13, false), DataRow(1404, 01, 13, false),
     DataRow(1405, 01, 13, false), DataRow(1405, 07, 13, false)]
    public void Test_IranDaylightTime_works(int year, int month, int day, bool isDaylightSavingTimeActive)
    {
        var irTz = IranTimeZoneInfo.Instance;
        var dateTimeUtc = new DateTime(year, month, day, 1, 1, 1, 1, new PersianCalendar(), DateTimeKind.Utc);
        var isDaylightSavingTime = irTz.IsDaylightSavingTime(dateTimeUtc);
        Assert.AreEqual(isDaylightSavingTimeActive, isDaylightSavingTime);

        var localIranDateTime = TimeZoneInfo.ConvertTime(dateTimeUtc, irTz);

        Assert.IsTrue(isDaylightSavingTimeActive
            ? localIranDateTime is { Hour: 5, Minute: 31 }
            : localIranDateTime is { Hour: 4, Minute: 31 });
    }
}
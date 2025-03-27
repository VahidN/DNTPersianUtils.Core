using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class PersianCultureTests
{
    [TestMethod]
    public void Test_GetPersianWeekDayName_Works()
    {
        var dt = new DateTime(year: 2017, month: 1, day: 10, hour: 10, minute: 20, second: 2);
        var actual = dt.GetPersianWeekDayName();
        Assert.AreEqual(expected: "سه‌شنبه", actual);
    }

    [TestMethod]
    public void Test_GetPersianMonthName_Works()
    {
        var actual = 10.GetPersianMonthName();
        Assert.AreEqual(expected: "دی", actual);
    }

    [TestMethod]
    public void Test_PersianCulture_Works()
    {
        Assert.IsTrue(PersianCulture.Instance.Calendar is PersianCalendar);
        Assert.IsTrue(PersianCulture.Instance.DateTimeFormat.Calendar is PersianCalendar);
    }

    [TestMethod]
    public void Test_GetPersianYear_Works()
    {
        var date = new DateTime(year: 2014, month: 4, day: 20);
        var year = date.GetPersianYear();

        Assert.AreEqual(year, actual: 1393);
    }

    [TestMethod]
    public void Test_GetPersianMonth_Works()
    {
        var date = new DateTime(year: 2014, month: 4, day: 20);
        var month = date.GetPersianMonth();

        Assert.AreEqual(month, actual: 1);
    }

    [TestMethod]
    public void Test_GetPersianDayOfMonth_Works()
    {
        var date = new DateTime(year: 2014, month: 4, day: 20);
        var dayOfMonth = date.GetPersianDayOfMonth();

        Assert.AreEqual(dayOfMonth, actual: 31);
    }

    [TestMethod]
    public void Test_PersianStopwords_Works() => Assert.IsTrue(PersianStopwords.List.Contains(item: "احتراما"));

    [TestMethod]
    public void Test_ApplyRle_Works() => Assert.IsTrue("سلام".ApplyRle().StartsWith(UnicodeConstants.RleChar));

    [TestMethod]
    public void Test_WrapInDirectionalDiv_Works()
        => Assert.IsTrue("تست".WrapInDirectionalDiv()
            .Equals(value: "<div style='text-align: right; font-family:tahoma; font-size:9pt;' dir='rtl'>تست</div>"));

    [TestMethod]
    public void Test_GetPersianYearStartAndEndDates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var persianYear = 1397.GetPersianYearStartAndEndDates();
        Assert.AreEqual(new DateTime(year: 1397, month: 1, day: 1, persianCalendar), persianYear.StartDate);

        Assert.AreEqual(new DateTime(year: 1397, month: 12, day: 29, hour: 23, minute: 59, second: 59, persianCalendar),
            persianYear.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var persianMonth = 1397.GetPersianMonthStartAndEndDates(persianMonth: 5);
        Assert.AreEqual(new DateTime(year: 1397, month: 5, day: 1, persianCalendar), persianMonth.StartDate);

        Assert.AreEqual(new DateTime(year: 1397, month: 5, day: 31, hour: 23, minute: 59, second: 59, persianCalendar),
            persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_Works_For_Leap_Years()
    {
        var persianCalendar = new PersianCalendar();
        var persianMonth = 1403.GetPersianMonthStartAndEndDates(persianMonth: 12);
        Assert.AreEqual(new DateTime(year: 1403, month: 12, day: 1, persianCalendar), persianMonth.StartDate);

        Assert.AreEqual(new DateTime(year: 1403, month: 12, day: 30, hour: 23, minute: 59, second: 59, persianCalendar),
            persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_For_Dates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(year: 1398, month: 5, day: 13, persianCalendar);
        var persianMonth = date.GetPersianMonthStartAndEndDates();

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 1, persianCalendar), persianMonth.StartDate);

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 31, hour: 23, minute: 59, second: 59, persianCalendar),
            persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_1()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(year: 1398, month: 5, day: 13, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 12, persianCalendar), persianWeek.StartDate);

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 18, hour: 23, minute: 59, second: 59, persianCalendar),
            persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_Saturday()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(year: 1398, month: 5, day: 12, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 12, persianCalendar), persianWeek.StartDate);

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 18, hour: 23, minute: 59, second: 59, persianCalendar),
            persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_2()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(year: 1398, month: 5, day: 21, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 19, persianCalendar), persianWeek.StartDate);

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 25, hour: 23, minute: 59, second: 59, persianCalendar),
            persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_3()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(year: 1398, month: 5, day: 30, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(year: 1398, month: 5, day: 26, persianCalendar), persianWeek.StartDate);

        Assert.AreEqual(new DateTime(year: 1398, month: 6, day: 1, hour: 23, minute: 59, second: 59, persianCalendar),
            persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_Works_For_Leap_YearsAndDates()
    {
        var persianMonth = new PersianDay(year: 1404, month: 1, day: 1).GetPersianMonthStartAndEndDates();

        var persianCalendar = new PersianCalendar();
        Assert.AreEqual(new DateTime(year: 1404, month: 1, day: 1, persianCalendar), persianMonth.StartDate);

        Assert.AreEqual(new DateTime(year: 1404, month: 1, day: 31, hour: 23, minute: 59, second: 59, persianCalendar),
            persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_Works_For_Leap_Years_And_Dates()
    {
        var persianMonth = new PersianDay(year: 1403, month: 12, day: 1).GetPersianMonthStartAndEndDates();

        var persianCalendar = new PersianCalendar();
        Assert.AreEqual(new DateTime(year: 1403, month: 12, day: 1, persianCalendar), persianMonth.StartDate);

        Assert.AreEqual(new DateTime(year: 1403, month: 12, day: 30, hour: 23, minute: 59, second: 59, persianCalendar),
            persianMonth.EndDate);
    }
}
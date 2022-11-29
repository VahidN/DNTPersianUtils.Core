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
        var dt = new DateTime(2017, 1, 10, 10, 20, 2);
        var actual = dt.GetPersianWeekDayName();
        Assert.AreEqual("سه شنبه", actual);
    }

    [TestMethod]
    public void Test_GetPersianMonthName_Works()
    {
        var actual = 10.GetPersianMonthName();
        Assert.AreEqual("دی", actual);
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
        var date = new DateTime(2014, 4, 20);
        var year = date.GetPersianYear();

        Assert.AreEqual(year, 1393);
    }

    [TestMethod]
    public void Test_GetPersianMonth_Works()
    {
        var date = new DateTime(2014, 4, 20);
        var month = date.GetPersianMonth();

        Assert.AreEqual(month, 1);
    }

    [TestMethod]
    public void Test_GetPersianDayOfMonth_Works()
    {
        var date = new DateTime(2014, 4, 20);
        var dayOfMonth = date.GetPersianDayOfMonth();

        Assert.AreEqual(dayOfMonth, 31);
    }

    [TestMethod]
    public void Test_PersianStopwords_Works()
    {
        Assert.IsTrue(PersianStopwords.List.Contains("احتراما"));
    }

    [TestMethod]
    public void Test_ApplyRle_Works()
    {
        Assert.IsTrue("سلام".ApplyRle().StartsWith(UnicodeConstants.RleChar));
    }

    [TestMethod]
    public void Test_WrapInDirectionalDiv_Works()
    {
        Assert.IsTrue("تست".WrapInDirectionalDiv()
                           .Equals("<div style='text-align: right; font-family:tahoma; font-size:9pt;' dir='rtl'>تست</div>"));
    }

    [TestMethod]
    public void Test_GetPersianYearStartAndEndDates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var persianYear = 1397.GetPersianYearStartAndEndDates();
        Assert.AreEqual(new DateTime(1397, 1, 1, persianCalendar), persianYear.StartDate);
        Assert.AreEqual(new DateTime(1397, 12, 29, 23, 59, 59, persianCalendar), persianYear.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var persianMonth = 1397.GetPersianMonthStartAndEndDates(5);
        Assert.AreEqual(new DateTime(1397, 5, 1, persianCalendar), persianMonth.StartDate);
        Assert.AreEqual(new DateTime(1397, 5, 31, 23, 59, 59, persianCalendar), persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianMonthStartAndEndDates_For_Dates_Works()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(1398, 5, 13, persianCalendar);
        var persianMonth = date.GetPersianMonthStartAndEndDates();

        Assert.AreEqual(new DateTime(1398, 5, 1, persianCalendar), persianMonth.StartDate);
        Assert.AreEqual(new DateTime(1398, 5, 31, 23, 59, 59, persianCalendar), persianMonth.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_1()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(1398, 5, 13, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(1398, 5, 12, persianCalendar), persianWeek.StartDate);
        Assert.AreEqual(new DateTime(1398, 5, 18, 23, 59, 59, persianCalendar), persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_Saturday()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(1398, 5, 12, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(1398, 5, 12, persianCalendar), persianWeek.StartDate);
        Assert.AreEqual(new DateTime(1398, 5, 18, 23, 59, 59, persianCalendar), persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_2()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(1398, 5, 21, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(1398, 5, 19, persianCalendar), persianWeek.StartDate);
        Assert.AreEqual(new DateTime(1398, 5, 25, 23, 59, 59, persianCalendar), persianWeek.EndDate);
    }

    [TestMethod]
    public void Test_GetPersianWeekStartAndEndDates_For_Dates_Works_3()
    {
        var persianCalendar = new PersianCalendar();
        var date = new DateTime(1398, 5, 30, persianCalendar);
        var persianWeek = date.GetPersianWeekStartAndEndDates();

        Assert.AreEqual(new DateTime(1398, 5, 26, persianCalendar), persianWeek.StartDate);
        Assert.AreEqual(new DateTime(1398, 6, 1, 23, 59, 59, persianCalendar), persianWeek.EndDate);
    }
}
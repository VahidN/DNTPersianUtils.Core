using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اطلاعاتي در مورد تقويم شمسي
/// </summary>
public sealed class PersianContext(DateTime dt)
{
    /// <summary>
    ///     سال جاري شمسي
    /// </summary>
    public int Year => dt.GetPersianYear();

    /// <summary>
    ///     ماه جاري شمسي
    /// </summary>
    public int Month => dt.GetPersianMonth();

    /// <summary>
    ///     روز جاري شمسي
    /// </summary>
    public int Day => dt.GetPersianDayOfMonth();

    /// <summary>
    ///     نام ماه جاري شمسي
    /// </summary>
    public string MonthName => Month.GetPersianMonthName();

    /// <summary>
    ///     نام فارسی روز هفته
    /// </summary>
    public string WeekDayName => dt.GetPersianWeekDayName();

    /// <summary>
    ///     آيا سال جاري شمسي كبيسه است؟
    /// </summary>
    public bool IsLeapYear => dt.IsLeapYear();

    /// <summary>
    ///     آيا امروز آخرين ماه جاري شمسي است؟
    /// </summary>
    public bool IsLastDayOfMonth => dt.IsLastDayOfTheMonth();

    /// <summary>
    ///     آيا الان آغاز سال نو شمسي است؟
    /// </summary>
    public bool IsNewYearNow => dt.IsStartOfNewYear();

    /// <summary>
    ///     ارائه اطلاعاتي در مورد ابتدا و انتهاي سال شمسي
    /// </summary>
    public PersianYear YearPeriod => dt.GetPersianYearStartAndEndDates();

    /// <summary>
    ///     ارائه اطلاعاتي در مورد ابتدا و انتهاي ماه شمسي
    /// </summary>
    public PersianMonth MonthPeriod => dt.GetPersianMonthStartAndEndDates();

    /// <summary>
    ///     ارائه اطلاعاتي در مورد ابتدا و انتهاي هفته شمسي
    /// </summary>
    public PersianWeek WeekPeriod => dt.GetPersianWeekStartAndEndDates();

    /// <summary>
    ///     اجزای روز شمسی
    /// </summary>
    public PersianDay DayInfo => dt.ToPersianDay();

    /// <summary>
    ///     ساختاري بيانگر تاريخ و زمان شمسي
    /// </summary>
    public PersianDateTime DateTimeInfo => new(dt);

    /// <summary>
    ///     نمايش متني تاريخ شمسي
    /// </summary>
    public PersianTextContext Text => new(dt);

    /// <summary>
    ///     اطلاعات روزهاي كاري
    /// </summary>
    public PersianBusinessDaysContext BusinessDays => new(dt);
}
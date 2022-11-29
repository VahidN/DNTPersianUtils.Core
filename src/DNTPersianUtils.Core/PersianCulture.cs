using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Threading;

namespace DNTPersianUtils.Core;

/// <summary>
///     فرهنگ فارسی سفارشی سازی شده
/// </summary>
public static class PersianCulture
{
    private static readonly Lazy<CultureInfo> _cultureInfoBuilder =
        new(getPersianCulture, LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    ///     معادل فارسی روزهای هفته میلادی
    /// </summary>
    public static IDictionary<DayOfWeek, string> PersianDayWeekNames { get; } = new Dictionary<DayOfWeek, string>
                                                                                {
                                                                                    { DayOfWeek.Saturday, "شنبه" },
                                                                                    { DayOfWeek.Sunday, "یکشنبه" },
                                                                                    { DayOfWeek.Monday, "دوشنبه" },
                                                                                    { DayOfWeek.Tuesday, "سه‌شنبه" },
                                                                                    { DayOfWeek.Wednesday, "چهارشنبه" },
                                                                                    { DayOfWeek.Thursday, "پنجشنبه" },
                                                                                    { DayOfWeek.Friday, "جمعه" },
                                                                                };

    /// <summary>
    ///     معادل فارسی روزهای هفته میلادی
    /// </summary>
    public static IEnumerable<string> PersianDayNamesOfWeek { get; } = new List<string>
                                                                       {
                                                                           "شنبه",
                                                                           "یکشنبه",
                                                                           "دوشنبه",
                                                                           "سه‌شنبه",
                                                                           "چهارشنبه",
                                                                           "پنجشنبه",
                                                                           "جمعه",
                                                                       };

    /// <summary>
    ///     معادل کوتاه فارسی روزهای هفته میلادی
    /// </summary>
    public static IDictionary<DayOfWeek, string> ShortPersianDayNamesOfWeek { get; } = new Dictionary<DayOfWeek, string>
                                                                                       {
                                                                                           { DayOfWeek.Saturday, "ش" },
                                                                                           { DayOfWeek.Sunday, "ی" },
                                                                                           { DayOfWeek.Monday, "د" },
                                                                                           { DayOfWeek.Tuesday, "س" },
                                                                                           { DayOfWeek.Wednesday, "چ" },
                                                                                           { DayOfWeek.Thursday, "پ" },
                                                                                           { DayOfWeek.Friday, "ج" },
                                                                                       };

    /// <summary>
    ///     معادل کوتاه فارسی روزهای هفته میلادی
    /// </summary>
    public static IEnumerable<string> ShortPersianDayWeekNames { get; } = new List<string>
                                                                          {
                                                                              "ش",
                                                                              "ی",
                                                                              "د",
                                                                              "س",
                                                                              "چ",
                                                                              "پ",
                                                                              "ج",
                                                                          };

    /// <summary>
    ///     عدد به حروف روزهای شمسی
    /// </summary>
    public static IDictionary<int, string> PersianMonthDayNumberNames { get; } = new Dictionary<int, string>
                                                                                 {
                                                                                     { 1, "یکم" },
                                                                                     { 2, "دوم" },
                                                                                     { 3, "سوم" },
                                                                                     { 4, "چهارم" },
                                                                                     { 5, "پنجم" },
                                                                                     { 6, "ششم" },
                                                                                     { 7, "هفتم" },
                                                                                     { 8, "هشتم" },
                                                                                     { 9, "نهم" },
                                                                                     { 10, "دهم" },
                                                                                     { 11, "یازدهم" },
                                                                                     { 12, "دوازدهم" },
                                                                                     { 13, "سیزدهم" },
                                                                                     { 14, "چهاردهم" },
                                                                                     { 15, "پانزدهم" },
                                                                                     { 16, "شانزدهم" },
                                                                                     { 17, "هفدهم" },
                                                                                     { 18, "هجدهم" },
                                                                                     { 19, "نوزدهم" },
                                                                                     { 20, "بیستم" },
                                                                                     { 21, "بیست یکم" },
                                                                                     { 22, "بیست دوم" },
                                                                                     { 23, "بیست سوم" },
                                                                                     { 24, "بیست چهارم" },
                                                                                     { 25, "بیست پنجم" },
                                                                                     { 26, "بیست ششم" },
                                                                                     { 27, "بیست هفتم" },
                                                                                     { 28, "بیست هشتم" },
                                                                                     { 29, "بیست نهم" },
                                                                                     { 30, "سی‌ام" },
                                                                                     { 31, "سی یکم" },
                                                                                 };

    /// <summary>
    ///     نام فارسی ماه‌های شمسی
    /// </summary>
    public static IDictionary<int, string> PersianMonthNames { get; } = new Dictionary<int, string>
                                                                        {
                                                                            { 1, "فروردین" },
                                                                            { 2, "اردیبهشت" },
                                                                            { 3, "خرداد" },
                                                                            { 4, "تیر" },
                                                                            { 5, "مرداد" },
                                                                            { 6, "شهریور" },
                                                                            { 7, "مهر" },
                                                                            { 8, "آبان" },
                                                                            { 9, "آذر" },
                                                                            { 10, "دی" },
                                                                            { 11, "بهمن" },
                                                                            { 12, "اسفند" },
                                                                        };

    /// <summary>
    ///     وهله‌ی یکتای فرهنگ فارسی سفارشی سازی شده
    /// </summary>
    public static CultureInfo Instance { get; } = _cultureInfoBuilder.Value;

    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateTime" />.</returns>
    public static int GetPersianDayOfMonth(this DateTime dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dateTime = dateTime.ToIranTimeZoneDateTime();
        }

        return Instance.DateTimeFormat.Calendar.GetDayOfMonth(dateTime);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateOnly" />.</returns>
    public static int GetPersianDayOfMonth(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianDayOfMonth(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianDayOfMonth(this DateTime? dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianDayOfMonth(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateOnly" />.</returns>
    public static int? GetPersianDayOfMonth(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianDayOfMonth(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateTime" />.</returns>
    public static int GetPersianDayOfMonth(
        this DateTimeOffset dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);
        return GetPersianDayOfMonth(dt, convertToIranTimeZone);
    }

    /// <summary>
    ///     Returns the day-of-month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 31 representing the day-of-month part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianDayOfMonth(
        this DateTimeOffset? dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianDayOfMonth(dateTime.Value, convertToIranTimeZone, dateTimeOffsetPart);
    }

    /// <summary>
    ///     Returns the month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateTime" />.</returns>
    public static int GetPersianMonth(this DateTime dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dateTime = dateTime.ToIranTimeZoneDateTime();
        }

        return Instance.DateTimeFormat.Calendar.GetMonth(dateTime);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the month part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateOnly" />.</returns>
    public static int GetPersianMonth(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianMonth(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianMonth(this DateTime? dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianMonth(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the month part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateOnly" />.</returns>
    public static int? GetPersianMonth(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianMonth(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateTime" />.</returns>
    public static int GetPersianMonth(
        this DateTimeOffset dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);
        return GetPersianMonth(dt, convertToIranTimeZone);
    }

    /// <summary>
    ///     Returns the month part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianMonth(
        this DateTimeOffset? dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianMonth(dateTime.Value, convertToIranTimeZone, dateTimeOffsetPart);
    }

    /// <summary>
    ///     عدد به حروف روزهای شمسی
    /// </summary>
    public static string GetPersianMonthDayNumberName(this int dayNumber)
    {
        if (dayNumber < 1 || dayNumber > 31)
        {
            throw new ArgumentOutOfRangeException(nameof(dayNumber), $"{nameof(dayNumber)} must be between 1, 31.");
        }

        return PersianMonthDayNumberNames[dayNumber];
    }

    /// <summary>
    ///     نام فارسی ماه‌های شمسی
    /// </summary>
    public static string GetPersianMonthName(this int monthNumber)
    {
        if (monthNumber < 1 || monthNumber > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(monthNumber), $"{nameof(monthNumber)} must be between 1, 12.");
        }

        return PersianMonthNames[monthNumber];
    }

    /// <summary>
    ///     دریافت معادل فارسی نام روز هفته‌ی میلادی
    /// </summary>
    public static string GetPersianWeekDayName(this DayOfWeek dayOfWeek) => PersianDayWeekNames[dayOfWeek];

    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    public static string GetPersianWeekDayName(int persianYear, int persianMonth, int persianDay) =>
        PersianDayWeekNames
            [new PersianCalendar().ToDateTime(persianYear, persianMonth, persianDay, 0, 0, 0, 0).DayOfWeek];

    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static string GetPersianWeekDayName(this DateTime dt, bool convertToIranTimeZone = true)
    {
        if (dt.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dt = dt.ToIranTimeZoneDateTime();
        }

        var dateParts = dt.ToPersianYearMonthDay(false);
        return PersianDayWeekNames
            [new PersianCalendar().ToDateTime(dateParts.Year, dateParts.Month, dateParts.Day, dt.Hour, dt.Minute, dt.Second, 0).DayOfWeek];
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static string GetPersianWeekDayName(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianWeekDayName(convertToIranTimeZone);
#endif

    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="dt"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static string GetPersianWeekDayName(this DateTime? dt, bool convertToIranTimeZone = true) =>
        dt == null ? string.Empty : GetPersianWeekDayName(dt.Value, convertToIranTimeZone);

#if NET6_0 || NET7_0
    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static string GetPersianWeekDayName(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianWeekDayName(convertToIranTimeZone);
#endif

    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="dt">تاریخ و زمان</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static string GetPersianWeekDayName(this DateTimeOffset? dt,
                                               DateTimeOffsetPart dateTimeOffsetPart =
                                                   DateTimeOffsetPart.IranLocalDateTime) =>
        dt == null ? string.Empty : GetPersianWeekDayName(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     گرفتن نام فارسی روزهای هفته
    /// </summary>
    /// <param name="dt">تاریخ و زمان</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static string GetPersianWeekDayName(this DateTimeOffset dt,
                                               DateTimeOffsetPart dateTimeOffsetPart =
                                                   DateTimeOffsetPart.IranLocalDateTime) =>
        GetPersianWeekDayName(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     Returns the year part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateTime" />.</returns>
    public static int GetPersianYear(this DateTime dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dateTime = dateTime.ToIranTimeZoneDateTime();
        }

        return Instance.DateTimeFormat.Calendar.GetYear(dateTime);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the year part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateOnly" />.</returns>
    public static int GetPersianYear(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianYear(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the year part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianYear(this DateTime? dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianYear(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Returns the year part of this <see cref="DateOnly" /> localized in Persian calendar.
    /// </summary>
    /// <param name="date">The <see cref="DateOnly" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateOnly" />.</returns>
    public static int? GetPersianYear(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianYear(convertToIranTimeZone);
#endif

    /// <summary>
    ///     Returns the year part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateTime" />.</returns>
    public static int GetPersianYear(
        this DateTimeOffset dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);
        return GetPersianYear(dt, convertToIranTimeZone, dateTimeOffsetPart);
    }

    /// <summary>
    ///     Returns the year part of this <see cref="DateTime" /> localized in Persian calendar.
    /// </summary>
    /// <param name="dateTime">The <see cref="DateTime" /> to extend.</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="dateTimeOffsetPart">دریافت جزء زمانی ویژه‌ی این وهله</param>
    /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateTime" />.</returns>
    public static int? GetPersianYear(
        this DateTimeOffset? dateTime,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianYear(dateTime.Value, convertToIranTimeZone, dateTimeOffsetPart);
    }

    /// <summary>
    ///     تاریخ روزهای ابتدا و انتهای سال شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianYear GetPersianYearStartAndEndDates(this int persianYear)
    {
        var persianCalendar = new PersianCalendar();
        return new PersianYear
               {
                   StartDate = persianCalendar.ToDateTime(persianYear, 1, 1, 0, 0, 0, 0),
                   EndDate = persianCalendar.ToDateTime(persianYear, 12, persianYear.GetPersianMonthLastDay(12), 23, 59,
                                                        59, 0),
               };
    }

    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianYear GetPersianYearStartAndEndDates(this DateTime dateTime, bool convertToIranTimeZone = true)
    {
        var persianYear = dateTime.GetPersianYear(convertToIranTimeZone);
        return persianYear.GetPersianYearStartAndEndDates();
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianYear GetPersianYearStartAndEndDates(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianYearStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianYear? GetPersianYearStartAndEndDates(this DateTime? dateTime,
                                                              bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianYearStartAndEndDates(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianYear? GetPersianYearStartAndEndDates(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianYearStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianYear GetPersianYearStartAndEndDates(
        this DateTimeOffset dateTimeOffset,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var persianYear = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart).GetPersianYear();
        return persianYear.GetPersianYearStartAndEndDates();
    }

    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianYear? GetPersianYearStartAndEndDates(
        this DateTimeOffset? dateTimeOffset,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTimeOffset is null)
        {
            return null;
        }

        return GetPersianYearStartAndEndDates(dateTimeOffset.Value, dateTimeOffsetPart);
    }

    /// <summary>
    ///     تاریخ روزهای ابتدا و انتهای ماه شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianMonth GetPersianMonthStartAndEndDates(this int persianYear, int persianMonth)
    {
        var persianCalendar = new PersianCalendar();
        var startDate = persianCalendar.ToDateTime(persianYear, persianMonth, 1, 0, 0, 0, 0);
        var endDate = persianCalendar.ToDateTime(persianYear, persianMonth,
                                                 persianYear.GetPersianMonthLastDay(persianMonth), 23, 59, 59, 0);
        return new PersianMonth
               {
                   StartDate = startDate,
                   EndDate = endDate,
                   LastDayNumber = GetPersianMonthLastDay(persianYear, persianMonth),
                   StartDateDayOfWeek = startDate.DayOfWeek.GetPersianWeekDayNumber(),
                   EndDateDayOfWeek = endDate.DayOfWeek.GetPersianWeekDayNumber(),
               };
    }

    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianMonth GetPersianMonthStartAndEndDates(this DateTime dateTime,
                                                               bool convertToIranTimeZone = true)
    {
        var persianYear = dateTime.GetPersianYear(convertToIranTimeZone);
        var persianMonth = dateTime.GetPersianMonth(convertToIranTimeZone);
        return persianYear.GetPersianMonthStartAndEndDates(persianMonth);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianMonth GetPersianMonthStartAndEndDates(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianMonthStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianMonth? GetPersianMonthStartAndEndDates(this DateTime? dateTime,
                                                                bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianMonthStartAndEndDates(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianMonth?
        GetPersianMonthStartAndEndDates(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianMonthStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianMonth GetPersianMonthStartAndEndDates(this DateTimeOffset dateTimeOffset,
                                                               DateTimeOffsetPart dateTimeOffsetPart =
                                                                   DateTimeOffsetPart.IranLocalDateTime)
    {
        var dateTime = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart);
        var persianYear = dateTime.GetPersianYear();
        var persianMonth = dateTime.GetPersianMonth();
        return persianYear.GetPersianMonthStartAndEndDates(persianMonth);
    }

    /// <summary>
    ///     ماه شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianMonth? GetPersianMonthStartAndEndDates(this DateTimeOffset? dateTimeOffset,
                                                                DateTimeOffsetPart dateTimeOffsetPart =
                                                                    DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTimeOffset is null)
        {
            return null;
        }

        return GetPersianMonthStartAndEndDates(dateTimeOffset.Value, dateTimeOffsetPart);
    }

    /// <summary>
    ///     تاریخ روزهای ابتدا و انتهای هفته شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianWeek GetPersianWeekStartAndEndDates(this int persianYear, int persianMonth, int persianDay)
    {
        var dateTime = new PersianCalendar().ToDateTime(persianYear, persianMonth, persianDay, 0, 0, 0, 0);
        return GetPersianWeekStartAndEndDates(dateTime);
    }

    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianWeek GetPersianWeekStartAndEndDates(this DateTime dateTime, bool convertToIranTimeZone = true)
    {
        if (dateTime.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dateTime = dateTime.ToIranTimeZoneDateTime();
        }

        var firstDayOfWeek = Instance.DateTimeFormat.FirstDayOfWeek;
        var offset = -1 * ((7 + (dateTime.DayOfWeek - firstDayOfWeek)) % 7);
        var firstDayOfWeekDate = dateTime.AddDays(offset);
        var lastDayOfWeekDate = firstDayOfWeekDate.AddDays(6);
        return new PersianWeek
               {
                   StartDate = firstDayOfWeekDate,
                   EndDate = new DateTime(lastDayOfWeekDate.Year, lastDayOfWeekDate.Month, lastDayOfWeekDate.Day, 23,
                                          59, 59, 0),
               };
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianWeek GetPersianWeekStartAndEndDates(this DateOnly date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianWeekStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="dateTime"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianWeek? GetPersianWeekStartAndEndDates(this DateTime? dateTime,
                                                              bool convertToIranTimeZone = true)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianWeekStartAndEndDates(dateTime.Value, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    /// <param name="date"></param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static PersianWeek? GetPersianWeekStartAndEndDates(this DateOnly? date, bool convertToIranTimeZone = true) =>
        date.ToDateTime().GetPersianWeekStartAndEndDates(convertToIranTimeZone);
#endif

    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianWeek GetPersianWeekStartAndEndDates(this DateTimeOffset dateTimeOffset,
                                                             DateTimeOffsetPart dateTimeOffsetPart =
                                                                 DateTimeOffsetPart.IranLocalDateTime)
    {
        var dateTime = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart);
        return GetPersianWeekStartAndEndDates(dateTime);
    }

    /// <summary>
    ///     هفته شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن هفته شمسی را بازگشت می‌دهد
    /// </summary>
    public static PersianWeek? GetPersianWeekStartAndEndDates(this DateTimeOffset? dateTimeOffset,
                                                              DateTimeOffsetPart dateTimeOffsetPart =
                                                                  DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTimeOffset is null)
        {
            return null;
        }

        return GetPersianWeekStartAndEndDates(dateTimeOffset.Value, dateTimeOffsetPart);
    }

    /// <summary>
    ///     شماره آخرین روز ماه شمسی را بر می‌گرداند
    /// </summary>
    /// <param name="persianYear">سال شمسی</param>
    /// <param name="persianMonth">ماه شمسی</param>
    /// <returns>شماره آخرین روز ماه</returns>
    public static int GetPersianMonthLastDay(this int persianYear, int persianMonth)
    {
        if (persianMonth > 12 || persianMonth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(persianMonth), "ماه وارد شده معتبر نیست.");
        }

        if (persianMonth <= 6)
        {
            return 31;
        }

        if (persianMonth == 12)
        {
            var persianCalendar = new PersianCalendar();
            return persianCalendar.IsLeapYear(persianYear) ? 30 : 29;
        }

        return 30;
    }

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int GetPersianWeekDayNumber(this DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
               {
                   DayOfWeek.Saturday => 1,
                   DayOfWeek.Sunday => 2,
                   DayOfWeek.Monday => 3,
                   DayOfWeek.Tuesday => 4,
                   DayOfWeek.Wednesday => 5,
                   DayOfWeek.Thursday => 6,
                   DayOfWeek.Friday => 7,
                   _ => throw new ArgumentOutOfRangeException(nameof(dayOfWeek), "روز وارد شده معتبر نیست."),
               };
    }

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int GetPersianWeekDayNumber(this DateTime dateTime) => GetPersianWeekDayNumber(dateTime.DayOfWeek);

#if NET6_0 || NET7_0
    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int GetPersianWeekDayNumber(this DateOnly date) => date.ToDateTime().GetPersianWeekDayNumber();
#endif

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int? GetPersianWeekDayNumber(this DateTime? dateTime)
    {
        if (dateTime is null)
        {
            return null;
        }

        return GetPersianWeekDayNumber(dateTime.Value);
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int? GetPersianWeekDayNumber(this DateOnly? date) => date.ToDateTime().GetPersianWeekDayNumber();
#endif

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int GetPersianWeekDayNumber(this DateTimeOffset dateTimeOffset,
                                              DateTimeOffsetPart dateTimeOffsetPart =
                                                  DateTimeOffsetPart.IranLocalDateTime)
    {
        var dateTime = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart);
        return GetPersianWeekDayNumber(dateTime);
    }

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int? GetPersianWeekDayNumber(this DateTimeOffset? dateTimeOffset,
                                               DateTimeOffsetPart dateTimeOffsetPart =
                                                   DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dateTimeOffset is null)
        {
            return null;
        }

        return GetPersianWeekDayNumber(dateTimeOffset.Value, dateTimeOffsetPart);
    }

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public static int GetPersianWeekDayNumber(this int persianYear, int persianMonth) =>
        GetPersianWeekDayNumber(new PersianCalendar().ToDateTime(persianYear, persianMonth, 1, 0, 0, 0, 0));

    /// <summary>
    ///     اصلاح تقویم فرهنگ فارسی
    /// </summary>
    [SuppressMessage("Microsoft.Usage", "S3011:Make sure that this accessibility bypass is safe here",
                        Justification = "We need this to correct a mistake!")]
    private static CultureInfo getPersianCulture()
    {
        var persianCulture = new CultureInfo("fa-IR")
                             {
                                 DateTimeFormat =
                                 {
                                     AbbreviatedDayNames = new[] { "ی", "د", "س", "چ", "پ", "ج", "ش" },
                                     AbbreviatedMonthGenitiveNames =
                                         new[]
                                         {
                                             "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر",
                                             "آبان", "آذر", "دی", "بهمن", "اسفند", string.Empty,
                                         },
                                     AbbreviatedMonthNames =
                                         new[]
                                         {
                                             "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر",
                                             "آبان", "آذر", "دی", "بهمن", "اسفند", string.Empty,
                                         },
                                     AMDesignator = "ق.ظ",
                                     CalendarWeekRule = CalendarWeekRule.FirstDay,
                                     //DateSeparator = "؍",
                                     DayNames = new[]
                                                {
                                                    "یکشنبه", "دوشنبه", "سه‌شنبه", "چهار‌شنبه", "پنجشنبه", "جمعه",
                                                    "شنبه",
                                                },
                                     FirstDayOfWeek = DayOfWeek.Saturday,
                                     FullDateTimePattern = "dddd dd MMMM yyyy",
                                     LongDatePattern = "dd MMMM yyyy",
                                     LongTimePattern = "h:mm:ss tt",
                                     MonthDayPattern = "dd MMMM",
                                     MonthGenitiveNames =
                                         new[]
                                         {
                                             "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر",
                                             "آبان", "آذر", "دی", "بهمن", "اسفند", string.Empty,
                                         },
                                     MonthNames =
                                         new[]
                                         {
                                             "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر",
                                             "آبان", "آذر", "دی", "بهمن", "اسفند", string.Empty,
                                         },
                                     PMDesignator = "ب.ظ",
                                     ShortDatePattern = "yyyy/MM/dd",
                                     ShortestDayNames = new[] { "ی", "د", "س", "چ", "پ", "ج", "ش" },
                                     ShortTimePattern = "HH:mm",
                                     //TimeSeparator = ":",
                                     YearMonthPattern = "MMMM yyyy",
                                 },
                             };

        var persianCalendar = new PersianCalendar();
        var fieldInfo = persianCulture.GetType()
                                      .GetField("calendar", BindingFlags.NonPublic | BindingFlags.Instance);
        fieldInfo?.SetValue(persianCulture, persianCalendar);

        var info = persianCulture.DateTimeFormat.GetType()
                                 .GetField("calendar", BindingFlags.NonPublic | BindingFlags.Instance);
        info?.SetValue(persianCulture.DateTimeFormat, persianCalendar);

        persianCulture.NumberFormat.NumberDecimalSeparator = "/";
        persianCulture.NumberFormat.NumberNegativePattern = 0;

        return persianCulture;
    }
}
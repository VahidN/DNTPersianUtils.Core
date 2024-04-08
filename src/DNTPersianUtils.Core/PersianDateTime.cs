using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using static System.FormattableString;

namespace DNTPersianUtils.Core;

/// <summary>
///     ساختاري بيانگر تاريخ و زمان شمسي
/// </summary>
public class PersianDateTime : IEqualityComparer<PersianDateTime>
{
    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(string? persianDateTime)
    {
        var persianDateTimeValue = persianDateTime.ToPersianDateTime();
        IsValidDateTime = persianDateTimeValue is not null;

        if (!IsValidDateTime)
        {
            return;
        }

        Year = persianDateTimeValue!.Year;
        Month = persianDateTimeValue!.Month;
        Day = persianDateTimeValue!.Day;
        Hour = persianDateTimeValue!.Hour;
        Minute = persianDateTimeValue!.Minute;
        Second = persianDateTimeValue!.Second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateTime? dateTime)
    {
        var persianYearMonthDay = dateTime.ToPersianYearMonthDay();
        IsValidDateTime = persianYearMonthDay is not null;

        if (!IsValidDateTime)
        {
            return;
        }

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = dateTime!.Value.Hour;
        Minute = dateTime!.Value.Minute;
        Second = dateTime!.Value.Second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateTime dateTime)
    {
        var persianYearMonthDay = dateTime.ToPersianYearMonthDay();
        IsValidDateTime = true;

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = dateTime.Hour;
        Minute = dateTime.Minute;
        Second = dateTime.Second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateTimeOffset? dateTimeOffset)
    {
        var persianYearMonthDay = dateTimeOffset.ToPersianYearMonthDay();
        IsValidDateTime = persianYearMonthDay is not null;

        if (!IsValidDateTime)
        {
            return;
        }

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = dateTimeOffset!.Value.Hour;
        Minute = dateTimeOffset!.Value.Minute;
        Second = dateTimeOffset!.Value.Second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateTimeOffset dateTimeOffset)
    {
        var persianYearMonthDay = dateTimeOffset.ToPersianYearMonthDay();
        IsValidDateTime = true;

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = dateTimeOffset.Hour;
        Minute = dateTimeOffset.Minute;
        Second = dateTimeOffset.Second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int year, int month, int day)
    {
        IsValidDateTime = IsValidInstance(year, month, day, 0, 0, 0);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = 0;
        Minute = 0;
        Second = 0;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int? year, int? month, int? day)
    {
        IsValidDateTime = IsValidInstance(year, month, day, 0, 0, 0);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = 0;
        Minute = 0;
        Second = 0;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int year, int month, int day, int hour, int minute, int second)
    {
        IsValidDateTime = IsValidInstance(year, month, day, hour, minute, second);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int? year, int? month, int? day, int? hour, int? minute, int? second)
    {
        IsValidDateTime = IsValidInstance(year, month, day, hour, minute, second);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int year, int month, int day, int hour, int minute)
    {
        IsValidDateTime = IsValidInstance(year, month, day, hour, minute, 0);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
        Second = 0;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(int? year, int? month, int? day, int? hour, int? minute)
    {
        IsValidDateTime = IsValidInstance(year, month, day, hour, minute, 0);

        if (!IsValidDateTime)
        {
            return;
        }

        Year = year;
        Month = month;
        Day = day;
        Hour = hour;
        Minute = minute;
        Second = 0;
    }

    /// <summary>
    ///     سال شمسی
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Year { get; }

    /// <summary>
    ///     ماه شمسی
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Month { get; }

    /// <summary>
    ///     روز شمسی
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Day { get; }

    /// <summary>
    ///     ساعت
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Hour { get; }

    /// <summary>
    ///     دقيقه
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Minute { get; }

    /// <summary>
    ///     ثانيه
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? Second { get; }

    /// <summary>
    ///     آيا تاريخ و زمان جاري شمسي معتبر است؟
    /// </summary>
#if NET6_0 || NET7_0 || NET8_0
    [MemberNotNullWhen(true, nameof(Year)), MemberNotNullWhen(true, nameof(Month)),
     MemberNotNullWhen(true, nameof(Day)), MemberNotNullWhen(true, nameof(Hour)),
     MemberNotNullWhen(true, nameof(Minute)), MemberNotNullWhen(true, nameof(Second)),
     MemberNotNullWhen(true, nameof(DateTime)), MemberNotNullWhen(true, nameof(DateTimeUtc)),
     MemberNotNullWhen(true, nameof(DateTimeOffset)), MemberNotNullWhen(true, nameof(DateOnly)),
     MemberNotNullWhen(true, nameof(Holidays)), MemberNotNullWhen(true, nameof(PersianWeek)),
     MemberNotNullWhen(true, nameof(PersianMonth)), MemberNotNullWhen(true, nameof(PersianYear)),
     MemberNotNullWhen(true, nameof(PersianMonthDayNumberName)), MemberNotNullWhen(true, nameof(WeekDayName)),
     MemberNotNullWhen(true, nameof(WeekDayNumber)), MemberNotNullWhen(true, nameof(MonthName))]
#endif
    public bool IsValidDateTime { get; }

    /// <summary>
    ///     بيانگر تاريخ و زمان جاري شمسي به ميلادي. اگر تاريخ و زمان غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public DateTime? DateTime => !IsValidDateTime
        ? null
        : new PersianCalendar().ToDateTime(Year!.Value, Month!.Value, Day!.Value, Hour!.Value, Minute!.Value,
            Second!.Value, 0);

    /// <summary>
    ///     بيانگر تاريخ و زمان جاري شمسي به ميلادي. اگر تاريخ و زمان غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public DateTime? DateTimeUtc => DateTime?.ToUniversalTime();

    /// <summary>
    ///     بيانگر تاريخ و زمان جاري شمسي به ميلادي. اگر تاريخ و زمان غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public DateTimeOffset? DateTimeOffset => DateTime is null
        ? null
        : new DateTimeOffset(DateTime.Value, DateTimeUtils.IranStandardTime.BaseUtcOffset);

#if NET6_0 || NET7_0 || NET8_0
    /// <summary>
    ///     بيانگر تاريخ جاري شمسي به ميلادي. اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public DateOnly? DateOnly => DateTime.ToDateOnly();
#endif

    /// <summary>
    ///     آيا تاريخ جاري، تعطیل رسمی است؟
    /// </summary>
    public bool IsHoliday => DateTime?.IsHoliday() ?? false;

    /// <summary>
    ///     در صورت تعطیل رسمی تاريخ شمسي جاري بودن، با عناوین مناسبت‌ها مقدار دهی خواهد شد
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public IEnumerable<string>? Holidays => DateTime?.GetHolidays();

    /// <summary>
    ///     تاریخ روزهای ابتدا و انتهای هفته شمسی را بازگشت می‌دهد
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public PersianWeek? PersianWeek
        => !IsValidDateTime ? null : Year!.Value.GetPersianWeekStartAndEndDates(Month!.Value, Day!.Value);

    /// <summary>
    ///     تاریخ روزهای ابتدا و انتهای ماه شمسی را بازگشت می‌دهد
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public PersianMonth? PersianMonth
        => !IsValidDateTime ? null : Year!.Value.GetPersianMonthStartAndEndDates(Month!.Value);

    /// <summary>
    ///     سال شمسی معادل را محاسبه کرده و سپس
    ///     تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public PersianYear? PersianYear => DateTime.GetPersianYearStartAndEndDates();

    /// <summary>
    ///     عدد به حروف روز شمسی مانند يكم، دوم
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public string? PersianMonthDayNumberName => !IsValidDateTime ? null : Day!.Value.GetPersianMonthDayNumberName();

    /// <summary>
    ///     دریافت معادل فارسی نام روز هفته‌ی میلادی
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public string? WeekDayName => !IsValidDateTime
        ? null
        : PersianCulture.GetPersianWeekDayName(Year!.Value, Month!.Value, Day!.Value);

    /// <summary>
    ///     دریافت معادل عدد شمسی نام روز هفته‌ی میلادی؛ شروع شده از عدد یک.
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public int? WeekDayNumber => DateTime.GetPersianWeekDayNumber();

    /// <summary>
    ///     نام فارسی ماه‌ شمسی
    ///     اگر تاريخ غيرمعتبر باشد، نال بازگشت مي‌دهد.
    /// </summary>
    public string? MonthName => !IsValidDateTime ? null : Month!.Value.GetPersianMonthName();

    /// <inheritdoc />
    public bool Equals(PersianDateTime? x, PersianDateTime? y)
    {
        if (ReferenceEquals(x, y))
        {
            return true;
        }

        if (ReferenceEquals(x, null))
        {
            return false;
        }

        if (ReferenceEquals(y, null))
        {
            return false;
        }

        if (x.GetType() != y.GetType())
        {
            return false;
        }

        return x.Year == y.Year && x.Month == y.Month && x.Day == y.Day && x.Hour == y.Hour && x.Minute == y.Minute &&
               x.Second == y.Second;
    }

    /// <inheritdoc />
    public int GetHashCode(PersianDateTime obj) => GetCurrentHashCode(obj);

    private static bool IsValidInstance(int? year, int? month, int? day, int? hour, int? minute, int? second)
    {
        if (!year.HasValue || !month.HasValue || !day.HasValue)
        {
            return false;
        }

        hour ??= 0;
        minute ??= 0;
        second ??= 0;

        return hour.Value.IsBetween(0, 23) && minute.Value.IsBetween(0, 59) && second.Value.IsBetween(0, 59) &&
               year.Value.IsValidPersianDate(month.Value, day.Value);
    }

    /// <summary>
    ///     ToString()
    /// </summary>
    public override string ToString()
        => !IsValidDateTime
            ? ""
            : Invariant(
                $"{Year!.Value}/{Month!.Value.ToString("00", CultureInfo.InvariantCulture)}/{Day!.Value.ToString("00", CultureInfo.InvariantCulture)} {Hour!.Value:00}:{Minute!.Value:00}:{Second!.Value:00}");

    /// <summary>
    ///     Equals
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not PersianDateTime day)
        {
            return false;
        }

        return Year == day.Year && Month == day.Month && Day == day.Day && Hour == day.Hour && Minute == day.Minute &&
               Second == day.Second;
    }

    /// <summary>
    ///     GetHashCode
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode() => GetCurrentHashCode(this);

    private int GetCurrentHashCode(PersianDateTime day)
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + day.Year.GetHashCode();
            hash = hash * 23 + day.Month.GetHashCode();
            hash = hash * 23 + day.Day.GetHashCode();

            hash = hash * 23 + day.Hour.GetHashCode();
            hash = hash * 23 + day.Minute.GetHashCode();
            hash = hash * 23 + day.Second.GetHashCode();

            return hash;
        }
    }

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(string? persianDateTime) => new(persianDateTime);

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateTime? dateTime) => new(dateTime);

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateTime dateTime) => new(dateTime);

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateTimeOffset? dateTimeOffset) => new(dateTimeOffset);

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateTimeOffset dateTimeOffset) => new(dateTimeOffset);

#if NET6_0 || NET7_0 || NET8_0

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateOnly? dateOnly) => new(dateOnly);

    /// <summary>
    ///     Returns a PersianDateTime.
    /// </summary>
    public static implicit operator PersianDateTime(DateOnly dateOnly) => new(dateOnly);

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateOnly? dateOnly)
    {
        var persianYearMonthDay = dateOnly.ToPersianYearMonthDay();
        IsValidDateTime = persianYearMonthDay is not null;

        if (!IsValidDateTime)
        {
            return;
        }

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = 0;
        Minute = 0;
        Second = 0;
    }

    /// <summary>
    ///     اجزای تاريخ و زمان شمسی
    /// </summary>
    public PersianDateTime(DateOnly dateOnly)
    {
        var persianYearMonthDay = dateOnly.ToPersianYearMonthDay();
        IsValidDateTime = true;

        Year = persianYearMonthDay!.Year;
        Month = persianYearMonthDay!.Month;
        Day = persianYearMonthDay!.Day;
        Hour = 0;
        Minute = 0;
        Second = 0;
    }
#endif
}
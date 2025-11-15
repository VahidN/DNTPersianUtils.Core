using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DNTPersianUtils.Core;

/// <summary>
///     متدهای کمکی جهت کار با تاریخ میلادی
/// </summary>
public static class DateTimeUtils
{
    /// <summary>
    ///     Iran Standard Time
    /// </summary>
    public static readonly TimeZoneInfo IranStandardTime = IranTimeZoneInfo.Instance;

    /// <summary>
    ///     Epoch represented as DateTime
    /// </summary>
    public static readonly DateTime Epoch = new(year: 1970, month: 1, day: 1, hour: 0, minute: 0, second: 0,
        DateTimeKind.Utc);

    /// <summary>
    ///     محاسبه سن
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateTimeOffset birthday,
        DateTime comparisonBase,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => GetAge(birthday.GetDateTimeOffsetPart(dateTimeOffsetPart), comparisonBase);

    /// <summary>
    ///     محاسبه سن
    ///     مبنای محاسبه هم اکنون
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateTimeOffset birthday,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var birthdayDateTime = birthday.UtcDateTime;
        var now = DateTime.UtcNow;

        return GetAge(birthdayDateTime, now, dateTimeOffsetPart);
    }

    /// <summary>
    ///     محاسبه سن
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateTime birthday, DateTime comparisonBase)
    {
        var now = comparisonBase;
        var age = now.Year - birthday.Year;

        if (now < birthday.AddYears(age))
        {
            age--;
        }

        return age;
    }

    /// <summary>
    ///     محاسبه سن
    ///     مبنای محاسبه هم اکنون
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateTime birthday)
    {
        var now = birthday.Kind.GetNow();

        return GetAge(birthday, now);
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     محاسبه سن
    ///     مبنای محاسبه هم اکنون
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateOnly birthday) => birthday.ToDateTime().GetAge();
#endif
    /// <summary>
    ///     دریافت جزء زمانی ویژه‌ی این وهله
    /// </summary>
    public static DateTime GetDateTimeOffsetPart(this DateTimeOffset dateTimeOffset,
        DateTimeOffsetPart dataDateTimeOffsetPart)
        => dataDateTimeOffsetPart switch
        {
            DateTimeOffsetPart.DateTime => dateTimeOffset.DateTime,
            DateTimeOffsetPart.LocalDateTime => dateTimeOffset.LocalDateTime,
            DateTimeOffsetPart.UtcDateTime => dateTimeOffset.UtcDateTime,
            DateTimeOffsetPart.IranLocalDateTime => dateTimeOffset.ToIranTimeZoneDateTimeOffset().DateTime,
            _ => throw new ArgumentOutOfRangeException(nameof(dataDateTimeOffsetPart), dataDateTimeOffsetPart,
                message: null)
        };

    /// <summary>
    ///     بازگشت زمان جاری با توجه به نوع زمان
    /// </summary>
    /// <param name="dataDateTimeKind">نوع زمان ورودی</param>
    /// <returns>هم اکنون</returns>
    public static DateTime GetNow(this DateTimeKind dataDateTimeKind)
    {
        switch (dataDateTimeKind)
        {
            case DateTimeKind.Utc:
                return DateTime.UtcNow;
            default:
                return DateTime.Now;
        }
    }

    /// <summary>
    ///     تبدیل منطقه زمانی این وهله به منطقه زمانی ایران
    /// </summary>
    public static DateTimeOffset ToIranTimeZoneDateTimeOffset(this DateTimeOffset dateTimeOffset)
        => TimeZoneInfo.ConvertTime(dateTimeOffset, IranStandardTime);

    /// <summary>
    ///     تبدیل منطقه زمانی این وهله به منطقه زمانی ایران
    /// </summary>
    public static DateTime ToIranTimeZoneDateTime(this DateTime dateTime)
        => TimeZoneInfo.ConvertTime(dateTime, IranStandardTime);

    /// <summary>
    ///     Converts a given <see cref="DateTime" /> to milliseconds from Epoch.
    /// </summary>
    /// <param name="dateTime">A given <see cref="DateTime" /></param>
    /// <returns>Milliseconds since Epoch</returns>
    public static long ToEpochMilliseconds(this DateTime dateTime)
        => (long)dateTime.ToUniversalTime().Subtract(Epoch).TotalMilliseconds;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Converts a given <see cref="DateOnly" /> to milliseconds from Epoch.
    /// </summary>
    /// <param name="date">A given <see cref="DateOnly" /></param>
    /// <returns>Milliseconds since Epoch</returns>
    public static long ToEpochMilliseconds(this DateOnly date) => date.ToDateTime().ToEpochMilliseconds();
#endif

    /// <summary>
    ///     Converts a given <see cref="DateTime" /> to milliseconds from Epoch.
    /// </summary>
    /// <param name="dateTime">A given <see cref="DateTime" /></param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>Milliseconds since Epoch</returns>
    public static long ToEpochMilliseconds(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return ToEpochMilliseconds(dt);
    }

    /// <summary>
    ///     Converts a given <see cref="DateTime" /> to seconds from Epoch.
    /// </summary>
    /// <param name="dateTime">A given <see cref="DateTime" /></param>
    /// <returns>The Unix time stamp</returns>
    public static long ToEpochSeconds(this DateTime dateTime) => dateTime.ToEpochMilliseconds() / 1000;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Converts a given <see cref="DateOnly" /> to seconds from Epoch.
    /// </summary>
    /// <param name="date">A given <see cref="DateOnly" /></param>
    /// <returns>The Unix time stamp</returns>
    public static long ToEpochSeconds(this DateOnly date) => date.ToDateTime().ToEpochSeconds();
#endif

    /// <summary>
    ///     Converts a given <see cref="DateTime" /> to seconds from Epoch.
    /// </summary>
    /// <param name="dateTime">A given <see cref="DateTime" /></param>
    /// <param name="dateTimeOffsetPart"></param>
    /// <returns>The Unix time stamp</returns>
    public static long ToEpochSeconds(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return ToEpochSeconds(dt);
    }

    /// <summary>
    ///     Checks the given date is between the two provided dates
    /// </summary>
    public static bool IsBetween(this DateTime date, DateTime startDate, DateTime endDate, bool compareTime = false)
        => compareTime
            ? date >= startDate && date <= endDate
            : date.Date >= startDate.Date && date.Date <= endDate.Date;

    /// <summary>
    ///     Checks the given date is between the two provided dates
    /// </summary>
    public static bool IsBetween(this DateTimeOffset date,
        DateTimeOffset startDate,
        DateTimeOffset endDate,
        bool compareTime = false,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dateOff = date.GetDateTimeOffsetPart(dateTimeOffsetPart);
        var startDateOff = startDate.GetDateTimeOffsetPart(dateTimeOffsetPart);
        var endDateOff = endDate.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return IsBetween(dateOff, startDateOff, endDateOff, compareTime);
    }

    /// <summary>
    ///     Returns whether the given date is the last day of the month
    /// </summary>
    public static bool IsLastDayOfTheMonth(this DateTime dateTime)
        => dateTime == new DateTime(dateTime.Year, dateTime.Month, day: 1).AddMonths(months: 1).AddDays(value: -1);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Returns whether the given date is the last day of the month
    /// </summary>
    public static bool IsLastDayOfTheMonth(this DateOnly date) => date.ToDateTime().IsLastDayOfTheMonth();
#endif

    /// <summary>
    ///     Returns whether the given date is the last day of the month
    /// </summary>
    public static bool IsLastDayOfTheMonth(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return IsLastDayOfTheMonth(dt);
    }

    /// <summary>
    ///     Returns whether the given date falls in a weekend
    /// </summary>
    public static bool IsWeekend(this DateTime value)
        => value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Returns whether the given date falls in a weekend
    /// </summary>
    public static bool IsWeekend(this DateOnly date) => date.ToDateTime().IsWeekend();
#endif

    /// <summary>
    ///     Returns whether the given date falls in a weekend
    /// </summary>
    public static bool IsWeekend(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return IsWeekend(dt);
    }

    /// <summary>
    ///     Determines if a given year is a LeapYear or not.
    /// </summary>
    public static bool IsLeapYear(this DateTime value) => DateTime.DaysInMonth(value.Year, month: 2) == 29;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Determines if a given year is a LeapYear or not.
    /// </summary>
    public static bool IsLeapYear(this DateOnly date) => date.ToDateTime().IsLeapYear();
#endif
    /// <summary>
    ///     Determines if a given year is a LeapYear or not.
    /// </summary>
    public static bool IsLeapYear(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return IsLeapYear(dt);
    }

    /// <summary>
    ///     Converts a DateTime to a DateTimeOffset
    /// </summary>
    /// <param name="dt">Source DateTime.</param>
    /// <param name="offset">Offset</param>
    public static DateTimeOffset ToDateTimeOffset(this DateTime dt, TimeSpan offset)
    {
        if (dt == DateTime.MinValue)
        {
            return DateTimeOffset.MinValue;
        }

        return new DateTimeOffset(dt.Ticks, offset);
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Converts a Date to a DateTimeOffset
    /// </summary>
    /// <param name="date">Source Date.</param>
    /// <param name="offset">Offset</param>
    public static DateTimeOffset ToDateTimeOffset(this DateOnly date, TimeSpan offset)
        => date.ToDateTime().ToDateTimeOffset(offset);
#endif

    /// <summary>
    ///     Converts a DateTime to a DateTimeOffset
    /// </summary>
    /// <param name="dt">Source DateTime.</param>
    /// <param name="offsetInHours">Offset</param>
    public static DateTimeOffset ToDateTimeOffset(this DateTime dt, double offsetInHours = 0)
        => ToDateTimeOffset(dt, offsetInHours.ApproxEquals(d2: 0) ? TimeSpan.Zero : TimeSpan.FromHours(offsetInHours));

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Converts a Date to a DateTimeOffset
    /// </summary>
    /// <param name="date">Source Date.</param>
    /// <param name="offsetInHours">Offset</param>
    public static DateTimeOffset ToDateTimeOffset(this DateOnly date, double offsetInHours = 0)
        => date.ToDateTime().ToDateTimeOffset(offsetInHours);
#endif

    /// <summary>
    ///     Retruns dt.Date which is the start of the day
    /// </summary>
    public static DateTime GetStartOfDay(this DateTime dt) => dt.Date;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Retruns Date which is the start of the day
    /// </summary>
    public static DateTime GetStartOfDay(this DateOnly date) => date.ToDateTime().GetStartOfDay();
#endif

    /// <summary>
    ///     Retruns dateTime.Date which is the start of the day
    /// </summary>
    public static DateTime GetStartOfDay(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetStartOfDay(dt);
    }

    /// <summary>
    ///     Retruns the end of the day
    /// </summary>
    public static DateTime GetEndOfDay(this DateTime dt) => dt.Date.AddTicks(value: -1).AddDays(value: 1);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     Retruns the end of the day
    /// </summary>
    public static DateTime GetEndOfDay(this DateOnly date) => date.ToDateTime().GetEndOfDay();
#endif

    /// <summary>
    ///     Retruns the end of the day
    /// </summary>
    public static DateTime GetEndOfDay(this DateTimeOffset dateTime,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetEndOfDay(dt);
    }

    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی قبلی را باز می‌گرداند
    /// </summary>
    /// <param name="dt">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <returns></returns>
    public static DateTime GetPrevious(this DateTime dt, DayOfWeek dayOfWeek, bool includeToday = true)
    {
        if (dt.DayOfWeek == dayOfWeek)
        {
            if (includeToday)
            {
                return dt;
            }

            dt = dt.AddDays(value: 1);
        }

        var diff = (7 + (dt.DayOfWeek - dayOfWeek)) % 7;

        return dt.AddDays(-diff).Date;
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی قبلی را باز می‌گرداند
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <returns></returns>
    public static DateTime GetPrevious(this DateOnly date, DayOfWeek dayOfWeek, bool includeToday = true)
        => date.ToDateTime().GetPrevious(dayOfWeek, includeToday);
#endif

    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی قبلی را باز می‌گرداند
    /// </summary>
    /// <param name="dateTime">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns></returns>
    public static DateTime GetPrevious(this DateTimeOffset dateTime,
        DayOfWeek dayOfWeek,
        bool includeToday = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetPrevious(dt, dayOfWeek, includeToday);
    }

    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی بعدی را باز می‌گرداند
    /// </summary>
    /// <param name="dt">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <returns></returns>
    public static DateTime GetNext(this DateTime dt, DayOfWeek dayOfWeek, bool includeToday = true)
    {
        if (dt.DayOfWeek == dayOfWeek)
        {
            if (includeToday)
            {
                return dt;
            }

            dt = dt.AddDays(value: -1);
        }

        return dt.AddDays(DayOfWeek.Saturday - dt.DayOfWeek).Date;
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی بعدی را باز می‌گرداند
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <returns></returns>
    public static DateTime GetNext(this DateOnly date, DayOfWeek dayOfWeek, bool includeToday = true)
        => date.ToDateTime().GetNext(dayOfWeek, includeToday);
#endif

    /// <summary>
    ///     برای نمونه تاریخ جمعه‌ی بعدی را باز می‌گرداند
    /// </summary>
    /// <param name="dateTime">تاریخ</param>
    /// <param name="dayOfWeek">مبنای محاسبه</param>
    /// <param name="includeToday">آیا امروز هم محاسبه شود؟</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns></returns>
    public static DateTime GetNext(this DateTimeOffset dateTime,
        DayOfWeek dayOfWeek,
        bool includeToday = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var dt = dateTime.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetNext(dt, dayOfWeek, includeToday);
    }

    /// <summary>
    ///     آيا به تعداد ثانيه‌ي مشخص شده از زمان ايجاد گذشته؟
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="seconds">تعداد ثانيه پس از ايجاد</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <returns></returns>
    public static bool HasExceeded(this DateTime creationTime, int seconds, DateTime now)
        => now > creationTime.AddSeconds(seconds);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     آيا به تعداد ثانيه‌ي مشخص شده از زمان ايجاد گذشته؟
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="seconds">تعداد ثانيه پس از ايجاد</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <returns></returns>
    public static bool HasExceeded(this DateOnly creationTime, int seconds, DateOnly now)
        => HasExceeded(creationTime.ToDateTime(), seconds, now.ToDateTime());
#endif

    /// <summary>
    ///     آيا به تعداد ثانيه‌ي مشخص شده از زمان ايجاد گذشته؟
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="seconds">تعداد ثانيه پس از ايجاد</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <param name="dateTimeOffsetPart"></param>
    /// <returns></returns>
    public static bool HasExceeded(this DateTimeOffset creationTime,
        int seconds,
        DateTimeOffset now,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => HasExceeded(creationTime.GetDateTimeOffsetPart(dateTimeOffsetPart), seconds,
            now.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     بازگشت جمع ثانيه‌هاي طول عمر پس از ايجاد تاكنون
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="now">منباي مقايسه</param>
    /// <returns></returns>
    public static int GetLifetimeInSeconds(this DateTime creationTime, DateTime now)
        => (int)(now - creationTime).TotalSeconds;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     بازگشت جمع ثانيه‌هاي طول عمر پس از ايجاد تاكنون
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="now">منباي مقايسه</param>
    /// <returns></returns>
    public static int GetLifetimeInSeconds(this DateOnly creationTime, DateOnly now)
        => GetLifetimeInSeconds(creationTime.ToDateTime(), now.ToDateTime());
#endif

    /// <summary>
    ///     بازگشت جمع ثانيه‌هاي طول عمر پس از ايجاد تاكنون
    /// </summary>
    /// <param name="creationTime">زمان ايجاد</param>
    /// <param name="now">منباي مقايسه</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns></returns>
    public static int GetLifetimeInSeconds(this DateTimeOffset creationTime,
        DateTimeOffset now,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => GetLifetimeInSeconds(creationTime.GetDateTimeOffsetPart(dateTimeOffsetPart),
            now.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     آيا منقضي شده‌است؟
    /// </summary>
    /// <param name="expirationTime">زمان انقضاء</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <returns></returns>
    public static bool HasExpired(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(returnValue: true)]
#endif
        this DateTime? expirationTime,
        DateTime now)
        => expirationTime.HasValue && expirationTime.Value.HasExpired(now);

    /// <summary>
    ///     آيا منقضي شده‌است؟
    /// </summary>
    /// <param name="expirationTime">زمان انقضاء</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <returns></returns>
    public static bool HasExpired(this DateTime expirationTime, DateTime now) => now > expirationTime;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     آيا منقضي شده‌است؟
    /// </summary>
    /// <param name="expirationTime">زمان انقضاء</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <returns></returns>
    public static bool HasExpired(this DateOnly expirationTime, DateOnly now)
        => HasExpired(expirationTime.ToDateTime(), now.ToDateTime());
#endif

    /// <summary>
    ///     آيا منقضي شده‌است؟
    /// </summary>
    /// <param name="expirationTime">زمان انقضاء</param>
    /// <param name="now">مبناي مقايسه</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns></returns>
    public static bool HasExpired(this DateTimeOffset expirationTime,
        DateTimeOffset now,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => HasExpired(expirationTime.GetDateTimeOffsetPart(dateTimeOffsetPart),
            now.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     آيا زمان وارد شده معتبر است؟
    /// </summary>
    /// <param name="inputTime">زمان وارد شده مانند 10:12:1</param>
    /// <returns></returns>
    public static bool IsValidTimeValue(this string inputTime) => TimeSpan.TryParse(inputTime, out _);

    /// <summary>
    ///     آيا مقدار مدنظر بين دو مقدار مشخص و يا مساوي آن‌ها قرار مي‌گيرد؟
    /// </summary>
    public static bool IsBetween<T>(this T value, T lowest, T highest)
        where T : IComparable
        => Comparer<T>.Default.Compare(lowest, value) <= 0 && Comparer<T>.Default.Compare(highest, value) >= 0;

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     تبديل به ابتداي روز ساختار قبلي
    /// </summary>
    /// <param name="date">تاريخ مدنظر</param>
    public static DateTime ToDateTime(this DateOnly date) => date.ToDateTime(new TimeOnly(hour: 0, minute: 0));

    /// <summary>
    ///     تبديل به ابتداي روز ساختار جديد
    /// </summary>
    /// <param name="dateTime">تاريخ مدنظر</param>
    public static DateOnly ToDateOnly(this DateTime dateTime) => DateOnly.FromDateTime(dateTime);

    /// <summary>
    ///     تبديل به ابتداي روز ساختار قبلي
    /// </summary>
    /// <param name="date">تاريخ مدنظر</param>
    public static DateTime? ToDateTime(this DateOnly? date) => date?.ToDateTime(new TimeOnly(hour: 0, minute: 0));

    /// <summary>
    ///     تبديل به ابتداي روز ساختار جديد
    /// </summary>
    /// <param name="dateTime">تاريخ مدنظر</param>
    public static DateOnly? ToDateOnly(this DateTime? dateTime)
        => dateTime is null ? null : DateOnly.FromDateTime(dateTime.Value);

    /// <summary>
    ///     محاسبه سن
    /// </summary>
    /// <param name="birthday">تاریخ تولد</param>
    /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
    /// <returns>سن</returns>
    public static int GetAge(this DateOnly birthday, DateOnly comparisonBase)
        => birthday.ToDateTime().GetAge(comparisonBase.ToDateTime());
#endif
}
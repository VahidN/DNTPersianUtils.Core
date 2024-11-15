using System;
using System.Globalization;
using static System.FormattableString;

namespace DNTPersianUtils.Core;

/// <summary>
///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
/// </summary>
public static class FriendlyPersianDateUtils
{
    /// <summary>
    ///     نمایش فارسی روز دریافتی شمسی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public static string ToPersianDateTextify(int persianYear,
        int persianMonth,
        int persianDay,
        int beginningOfCentury = 1300)
    {
        if (persianYear <= 99)
        {
            persianYear += beginningOfCentury;
        }

        var strDay = PersianCulture.GetPersianWeekDayName(persianYear, persianMonth, persianDay);
        var strMonth = PersianCulture.PersianMonthNames[persianMonth];

        return Invariant($"{strDay} {persianDay} {strMonth} {persianYear}").ToPersianNumbers();
    }

    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public static string ToPersianDateTextify(this DateTime dt, bool convertToIranTimeZone = true)
    {
        var dateParts = dt.ToPersianYearMonthDay(convertToIranTimeZone);

        return ToPersianDateTextify(dateParts.Year, dateParts.Month, dateParts.Day);
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public static string ToPersianDateTextify(this DateOnly date, bool convertToIranTimeZone = true)
        => date.ToDateTime().ToPersianDateTextify(convertToIranTimeZone);
#endif

    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public static string ToPersianDateTextify(this DateTime? dt)
        => dt == null ? string.Empty : ToPersianDateTextify(dt.Value);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public static string ToPersianDateTextify(this DateOnly? date) => date.ToDateTime().ToPersianDateTextify();
#endif
    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    /// <param name="dt">تاریخ و زمان</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static string ToPersianDateTextify(this DateTimeOffset dt,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => ToPersianDateTextify(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     نمایش فارسی روز دریافتی
    ///     مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    /// <param name="dt">تاریخ و زمان</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static string ToPersianDateTextify(this DateTimeOffset? dt,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => dt == null ? string.Empty : ToPersianDateTextify(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTime dt,
        DateTime comparisonBase,
        bool appendHhMm = true,
        bool convertToIranTimeZone = true,
        bool includePersianDate = true)
        => $"{UnicodeConstants.RleChar}{toFriendlyPersianDate(dt, comparisonBase, appendHhMm, convertToIranTimeZone, includePersianDate).ToPersianNumbers()}";

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="date">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateOnly date,
        DateOnly comparisonBase,
        bool appendHhMm = true,
        bool convertToIranTimeZone = true,
        bool includePersianDate = true)
        => date.ToDateTime()
            .ToFriendlyPersianDateTextify(comparisonBase.ToDateTime(), appendHhMm, convertToIranTimeZone,
                includePersianDate);
#endif

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTime dt,
        bool appendHhMm = true,
        bool convertToIranTimeZone = true,
        bool includePersianDate = true)
    {
        var comparisonBase = convertToIranTimeZone ? dt.Kind.GetNow().ToIranTimeZoneDateTime() : dt.Kind.GetNow();

        return
            $"{UnicodeConstants.RleChar}{toFriendlyPersianDate(dt, comparisonBase, appendHhMm, convertToIranTimeZone, includePersianDate).ToPersianNumbers()}";
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="date">تاریخ ورودی</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateOnly date,
        bool appendHhMm = true,
        bool convertToIranTimeZone = true,
        bool includePersianDate = true)
        => date.ToDateTime().ToFriendlyPersianDateTextify(appendHhMm, convertToIranTimeZone, includePersianDate);
#endif

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTimeOffset dt,
        DateTime comparisonBase,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime,
        bool appendHhMm = true,
        bool includePersianDate = true)
        => $"{UnicodeConstants.RleChar}{toFriendlyPersianDate(dt.GetDateTimeOffsetPart(dateTimeOffsetPart), comparisonBase, appendHhMm, convertToIranTimeZone: false, includePersianDate).ToPersianNumbers()}";

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="appendHhMm">آیا ساعت نیز به نتیجه‌اضافه شود؟</param>
    /// <param name="includePersianDate">آیا تاریخ نیز به نتیجه اضافه شود؟</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTimeOffset dt,
        bool appendHhMm = true,
        bool includePersianDate = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var comparisonBase = DateTime.UtcNow.ToIranTimeZoneDateTime();
        var iranLocalTime = dt.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return
            $"{UnicodeConstants.RleChar}{toFriendlyPersianDate(iranLocalTime, comparisonBase, appendHhMm, convertToIranTimeZone: false, includePersianDate).ToPersianNumbers()}";
    }

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTime? dt, DateTime comparisonBase)
        => dt == null ? string.Empty : ToFriendlyPersianDateTextify(dt.Value, comparisonBase);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="date">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateOnly? date, DateOnly comparisonBase)
        => date.ToDateTime().ToFriendlyPersianDateTextify(comparisonBase.ToDateTime());
#endif

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTime? dt, bool convertToIranTimeZone = true)
    {
        if (dt == null)
        {
            return string.Empty;
        }

        var comparisonBase = convertToIranTimeZone
            ? dt.Value.Kind.GetNow().ToIranTimeZoneDateTime()
            : dt.Value.Kind.GetNow();

        return ToFriendlyPersianDateTextify(dt.Value, comparisonBase, convertToIranTimeZone);
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="date">تاریخ ورودی</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateOnly? date, bool convertToIranTimeZone = true)
        => date.ToDateTime().ToFriendlyPersianDateTextify(convertToIranTimeZone);
#endif

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="comparisonBase">مبنای مقایسه مانند هم اکنون</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTimeOffset? dt,
        DateTime comparisonBase,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        => dt == null
            ? string.Empty
            : ToFriendlyPersianDateTextify(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart), comparisonBase);

    /// <summary>
    ///     نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی
    ///     مبنای محاسبه هم اکنون
    ///     مانند ۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰
    /// </summary>
    /// <param name="dt">تاریخ ورودی</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>نمایش دوستانه</returns>
    public static string ToFriendlyPersianDateTextify(this DateTimeOffset? dt,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        if (dt == null)
        {
            return string.Empty;
        }

        var comparisonBase = DateTime.UtcNow.ToIranTimeZoneDateTime();
        var iranLocalTime = dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return ToFriendlyPersianDateTextify(iranLocalTime, comparisonBase);
    }

    private static string toFriendlyPersianDate(this DateTime dt,
        DateTime comparisonBase,
        bool appendHhMm,
        bool convertToIranTimeZone,
        bool includePersianDate)
    {
        if (dt.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            dt = dt.ToIranTimeZoneDateTime();
        }

        var persianDate = dt.ToPersianYearMonthDay(convertToIranTimeZone: false);

        //1388/10/22
        var persianYear = persianDate.Year;
        var persianMonth = persianDate.Month;
        var persianDay = persianDate.Day;

        //13:14
        var hour = dt.Hour;
        var min = dt.Minute;

        var hhMm =
            $"{hour.ToString(format: "00", CultureInfo.InvariantCulture)}:{min.ToString(format: "00", CultureInfo.InvariantCulture)}";

        var date = new PersianCalendar().ToDateTime(persianYear, persianMonth, persianDay, hour, min, second: 0,
            millisecond: 0);

        var diff = date - comparisonBase;
        var totalSeconds = Math.Round(diff.TotalSeconds);
        var totalDays = Math.Round(diff.TotalDays);

        var suffix = " بعد";

        if (totalSeconds < 0)
        {
            suffix = " قبل";
            totalSeconds = Math.Abs(totalSeconds);
            totalDays = Math.Abs(totalDays);
        }

        var dateTimeToday = DateTime.Today;
        var yesterday = dateTimeToday.AddDays(value: -1);
        var today = dateTimeToday.Date;
        var tomorrow = dateTimeToday.AddDays(value: 1);

        hhMm = appendHhMm ? $"، ساعت {hhMm}" : string.Empty;

        if (today == date.Date)
        {
            // Less than one minute ago.
            if (totalSeconds < 60)
            {
                return "هم اکنون";
            }

            // Less than 2 minutes ago.
            if (totalSeconds < 120)
            {
                return $"یک دقیقه{suffix}{hhMm}";
            }

            // Less than one hour ago.
            if (totalSeconds < 3600)
            {
                return string.Format(CultureInfo.InvariantCulture, format: "{0} دقیقه",
                    (int)Math.Floor(totalSeconds / 60)) + suffix + hhMm;
            }

            // Less than 2 hours ago.
            if (totalSeconds < 7200)
            {
                return $"یک ساعت{suffix}{hhMm}";
            }

            // Less than one day ago.
            if (totalSeconds < 86400)
            {
                return string.Format(CultureInfo.InvariantCulture, format: "{0} ساعت",
                    (int)Math.Floor(totalSeconds / 3600)) + suffix + hhMm;
            }
        }

        if (yesterday == date.Date)
        {
            return $"دیروز {PersianCulture.GetPersianWeekDayName(persianYear, persianMonth, persianDay)}{hhMm}";
        }

        if (tomorrow == date.Date)
        {
            return $"فردا {PersianCulture.GetPersianWeekDayName(persianYear, persianMonth, persianDay)}{hhMm}";
        }

        var dayStr = includePersianDate
            ? $"، {ToPersianDateTextify(persianYear, persianMonth, persianDay)}{hhMm}"
            : string.Empty;

        if (totalSeconds < 30 * TimeConstants.Day)
        {
            return Invariant($"{(int)Math.Abs(totalDays)} روز{suffix}{dayStr}");
        }

        if (totalSeconds < 12 * TimeConstants.Month)
        {
            var months = Convert.ToInt32(Math.Floor((double)Math.Abs(diff.Days) / 30));

            return months <= 1 ? Invariant($"1 ماه{suffix}{dayStr}") : Invariant($"{months} ماه{suffix}{dayStr}");
        }

        var years = Convert.ToInt32(Math.Floor((double)Math.Abs(diff.Days) / 365));
        var daysMonths = (double)Math.Abs(diff.Days) / 30;
        var nextMonths = Convert.ToInt32(Math.Truncate(daysMonths)) - years * 12 - 1;
        var and = years >= 1 ? " و " : "";
        var nextMonthsStr = nextMonths <= 0 ? "" : Invariant($"{and}{nextMonths} ماه");

        if (years < 1)
        {
            return $"{nextMonthsStr}{suffix}{dayStr}";
        }

        return Invariant($"{years} سال{nextMonthsStr}{suffix}{dayStr}");
    }
}
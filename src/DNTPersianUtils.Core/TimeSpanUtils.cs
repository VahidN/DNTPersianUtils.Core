using System;
using System.Globalization;

namespace DNTPersianUtils.Core;

/// <summary>
///     متدهای کمکی جهت کار با تاریخ میلادی
/// </summary>
public static class TimeSpanUtils
{
    /// <summary>
    ///     نمایش دوستانه‌ی یک بازه
    ///     مانند یک روز و دو ساعت و سه دقیقه و چهار ثانیه
    /// </summary>
    public static string ToFriendlyPersianTimeSpanString(this TimeSpan timeSpan)
        => timeSpan.ToTimeSpanParts().ToFriendlyPersianTimeSpanString();

    /// <summary>
    ///     نمایش دوستانه‌ی یک بازه
    ///     مانند یک روز و دو ساعت و سه دقیقه و چهار ثانیه
    /// </summary>
    public static string ToFriendlyPersianTimeSpanString(this TimeSpanParts timeSpanParts)
    {
        var formatted = string.Format(CultureInfo.InvariantCulture, format: "{0}{1}{2}{3}{4}{5}",
            timeSpanParts.Years > 0 ? $"{timeSpanParts.Years.NumberToText(Language.Persian)} سال و " : string.Empty,
            timeSpanParts.Months > 0 ? $"{timeSpanParts.Months.NumberToText(Language.Persian)} ماه و " : string.Empty,
            timeSpanParts.Days > 0 ? $"{timeSpanParts.Days.NumberToText(Language.Persian)} روز و " : string.Empty,
            timeSpanParts.Hours > 0 ? $"{timeSpanParts.Hours.NumberToText(Language.Persian)} ساعت و " : string.Empty,
            timeSpanParts.Minutes > 0
                ? $"{timeSpanParts.Minutes.NumberToText(Language.Persian)} دقیقه و "
                : string.Empty,
            timeSpanParts.Seconds > 0 ? $"{timeSpanParts.Seconds.NumberToText(Language.Persian)} ثانیه" : string.Empty);

        if (formatted.EndsWith(value: "و ", StringComparison.Ordinal))
        {
            formatted = formatted.Substring(startIndex: 0, formatted.Length - 2);
        }

        if (string.IsNullOrEmpty(formatted))
        {
            formatted = "0 ثانیه";
        }

        return formatted.Trim().ToPersianNumbers().ApplyRle();
    }

    /// <summary>
    ///     محاسبه اجزاي يك بازه زماني مانند تعداد سال، تعداد ماه و تعداد روز
    ///     اين محاسبه تخميني است.
    /// </summary>
    public static TimeSpanParts ToTimeSpanParts(this TimeSpan timeSpan)
    {
        // Calculate the span in days
        var days = Math.Abs(timeSpan.Days);

        // 362 days == 11 months and 4 weeks. 4 weeks => 1 month and 12 months => 1 year. So we have to exclude this value
        var has362Days = days % 362 == 0;

        // Calculate years
        var years = (int)(days / TimeSpanParts.ApproxDaysPerYear);

        // Decrease the remaining days
        days -= (int)(years * TimeSpanParts.ApproxDaysPerYear);

        // Calculate months
        var months = (int)(days / TimeSpanParts.ApproxDaysPerMonth);

        // Decrease the remaining days
        days -= (int)(months * TimeSpanParts.ApproxDaysPerMonth);

        // Calculate weeks
        var weeks = (int)(days / TimeSpanParts.DaysPerWeek);

        switch (weeks)
        {
            // 4 weeks is 1 month
            case 4 when has362Days is false:
                months++;

                break;
            case -4 when has362Days is false:
                months--;

                break;
        }

        // 12 months is 1 year
        if (months == 12)
        {
            months = 0;
            years++;
        }

        return new TimeSpanParts
        {
            Years = years,
            Months = months,
            Days = days,
            Hours = Math.Abs(timeSpan.Hours),
            Minutes = Math.Abs(timeSpan.Minutes),
            Seconds = Math.Abs(timeSpan.Seconds),
            Milliseconds = Math.Abs(timeSpan.Milliseconds)
        };
    }
}
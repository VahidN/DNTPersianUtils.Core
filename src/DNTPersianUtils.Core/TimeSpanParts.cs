using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزاي يك بازه‌ي زماني
/// </summary>
public class TimeSpanParts
{
    /// <summary>
    ///     تعداد روزهاي هفته
    /// </summary>
    public const double DaysPerWeek = 7;

    /// <summary>
    ///     تعداد متوسط روزهاي يك ماه
    /// </summary>
    public const double ApproxDaysPerMonth = 30.4375;

    /// <summary>
    ///     The above are the average days per month/year over a normal 4 year period
    ///     We use these approximations as they are more accurate for the next century or so
    ///     After that you may want to switch over to these 400 year approximations
    ///     ApproxDaysPerMonth = 30.436875
    ///     ApproxDaysPerYear  = 365.2425
    ///     How to get these numbers:
    ///     There are 365 days in a year, unless it is a leap year. Leap year is every forth year if Year % 4 = 0
    ///     unless year % 100 == 1
    ///     unless if year % 400 == 0 then it is a leap year.
    ///     This gives us 97 leap years in 400 years.
    ///     So 400 * 365 + 97 = 146097 days.
    ///     146097 / 400      = 365.2425
    ///     146097 / 400 / 12 = 30,436875
    ///     Due to the nature of the leap year calculation, on this side of the year 2100
    ///     you can assume every 4th year is a leap year and use the other approximatiotions
    /// </summary>
    public const double ApproxDaysPerYear = 365.25;

    /// <summary>
    ///     اجزاي يك بازه‌ي زماني
    /// </summary>
    public TimeSpanParts()
    {
    }

    /// <summary>
    ///     اجزاي يك بازه‌ي زماني
    /// </summary>
    public TimeSpanParts(TimeSpan timeSpan)
    {
        var parts = timeSpan.ToTimeSpanParts();
        Years = parts.Years;
        Months = parts.Months;
        Days = parts.Days;
        Hours = parts.Hours;
        Minutes = parts.Minutes;
        Seconds = parts.Seconds;
        Milliseconds = parts.Milliseconds;
    }

    /// <summary>
    ///     تعداد سال‌ها
    /// </summary>
    public int Years { get; set; }

    /// <summary>
    ///     تعداد ماه‌ها
    /// </summary>
    public int Months { get; set; }

    /// <summary>
    ///     تعداد روزها
    /// </summary>
    public int Days { get; set; }

    /// <summary>
    ///     تعداد ساعات
    /// </summary>
    public int Hours { get; set; }

    /// <summary>
    ///     تعداد دقايق
    /// </summary>
    public int Minutes { get; set; }

    /// <summary>
    ///     تعداد ثانيه‌ها
    /// </summary>
    public int Seconds { get; set; }

    /// <summary>
    ///     تعداد ميلي ثانيه‌ها
    /// </summary>
    public int Milliseconds { get; set; }

    /// <inheritdoc />
    public override string ToString() => this.ToFriendlyPersianTimeSpanString();
}
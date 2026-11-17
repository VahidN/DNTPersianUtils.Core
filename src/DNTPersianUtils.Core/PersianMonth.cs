using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزای ماه شمسی
/// </summary>
public class PersianMonth
{
    /// <summary>
    ///     اولین روز ماه شمسی
    /// </summary>
    public DateTime StartDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     اولین روز ماه شمسی
    /// </summary>
    public DateOnly StartDateOnly => StartDate.ToDateOnly();
#endif

    /// <summary>
    ///     اولین روز ماه در هفته‌ای که واقع شده‌است، در تقویم شمسی هفتگی، چه شماره‌ی روزی را دارد؟
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public int StartDateDayOfWeek { get; set; }

    /// <summary>
    ///     آخرین روز ماه شمسی
    /// </summary>
    public DateTime EndDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     آخرین روز ماه شمسی
    /// </summary>
    public DateOnly EndDateOnly => EndDate.ToDateOnly();
#endif

    /// <summary>
    ///     آخرین روز ماه در هفته‌ای که واقع شده‌است، در تقویم شمسی هفتگی، چه شماره‌ی روزی را دارد؟
    ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
    /// </summary>
    public int EndDateDayOfWeek { get; set; }

    /// <summary>
    ///     شماره آخرین روز ماه شمسی را بر می‌گرداند که 29 یا 30 یا 31 است
    /// </summary>
    public int LastDayNumber { get; set; }
}
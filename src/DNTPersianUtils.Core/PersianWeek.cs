using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزای هفته شمسی
/// </summary>
public class PersianWeek
{
    /// <summary>
    ///     اولین روز هفته شمسی
    /// </summary>
    public DateTime StartDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     اولین روز هفته شمسی
    /// </summary>
    public DateOnly StartDateOnly => StartDate.ToDateOnly();
#endif

    /// <summary>
    ///     آخرین روز هفته شمسی
    /// </summary>
    public DateTime EndDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     آخرین روز هفته شمسی
    /// </summary>
    public DateOnly EndDateOnly => EndDate.ToDateOnly();
#endif
}
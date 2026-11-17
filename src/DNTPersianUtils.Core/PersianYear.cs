using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزای سال شمسی
/// </summary>
public class PersianYear
{
    /// <summary>
    ///     اولین روز سال شمسی
    /// </summary>
    public DateTime StartDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     اولین روز سال شمسی
    /// </summary>
    public DateOnly StartDateOnly => StartDate.ToDateOnly();
#endif

    /// <summary>
    ///     آخرین روز سال شمسی
    /// </summary>
    public DateTime EndDate { get; set; }

#if NET11_0 || NET10_0
    /// <summary>
    ///     آخرین روز سال شمسی
    /// </summary>
    public DateOnly EndDateOnly => EndDate.ToDateOnly();
#endif
}
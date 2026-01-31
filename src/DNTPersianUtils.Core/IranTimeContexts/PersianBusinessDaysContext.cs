using System;
using System.Collections.Generic;

namespace DNTPersianUtils.Core;

/// <summary>
///     اطلاعات روزهاي كاري
/// </summary>
public sealed class PersianBusinessDaysContext(DateTime dt)
{
    /// <summary>
    ///     ریافت لیست روزهای کاری ایران در یکسال شمسی
    /// </summary>
    public IEnumerable<DateTime> Year => dt.GetPersianYear().GetBusinessDays();

    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یک ماه شمسی
    /// </summary>
    public IEnumerable<DateTime> Month => dt.GetPersianYear().GetBusinessDays(dt.GetPersianMonth());
}
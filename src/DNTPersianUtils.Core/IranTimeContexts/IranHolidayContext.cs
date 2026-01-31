using System;
using System.Collections.Generic;

namespace DNTPersianUtils.Core;

/// <summary>
///     ارائه اطلاعاتي در مورد تعطيلات رسمي ايران
/// </summary>
/// <param name="dt"></param>
public sealed class IranHolidayContext(DateTime dt)
{
    /// <summary>
    ///     آيا روز جاري تعطيل رسمي است؟
    /// </summary>
    public bool IsToday => dt.IsHoliday();

    /// <summary>
    ///     ليست تعطيلات رسمي جاري
    /// </summary>
    public IList<string>? Today => dt.GetHolidays();
}
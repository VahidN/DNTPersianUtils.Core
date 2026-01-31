using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     ارائه اطلاعاتي در مورد روز جاري
/// </summary>
public sealed class DateTimeContext(DateTime dt)
{
    /// <summary>
    ///     تاريخ جاري
    /// </summary>
    public DateTime Value => dt;

    /// <summary>
    ///     روز جاري
    /// </summary>
    public DateTime Today => dt.Date;

    /// <summary>
    ///     پايان روز جاري
    /// </summary>
    public DateTime EndOfToday => dt.Date.GetEndOfDay();
}
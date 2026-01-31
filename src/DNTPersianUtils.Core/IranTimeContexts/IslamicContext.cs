using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     ارائه اطلاعاتي در مورد تاريخ قمري جاري
/// </summary>
public sealed class IslamicContext(DateTime dt)
{
    /// <summary>
    ///     تاريخ قمري جاري
    /// </summary>
    public IslamicDay Today => dt.ToIslamicDay();
}
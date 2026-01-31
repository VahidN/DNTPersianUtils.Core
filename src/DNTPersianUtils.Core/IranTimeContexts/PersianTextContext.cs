using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     نمايش متني تاريخ شمسي
/// </summary>
/// <param name="dt"></param>
public sealed class PersianTextContext(DateTime dt)
{
    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 21 دی 1395
    /// </summary>
    public string LongDate => dt.ToLongPersianDateString().ToPersianNumbers();

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
    /// </summary>
    public string LongDateTime => dt.ToLongPersianDateTimeString().ToPersianNumbers();

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 1395/10/21
    /// </summary>
    public string ShortDate => dt.ToShortPersianDateString();

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی با قالبی مانند 1395/10/21 10:20
    /// </summary>
    public string ShortDateTime => dt.ToShortPersianDateTimeString();

    /// <summary>
    ///     نمایش فارسی روز دریافتی مانند سه شنبه ۲۱ دی ۱۳۹۵
    /// </summary>
    public string Textify => dt.ToPersianDateTextify();
}
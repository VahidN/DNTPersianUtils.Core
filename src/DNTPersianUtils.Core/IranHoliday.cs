using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     مناسبت‌های تعطیلات رسمی ایران
/// </summary>
public class IranHoliday
{
    /// <summary>
    ///     روز مناسبت تعطیل رسمی
    /// </summary>
    public DateTime Holiday { set; get; }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
    /// <summary>
    ///     روز مناسبت تعطیل رسمی
    /// </summary>
    public DateOnly HolidayDate => Holiday.ToDateOnly();
#endif

    /// <summary>
    ///     توضیحات مناسبت
    /// </summary>
    public string Description { set; get; } = default!;

    /// <summary>
    ///     ToString()
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{Description}";

    /// <summary>
    ///     Equals
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not IranHoliday day)
        {
            return false;
        }

        return Holiday.Year == day.Holiday.Year && Holiday.Month == day.Holiday.Month && Holiday.Day == day.Holiday.Day;
    }

    /// <summary>
    ///     GetHashCode
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + Holiday.GetHashCode();
            hash = hash * 23 + StringComparer.Ordinal.GetHashCode(Description);

            return hash;
        }
    }
}
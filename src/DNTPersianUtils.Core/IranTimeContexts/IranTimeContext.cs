using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     ارائه اطلاعاتي در مورد وهله زماني جاري
/// </summary>
public sealed class IranTimeContext
{
    /// <summary>
    ///     ارائه اطلاعاتي در مورد وهله زماني جاري
    /// </summary>
    /// <param name="source"></param>
    public IranTimeContext(DateTime source) => DateTime = source.ToIranTimeZoneDateTime();

    /// <summary>
    ///     ارائه اطلاعاتي در مورد وهله زماني جاري
    /// </summary>
    /// <param name="source"></param>
    public IranTimeContext(DateTimeOffset source)
        => DateTime = source.GetDateTimeOffsetPart(DateTimeOffsetPart.IranLocalDateTime);

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     ارائه اطلاعاتي در مورد وهله زماني جاري
    /// </summary>
    /// <param name="source"></param>
    public IranTimeContext(DateOnly source) => DateTime = source.ToDateTime().ToIranTimeZoneDateTime();
#endif

    /// <summary>
    ///     وهله زماني جاري به وقت ايران
    /// </summary>
    public DateTime DateTime { get; }

    /// <summary>
    ///     ارائه اطلاعاتي در مورد روز جاري
    /// </summary>
    public DateTimeContext DateTimeInfo => new(DateTime);

    /// <summary>
    ///     اطلاعاتي در مورد تقويم شمسي
    /// </summary>
    public PersianContext Persian => new(DateTime);

    /// <summary>
    ///     ارائه اطلاعاتي در مورد تاريخ قمري جاري
    /// </summary>
    public IslamicContext Islamic => new(DateTime);

    /// <summary>
    ///     ارائه اطلاعاتي در مورد تعطيلات رسمي ايران
    /// </summary>
    public IranHolidayContext Holidays => new(DateTime);
}
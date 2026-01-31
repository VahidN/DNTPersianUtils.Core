#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     Persian DateTime Extensions
/// </summary>
public static class DateOnlyExtensions
{
    extension(DateOnly)
    {
        /// <summary>
        ///     DateTime.Now بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNow => new(DateTime.Now.ToDateOnly());

        /// <summary>
        ///     DateTime.UtcNow بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNowUtc => new(DateTime.UtcNow.ToDateOnly());

        /// <summary>
        ///     بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranDateOnlyAt(DateOnly source) => new(source);
    }
}
#endif
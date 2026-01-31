using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     Persian DateTime Extensions
/// </summary>
public static class DateTimeOffsetExtensions
{
    extension(DateTimeOffset)
    {
        /// <summary>
        ///     DateTime.Now بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNow => new(DateTimeOffset.Now);

        /// <summary>
        ///     DateTime.UtcNow بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNowUtc => new(DateTimeOffset.UtcNow);

        /// <summary>
        ///     بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranDateTimeOffsetAt(DateTimeOffset source) => new(source);
    }
}
using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     Persian DateTime Extensions
/// </summary>
public static class DateTimeExtensions
{
    extension(DateTime)
    {
        /// <summary>
        ///     DateTime.Now بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNow => new(DateTime.Now);

        /// <summary>
        ///     DateTime.UtcNow بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranNowUtc => new(DateTime.UtcNow);

        /// <summary>
        ///     بر اساس منطقه زماني ايران
        /// </summary>
        public static IranTimeContext IranDateTimeAt(DateTime dateTime) => new(dateTime);
    }
}
using System;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// متدهای کمکی جهت کار با تاریخ میلادی
    /// </summary>
    public static class DateTimeUtils
    {
        /// <summary>
        /// Iran Standard Time
        /// </summary>
        public static readonly TimeZoneInfo IranStandardTime =
            TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");

        /// <summary>
        /// محاسبه سن
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTimeOffset birthday, DateTime comparisonBase, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return GetAge(birthday.GetDateTimeOffsetPart(dateTimeOffsetPart), comparisonBase);
        }

        /// <summary>
        /// محاسبه سن
        /// مبنای محاسبه هم اکنون
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTimeOffset birthday)
        {
            var birthdayDateTime = birthday.UtcDateTime;
            var now = DateTime.UtcNow;
            return GetAge(birthdayDateTime, now);
        }

        /// <summary>
        /// محاسبه سن
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTime birthday, DateTime comparisonBase)
        {
            var now = comparisonBase;
            var age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age;
        }

        /// <summary>
        /// محاسبه سن
        /// مبنای محاسبه هم اکنون
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTime birthday)
        {
            var now = birthday.Kind.GetNow();
            return GetAge(birthday, now);
        }

        /// <summary>
        /// دریافت جزء زمانی ویژه‌ی این وهله
        /// </summary>
        public static DateTime GetDateTimeOffsetPart(
            this DateTimeOffset dateTimeOffset,
            DateTimeOffsetPart dataDateTimeOffsetPart)
        {
            switch (dataDateTimeOffsetPart)
            {
                case DateTimeOffsetPart.DateTime:
                    return dateTimeOffset.DateTime;

                case DateTimeOffsetPart.LocalDateTime:
                    return dateTimeOffset.LocalDateTime;

                case DateTimeOffsetPart.UtcDateTime:
                    return dateTimeOffset.UtcDateTime;

                case DateTimeOffsetPart.IranLocalDateTime:
                    return dateTimeOffset.ToIranTimeZoneDateTimeOffset().DateTime;

                default:
                    throw new ArgumentOutOfRangeException(nameof(dataDateTimeOffsetPart), dataDateTimeOffsetPart, null);
            }
        }

        /// <summary>
        /// بازگشت زمان جاری با توجه به نوع زمان
        /// </summary>
        /// <param name="dataDateTimeKind">نوع زمان ورودی</param>
        /// <returns>هم اکنون</returns>
        public static DateTime GetNow(this DateTimeKind dataDateTimeKind)
        {
            switch (dataDateTimeKind)
            {
                case DateTimeKind.Utc:
                    return DateTime.UtcNow;
                default:
                    return DateTime.Now;
            }
        }

        /// <summary>
        /// تبدیل منطقه زمانی این وهله به منطقه زمانی ایران
        /// </summary>
        public static DateTimeOffset ToIranTimeZoneDateTimeOffset(this DateTimeOffset dateTimeOffset)
        {
            return TimeZoneInfo.ConvertTime(dateTimeOffset, IranStandardTime);
        }

        /// <summary>
        /// تبدیل منطقه زمانی این وهله به منطقه زمانی ایران
        /// </summary>
        public static DateTime ToIranTimeZoneDateTime(this DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTime(dateTime, IranStandardTime);
        }
    }
}
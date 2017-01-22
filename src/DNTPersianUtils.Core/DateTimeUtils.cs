using System;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// متدهای کمکی جهت کار با تاریخ میلادی
    /// </summary>
    public static class DateTimeUtils
    {
        /// <summary>
        /// محاسبه سن
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <param name="comparisonBase">مبنای محاسبه مانند هم اکنون</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTimeOffset birthday, DateTime comparisonBase)
        {
            return GetAge(birthday.DateTime, comparisonBase);
        }

        /// <summary>
        /// محاسبه سن
        /// مبنای محاسبه هم اکنون
        /// </summary>
        /// <param name="birthday">تاریخ تولد</param>
        /// <returns>سن</returns>
        public static int GetAge(this DateTimeOffset birthday)
        {
            var birthdayDateTime = birthday.DateTime;
            var now = birthdayDateTime.Kind.GetNow();
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
    }
}
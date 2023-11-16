using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزای ماه شمسی
/// </summary>
public class PersianMonth
{
        /// <summary>
        ///     اولین روز ماه شمسی
        /// </summary>
        public DateTime StartDate { set; get; }

#if NET6_0 || NET7_0 || NET8_0
        /// <summary>
        ///     اولین روز ماه شمسی
        /// </summary>
        public DateOnly StartDateOnly => StartDate.ToDateOnly();
#endif

        /// <summary>
        ///     اولین روز ماه در هفته‌ای که واقع شده‌است، در تقویم شمسی هفتگی، چه شماره‌ی روزی را دارد؟
        ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
        /// </summary>
        public int StartDateDayOfWeek { set; get; }

        /// <summary>
        ///     آخرین روز ماه شمسی
        /// </summary>
        public DateTime EndDate { set; get; }

#if NET6_0 || NET7_0 || NET8_0
        /// <summary>
        ///     آخرین روز ماه شمسی
        /// </summary>
        public DateOnly EndDateOnly => EndDate.ToDateOnly();
#endif

        /// <summary>
        ///     آخرین روز ماه در هفته‌ای که واقع شده‌است، در تقویم شمسی هفتگی، چه شماره‌ی روزی را دارد؟
        ///     برای مثال سان‌دی معادل روز 2 هفته شمسی است
        /// </summary>
        public int EndDateDayOfWeek { set; get; }

        /// <summary>
        ///     شماره آخرین روز ماه شمسی را بر می‌گرداند که 29 یا 30 یا 31 است
        /// </summary>
        public int LastDayNumber { set; get; }
}
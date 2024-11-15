using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اجزای هفته شمسی
/// </summary>
public class PersianWeek
{
        /// <summary>
        ///     اولین روز هفته شمسی
        /// </summary>
        public DateTime StartDate { set; get; }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
        /// <summary>
        ///     اولین روز هفته شمسی
        /// </summary>
        public DateOnly StartDateOnly => StartDate.ToDateOnly();
#endif

        /// <summary>
        ///     آخرین روز هفته شمسی
        /// </summary>
        public DateTime EndDate { set; get; }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0
        /// <summary>
        ///     آخرین روز هفته شمسی
        /// </summary>
        public DateOnly EndDateOnly => EndDate.ToDateOnly();
#endif
}
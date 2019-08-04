using System;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// اجزای هفته شمسی
    /// </summary>
    public class PersianWeek
    {
        /// <summary>
        /// اولین روز هفته شمسی
        /// </summary>
        public DateTime StartDate { set; get; }

        /// <summary>
        /// آخرین روز هفته شمسی
        /// </summary>
        public DateTime EndDate { set; get; }
    }
}
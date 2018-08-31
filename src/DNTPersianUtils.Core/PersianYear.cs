using System;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// اجزای سال شمسی
    /// </summary>
    public class PersianYear
    {
        /// <summary>
        /// اولین روز سال شمسی
        /// </summary>
        public DateTime StartDate { set; get; }

        /// <summary>
        /// آخرین روز سال شمسی
        /// </summary>
        public DateTime EndDate { set; get; }
    }
}
using System.Collections.Generic;
using System.Globalization;
using static System.FormattableString;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// اجزای روز شمسی
    /// </summary>
    public class PersianDay
    {
        /// <summary>
        /// سال شمسی
        /// </summary>
        public int Year { set; get; }

        /// <summary>
        /// ماه شمسی
        /// </summary>
        public int Month { set; get; }

        /// <summary>
        /// روز شمسی
        /// </summary>
        public int Day { set; get; }

        /// <summary>
        /// در صورت تعطیل رسمی بودن، با عناوین مناسبت‌ها مقدار دهی خواهد شد
        /// </summary>
        public IEnumerable<string>? Holidays { set; get; }

        /// <summary>
        /// اجزای روز شمسی
        /// </summary>
        public PersianDay() { }

        /// <summary>
        /// اجزای روز شمسی
        /// </summary>
        public PersianDay(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        /// <summary>
        /// ToString()
        /// </summary>
        public override string ToString()
        {
            return Invariant($"{Year}/{Month.ToString("00", CultureInfo.InvariantCulture)}/{Day.ToString("00", CultureInfo.InvariantCulture)}");
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is not PersianDay day)
                return false;

            return this.Year == day.Year &&
                   this.Month == day.Month &&
                   this.Day == day.Day;
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + Year.GetHashCode();
                hash = hash * 23 + Month.GetHashCode();
                hash = hash * 23 + Day.GetHashCode();
                return hash;
            }
        }
    }
}
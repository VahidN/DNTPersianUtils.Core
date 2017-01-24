using System;
using System.Globalization;
using System.Linq;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Represents PersianDateTime utils.
    /// </summary>
    public static class PersianDateTimeUtils
    {
        /// <summary>
        /// تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی
        /// با قالب‌های پشتیبانی شده‌ی ۹۰/۸/۱۴ , 1395/11/3 17:30 , ۱۳۹۰/۸/۱۴ , ۹۰-۸-۱۴ , ۱۳۹۰-۸-۱۴
        /// </summary>
        /// <param name="persianDateTime">تاریخ و زمان شمسی</param>
        /// <returns>تاریخ و زمان قمری</returns>
        public static DateTime? ToGregorianDateTime(this string persianDateTime)
        {
            if (string.IsNullOrWhiteSpace(persianDateTime))
            {
                return null;
            }

            persianDateTime = persianDateTime.Trim().ToEnglishNumbers();
            var splitedDateTime = persianDateTime.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var rawTime = splitedDateTime.FirstOrDefault(s => s.Contains(':'));
            var rawDate = splitedDateTime.FirstOrDefault(s => !s.Contains(':'));

            var splitedDate = rawDate?.Split('/', ',', '؍', '.', '-');
            if (splitedDate?.Length != 3)
            {
                return null;
            }

            var day = getDay(splitedDate[2]);
            if (!day.HasValue)
            {
                return null;
            }

            var month = getMonth(splitedDate[1]);
            if (!month.HasValue)
            {
                return null;
            }

            var year = getYear(splitedDate[0]);
            if (!year.HasValue)
            {
                return null;
            }

            var hour = 0;
            var minute = 0;
            var second = 0;

            if (!string.IsNullOrWhiteSpace(rawTime))
            {
                var splitedTime = rawTime.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                hour = int.Parse(splitedTime[0]);
                minute = int.Parse(splitedTime[1]);
                if (splitedTime.Length > 2)
                {
                    var lastPart = splitedTime[2].Trim();
                    var formatInfo = PersianCulture.Instance.DateTimeFormat;
                    if (lastPart.Equals(formatInfo.PMDesignator, StringComparison.OrdinalIgnoreCase))
                    {
                        if (hour < 12)
                        {
                            hour += 12;
                        }
                    }
                    else
                    {
                        int.TryParse(lastPart, out second);
                    }
                }
            }

            var persianCalendar = new PersianCalendar();
            return persianCalendar.ToDateTime(year.Value, month.Value, day.Value, hour, minute, second, 0);
        }

        /// <summary>
        /// تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی
        /// با قالب‌های پشتیبانی شده‌ی ۹۰/۸/۱۴ , 1395/11/3 17:30 , ۱۳۹۰/۸/۱۴ , ۹۰-۸-۱۴ , ۱۳۹۰-۸-۱۴
        /// </summary>
        /// <param name="persianDateTime">تاریخ و زمان شمسی</param>
        /// <returns>تاریخ و زمان قمری</returns>
        public static DateTimeOffset? ToGregorianDateTimeOffset(this string persianDateTime)
        {
            var dateTime = persianDateTime.ToGregorianDateTime();
            if (dateTime == null)
            {
                return null;
            }

            return new DateTimeOffset(dateTime.Value, DateTimeUtils.IranStandardTime.BaseUtcOffset);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToLongPersianDateString(this DateTime dt)
        {
            return dt.ToPersianDateTimeString(PersianCulture.Instance.DateTimeFormat.LongDatePattern);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToLongPersianDateString(this DateTime? dt)
        {
            return dt == null ? string.Empty : ToLongPersianDateString(dt.Value);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return dt == null ? string.Empty : ToLongPersianDateString(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return ToLongPersianDateString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToLongPersianDateTimeString(this DateTime dt)
        {
            return dt.ToPersianDateTimeString(
                $"{PersianCulture.Instance.DateTimeFormat.LongDatePattern}، {PersianCulture.Instance.DateTimeFormat.LongTimePattern}");
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToLongPersianDateTimeString(this DateTime? dt)
        {
            return dt == null ? string.Empty : ToLongPersianDateTimeString(dt.Value);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateTimeString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return dt == null ? string.Empty : ToLongPersianDateTimeString(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateTimeString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return ToLongPersianDateTimeString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDateTimeString(this DateTime dateTime, string format)
        {
            return dateTime.ToString(format, PersianCulture.Instance);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static Tuple<int, int, int> ToPersianYearMonthDay(this DateTimeOffset? gregorianDate, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return gregorianDate == null ? null : ToPersianYearMonthDay(gregorianDate.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        public static Tuple<int, int, int> ToPersianYearMonthDay(this DateTime? gregorianDate)
        {
            return gregorianDate == null ? null : ToPersianYearMonthDay(gregorianDate.Value);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static Tuple<int, int, int> ToPersianYearMonthDay(this DateTimeOffset gregorianDate, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return ToPersianYearMonthDay(gregorianDate.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        public static Tuple<int, int, int> ToPersianYearMonthDay(this DateTime gregorianDate)
        {
            var persianCalendar = new PersianCalendar();
            var persianYear = persianCalendar.GetYear(gregorianDate);
            var persianMonth = persianCalendar.GetMonth(gregorianDate);
            var persianDay = persianCalendar.GetDayOfMonth(gregorianDate);
            return new Tuple<int, int, int>(persianYear, persianMonth, persianDay);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return dt == null ? string.Empty : ToShortPersianDateString(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return ToShortPersianDateString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateString(this DateTime dt)
        {
            return dt.ToPersianDateTimeString(PersianCulture.Instance.DateTimeFormat.ShortDatePattern);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateString(this DateTime? dt)
        {
            return dt == null ? string.Empty : ToShortPersianDateString(dt.Value);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateTimeString(this DateTime dt)
        {
            return dt.ToPersianDateTimeString(
                $"{PersianCulture.Instance.DateTimeFormat.ShortDatePattern} {PersianCulture.Instance.DateTimeFormat.ShortTimePattern}");
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateTimeString(this DateTime? dt)
        {
            return dt == null ? string.Empty : ToShortPersianDateTimeString(dt.Value);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateTimeString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return dt == null ? string.Empty : ToShortPersianDateTimeString(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateTimeString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart)
        {
            return ToShortPersianDateTimeString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        private static int? getDay(string part)
        {
            var day = part.toNumber();
            if (!day.Item1) return null;
            var pDay = day.Item2;
            if (pDay == 0 || pDay > 31) return null;
            return pDay;
        }

        private static int? getMonth(string part)
        {
            var month = part.toNumber();
            if (!month.Item1) return null;
            var pMonth = month.Item2;
            if (pMonth == 0 || pMonth > 12) return null;
            return pMonth;
        }

        private static int? getYear(string part)
        {
            var year = part.toNumber();
            if (!year.Item1) return null;
            var pYear = year.Item2;
            if (part.Length == 2) pYear += 1300;
            return pYear;
        }

        private static Tuple<bool, int> toNumber(this string data)
        {
            int number;
            bool result = int.TryParse(data, out number);
            return new Tuple<bool, int>(result, number);
        }
    }
}
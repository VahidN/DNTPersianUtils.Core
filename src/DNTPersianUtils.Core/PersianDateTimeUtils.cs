using System;
using System.Globalization;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Represents PersianDateTime utils.
    /// </summary>
    public static class PersianDateTimeUtils
    {
        /// <summary>
        /// تعیین اعتبار تاریخ شمسی
        /// </summary>
        /// <param name="persianYear">سال شمسی</param>
        /// <param name="persianMonth">ماه شمسی</param>
        /// <param name="persianDay">روز شمسی</param>
        public static bool IsValidPersianDate(int persianYear, int persianMonth, int persianDay)
        {
            if (persianDay > 31 || persianDay <= 0)
            {
                return false;
            }

            if (persianMonth > 12 || persianMonth <= 0)
            {
                return false;
            }

            if (persianMonth <= 6 && persianDay > 31)
            {
                return false;
            }

            if (persianMonth >= 7 && persianDay > 30)
            {
                return false;
            }

            if (persianMonth == 12)
            {
                var persianCalendar = new PersianCalendar();
                var isLeapYear = persianCalendar.IsLeapYear(persianYear);

                if (isLeapYear && persianDay > 30)
                {
                    return false;
                }

                if (!isLeapYear && persianDay > 29)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// تعیین اعتبار تاریخ و زمان رشته‌ای شمسی
        /// با قالب‌های پشتیبانی شده‌ی ۹۰/۸/۱۴ , 1395/11/3 17:30 , ۱۳۹۰/۸/۱۴ , ۹۰-۸-۱۴ , ۱۳۹۰-۸-۱۴
        /// </summary>
        /// <param name="persianDateTime">تاریخ و زمان شمسی</param>
        /// <param name="throwOnException"></param>
        public static bool IsValidPersianDateTime(this string? persianDateTime, bool throwOnException = false)
        {
            try
            {
                var dt = persianDateTime.ToGregorianDateTime();
                return dt.HasValue;
            }
            catch
            {
                if (throwOnException)
                {
                    throw;
                }
                return false;
            }
        }

        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="persianYear">سال شمسی</param>
        /// <param name="persianMonth">ماه شمسی</param>
        /// <param name="persianDay">روز شمسی</param>
        public static DateTime ToPersianDate(this int persianYear, int persianMonth, int persianDay)
        {
            return new PersianCalendar().ToDateTime(persianYear, persianMonth, persianDay, 0, 0, 0, 0);
        }

        /// <summary>
        /// تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی
        /// با قالب‌های پشتیبانی شده‌ی ۹۰/۸/۱۴ , 1395/11/3 17:30 , ۱۳۹۰/۸/۱۴ , ۹۰-۸-۱۴ , ۱۳۹۰-۸-۱۴
        /// در اینجا اگر رشته‌ی مدنظر قابل تبدیل نباشد، مقدار نال را دریافت خواهید کرد
        /// </summary>
        /// <param name="persianDateTime">تاریخ و زمان شمسی</param>
        /// <param name="convertToUtc">Converts the value of the current DateTime to Coordinated Universal Time (UTC)</param>
        /// <param name="beginningOfCentury">سال شروع قرن، اگر سال وارد شده دو رقمی است</param>
        /// <returns>تاریخ و زمان میلادی</returns>
        public static DateTime? ToGregorianDateTime(this string? persianDateTime, bool convertToUtc = false, int beginningOfCentury = 1300)
        {
            if (string.IsNullOrWhiteSpace(persianDateTime))
            {
                return null;
            }

            persianDateTime = persianDateTime.Trim().ToEnglishNumbers();
            var splittedDateTime = persianDateTime.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var rawTime = Array.Find(splittedDateTime, s => s.Contains(':', StringComparison.OrdinalIgnoreCase));
            var rawDate = Array.Find(splittedDateTime, s => !s.Contains(':', StringComparison.OrdinalIgnoreCase));

            var splittedDate = rawDate?.Split('/', ',', '؍', '.', '-');
            if (splittedDate?.Length != 3)
            {
                return null;
            }

            var day = getDay(splittedDate[2]);
            if (!day.HasValue)
            {
                return null;
            }

            var month = getMonth(splittedDate[1]);
            if (!month.HasValue)
            {
                return null;
            }

            var year = getYear(splittedDate[0], beginningOfCentury);
            if (!year.HasValue)
            {
                return null;
            }

            if (!IsValidPersianDate(year.Value, month.Value, day.Value))
            {
                return null;
            }

            var hour = 0;
            var minute = 0;
            var second = 0;

            if (!string.IsNullOrWhiteSpace(rawTime))
            {
                var splittedTime = rawTime.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                hour = int.Parse(splittedTime[0], CultureInfo.InvariantCulture);
                minute = int.Parse(splittedTime[1], CultureInfo.InvariantCulture);
                if (splittedTime.Length > 2)
                {
                    var lastPart = splittedTime[2].Trim();
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
                        if (!int.TryParse(lastPart, NumberStyles.Number, CultureInfo.InvariantCulture, out second))
                        {
                            second = 0;
                        }
                    }
                }
            }

            var persianCalendar = new PersianCalendar();
            var dateTime = persianCalendar.ToDateTime(year.Value, month.Value, day.Value, hour, minute, second, 0);
            if (convertToUtc)
            {
                dateTime = dateTime.ToUniversalTime();
            }
            return dateTime;
        }

        /// <summary>
        /// تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی
        /// با قالب‌های پشتیبانی شده‌ی ۹۰/۸/۱۴ , 1395/11/3 17:30 , ۱۳۹۰/۸/۱۴ , ۹۰-۸-۱۴ , ۱۳۹۰-۸-۱۴
        /// در اینجا اگر رشته‌ی مدنظر قابل تبدیل نباشد، مقدار نال را دریافت خواهید کرد
        /// </summary>
        /// <param name="persianDateTime">تاریخ و زمان شمسی</param>
        /// <param name="convertToUtc">Converts the value of the current DateTime to Coordinated Universal Time (UTC)</param>
        /// <param name="beginningOfCentury">سال شروع قرن، اگر سال وارد شده دو رقمی است</param>
        /// <returns>تاریخ و زمان میلادی</returns>
        public static DateTimeOffset? ToGregorianDateTimeOffset(
            this string? persianDateTime, bool convertToUtc = false, int beginningOfCentury = 1300)
        {
            var dateTime = persianDateTime.ToGregorianDateTime(convertToUtc, beginningOfCentury);
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
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToLongPersianDateString(this DateTime dt, bool convertToIranTimeZone = true)
        {
            return dt.ToPersianDateTimeString(PersianCulture.Instance.DateTimeFormat.LongDatePattern, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToLongPersianDateString(this DateTime? dt, bool convertToIranTimeZone = true)
        {
            return dt == null ? string.Empty : ToLongPersianDateString(dt.Value, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
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
        public static string ToLongPersianDateString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return ToLongPersianDateString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToLongPersianDateTimeString(this DateTime dt, bool convertToIranTimeZone = true)
        {
            return dt.ToPersianDateTimeString(
                $"{PersianCulture.Instance.DateTimeFormat.LongDatePattern}، {PersianCulture.Instance.DateTimeFormat.LongTimePattern}",
                convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToLongPersianDateTimeString(this DateTime? dt, bool convertToIranTimeZone = true)
        {
            return dt == null ? string.Empty : ToLongPersianDateTimeString(dt.Value, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string ToLongPersianDateTimeString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
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
        public static string ToLongPersianDateTimeString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return ToLongPersianDateTimeString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToPersianDateTimeString(this DateTime dateTime, string format, bool convertToIranTimeZone = true)
        {
            if (dateTime.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                dateTime = dateTime.ToIranTimeZoneDateTime();
            }
            return dateTime.ToString(format, PersianCulture.Instance);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static PersianDay ToPersianYearMonthDay(this DateTimeOffset? gregorianDate, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return gregorianDate == null ?
               throw new ArgumentNullException(nameof(gregorianDate)) :
               ToPersianYearMonthDay(gregorianDate.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static PersianDay ToPersianYearMonthDay(this DateTime? gregorianDate, bool convertToIranTimeZone = true)
        {
            return gregorianDate == null ?
                throw new ArgumentNullException(nameof(gregorianDate)) :
                ToPersianYearMonthDay(gregorianDate.Value, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static PersianDay ToPersianYearMonthDay(this DateTimeOffset gregorianDate, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return ToPersianYearMonthDay(gregorianDate.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی و دریافت اجزای سال، ماه و روز نتیجه‌ی حاصل‌
        /// </summary>
        /// <param name="gregorianDate"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static PersianDay ToPersianYearMonthDay(this DateTime gregorianDate, bool convertToIranTimeZone = true)
        {
            if (gregorianDate.Kind == DateTimeKind.Utc && convertToIranTimeZone)
            {
                gregorianDate = gregorianDate.ToIranTimeZoneDateTime();
            }

            var persianCalendar = new PersianCalendar();
            var persianYear = persianCalendar.GetYear(gregorianDate);
            var persianMonth = persianCalendar.GetMonth(gregorianDate);
            var persianDay = persianCalendar.GetDayOfMonth(gregorianDate);
            var holidays = gregorianDate.GetHolidays(convertToIranTimeZone);
            return new PersianDay
            {
                Year = persianYear,
                Month = persianMonth,
                Day = persianDay,
                Holidays = holidays
            };
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
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
        public static string ToShortPersianDateString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return ToShortPersianDateString(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToShortPersianDateString(this DateTime dt, bool convertToIranTimeZone = true)
        {
            return dt.ToPersianDateTimeString(PersianCulture.Instance.DateTimeFormat.ShortDatePattern, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToShortPersianDateString(this DateTime? dt, bool convertToIranTimeZone = true)
        {
            return dt == null ? string.Empty : ToShortPersianDateString(dt.Value, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToShortPersianDateTimeString(this DateTime dt, bool convertToIranTimeZone = true)
        {
            return dt.ToPersianDateTimeString(
                $"{PersianCulture.Instance.DateTimeFormat.ShortDatePattern} {PersianCulture.Instance.DateTimeFormat.ShortTimePattern}",
                convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <returns>تاریخ شمسی</returns>
        /// <param name="dt"></param>
        /// <param name="convertToIranTimeZone">اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل می‌کند</param>
        public static string ToShortPersianDateTimeString(this DateTime? dt, bool convertToIranTimeZone = true)
        {
            return dt == null ? string.Empty : ToShortPersianDateTimeString(dt.Value, convertToIranTimeZone);
        }

        /// <summary>
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToShortPersianDateTimeString(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
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
        public static string ToShortPersianDateTimeString(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
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

        private static int? getYear(string part, int beginningOfCentury)
        {
            var year = part.toNumber();
            if (!year.Item1) return null;
            var pYear = year.Item2;
            if (part.Length == 2) pYear += beginningOfCentury;
            return pYear;
        }

        private static Tuple<bool, int> toNumber(this string data)
        {
            bool result = int.TryParse(data, NumberStyles.Number, CultureInfo.InvariantCulture, out var number);
            return new Tuple<bool, int>(result, number);
        }
    }
}
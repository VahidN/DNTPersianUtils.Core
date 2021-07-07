using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Working with a generic version of DateTime related utilities
    /// </summary>
    public static class GenericsPersianDateTimeUtils
    {
        /// <summary>
        /// Converts an instance of DateTime or DateTimeOffset to an string
        /// </summary>
        public static string FormatDateValue<TValue>(this TValue? value, string dateFormat)
        {
            return value switch
            {
                DateTime dateTimeValue => FormatValue(dateTimeValue, dateFormat),
                DateTimeOffset dateTimeOffsetValue => FormatValue(dateTimeOffsetValue, dateFormat),
                _ => string.Empty,// Handles null for Nullable<DateTime>, etc.
            };
        }

        /// <summary>
        /// Converts an instance of DateTime or DateTimeOffset ToShortPersianDateString
        /// تبدیل تاریخ میلادی به شمسی با قالبی مانند 1395/10/21
        /// </summary>
        public static string FormatDateToShortPersianDate<TValue>(this TValue? value)
        {
            return value switch
            {
                DateTime dateTimeValue =>
                    dateTimeValue == default ? string.Empty : dateTimeValue.ToShortPersianDateString(),
                DateTimeOffset dateTimeOffsetValue =>
                    dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToShortPersianDateString(),
                _ => string.Empty
            };
        }

        /// <summary>
        /// Converts an instance of DateTime or DateTimeOffset ToLongPersianDateString
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        public static string FormatDateToLongPersianDate<TValue>(this TValue? value)
        {
            return value switch
            {
                DateTime dateTimeValue =>
                    dateTimeValue == default ? string.Empty : dateTimeValue.ToLongPersianDateString(),
                DateTimeOffset dateTimeOffsetValue =>
                    dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToLongPersianDateString(),
                _ => string.Empty
            };
        }

        /// <summary>
        /// Converts an instance of DateTime or DateTimeOffset ToLongPersianDateTimeString
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
        /// </summary>
        public static string FormatDateToLongPersianDateTime<TValue>(this TValue? value)
        {
            return value switch
            {
                DateTime dateTimeValue =>
                    dateTimeValue == default ? string.Empty : dateTimeValue.ToLongPersianDateTimeString(),
                DateTimeOffset dateTimeOffsetValue =>
                    dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToLongPersianDateTimeString(),
                _ => string.Empty
            };
        }

        /// <summary>
        /// Converts an instance of DateTime or DateTimeOffset ToShortPersianDateTimeString
        /// تبدیل تاریخ میلادی به شمسی
        /// با قالبی مانند 1395/10/21 10:20
        /// </summary>
        public static string FormatDateToShortPersianDateTime<TValue>(this TValue? value)
        {
            return value switch
            {
                DateTime dateTimeValue =>
                    dateTimeValue == default ? string.Empty : dateTimeValue.ToShortPersianDateTimeString(),
                DateTimeOffset dateTimeOffsetValue =>
                    dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToShortPersianDateTimeString(),
                _ => string.Empty
            };
        }

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>The formatted value.</returns>
        public static string FormatValue(this DateTime value)
            => FormatDateTimeValueCore(value, format: null);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)"/>.</param>
        /// <returns>The formatted value.</returns>
        public static string FormatValue(this DateTime value, string format)
            => FormatDateTimeValueCore(value, format);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>The formatted value.</returns>
        public static string? FormatValue(this DateTime? value)
            => FormatNullableDateTimeValueCore(value, format: null);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="format">The format to use. Provided to <see cref="DateTime.ToString(string, IFormatProvider)"/>.</param>
        /// <returns>The formatted value.</returns>
        public static string? FormatValue(this DateTime? value, string? format)
            => FormatNullableDateTimeValueCore(value, format);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>The formatted value.</returns>
        public static string FormatValue(this DateTimeOffset value)
            => FormatDateTimeOffsetValueCore(value, format: null);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)"/>.</param>
        /// <returns>The formatted value.</returns>
        public static string FormatValue(this DateTimeOffset value, string format)
            => FormatDateTimeOffsetValueCore(value, format);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <returns>The formatted value.</returns>
        public static string? FormatValue(this DateTimeOffset? value)
            => FormatNullableDateTimeOffsetValueCore(value, format: null);

        /// <summary>
        /// Formats the provided <paramref name="value"/> as a <see cref="string"/>.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)"/>.</param>
        /// <returns>The formatted value.</returns>
        public static string? FormatValue(this DateTimeOffset? value, string format)
            => FormatNullableDateTimeOffsetValueCore(value, format);

        /// <summary>
        /// Attempts to convert a Persian value to a DateTime or DateTimeOffset.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="persianDate">A Persian date</param>
        /// <param name="result"></param>
        /// <param name="beginningOfCentury">سال شروع قرن، اگر سال وارد شده دو رقمی است</param>
        /// <param name="throwOnException"></param>
        /// <returns>true if conversion is successful, otherwise false.</returns>
        public static bool TryParsePersianDateToDateTimeOrDateTimeOffset<TValue>(
            this string? persianDate,
            [MaybeNullWhen(false)] out TValue result,
            int beginningOfCentury = 1300,
            bool throwOnException = false)
        {
            try
            {
                if (!persianDate.IsValidPersianDateTime(throwOnException))
                {
                    result = default;
                    return false;
                }

                var targetType = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);

                if (targetType == typeof(DateTime))
                {
                    var dt = persianDate.ToGregorianDateTime(beginningOfCentury: beginningOfCentury);
                    if (dt is null)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = (TValue)(object)dt;
                        return true;
                    }
                }
                else if (targetType == typeof(DateTimeOffset))
                {
                    var dt = persianDate.ToGregorianDateTimeOffset(beginningOfCentury: beginningOfCentury);
                    if (dt is null)
                    {
                        result = default;
                        return false;
                    }
                    else
                    {
                        result = (TValue)(object)dt;
                        return true;
                    }
                }
                else
                {
                    result = default;
                    return false;
                }
            }
            catch
            {
                if (throwOnException)
                {
                    throw;
                }
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to convert a Gregorian value to a DateTime or DateTimeOffset.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value">A Gregorian date</param>
        /// <param name="format"></param>
        /// <param name="result"></param>
        /// <returns>true if conversion is successful, otherwise false.</returns>
        public static bool TryParseDateTimeOrDateTimeOffset<TValue>(
            this string? value,
            string format,
            [MaybeNullWhen(false)] out TValue result)
        {
            var targetType = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);

            if (targetType == typeof(DateTime))
            {
                return TryParseDateTime(value, format, out result);
            }
            else if (targetType == typeof(DateTimeOffset))
            {
                return TryParseDateTimeOffset(value, format, out result);
            }
            else
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to convert a value to a DateTime.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <param name="result"></param>
        /// <returns>true if conversion is successful, otherwise false.</returns>
        private static bool TryParseDateTime<TValue>(
            this string? value,
            string format,
            [MaybeNullWhen(false)] out TValue result)
        {
            var success = TryConvertToDateTime(value, format, out var parsedValue);
            if (success)
            {
                result = (TValue)(object)parsedValue;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to convert a value to a DateTimeOffset.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <param name="result"></param>
        /// <returns>true if conversion is successful, otherwise false.</returns>
        private static bool TryParseDateTimeOffset<TValue>(
            this string? value,
            string format,
            [MaybeNullWhen(false)] out TValue result)
        {
            var success = TryConvertToDateTimeOffset(value, format, out var parsedValue);
            if (success)
            {
                result = (TValue)(object)parsedValue;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to convert a value to a <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToDateTime(this object? obj, out DateTime value)
        {
            return ConvertToDateTimeCore(obj, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="format">The format string to use in conversion.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToDateTime(this object? obj, string format, out DateTime value)
        {
            return ConvertToDateTimeCore(obj, format, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a nullable <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToNullableDateTime(this object? obj, out DateTime? value)
        {
            return ConvertToNullableDateTimeCore(obj, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a nullable <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="format">The format string to use in conversion.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToNullableDateTime(this object? obj, string format, out DateTime? value)
        {
            return ConvertToNullableDateTimeCore(obj, format, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a <see cref="System.DateTimeOffset"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToDateTimeOffset(this object? obj, out DateTimeOffset value)
        {
            return ConvertToDateTimeOffsetCore(obj, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a <see cref="System.DateTimeOffset"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="format">The format string to use in conversion.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToDateTimeOffset(this object? obj, string format, out DateTimeOffset value)
        {
            return ConvertToDateTimeOffsetCore(obj, format, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a nullable <see cref="System.DateTimeOffset"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToNullableDateTimeOffset(this object? obj, out DateTimeOffset? value)
        {
            return ConvertToNullableDateTimeOffsetCore(obj, out value);
        }

        /// <summary>
        /// Attempts to convert a value to a nullable <see cref="System.DateTimeOffset"/>.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <param name="format">The format string to use in conversion.</param>
        /// <param name="value">The converted value.</param>
        /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
        public static bool TryConvertToNullableDateTimeOffset(this object? obj, string format, out DateTimeOffset? value)
        {
            return ConvertToNullableDateTimeOffsetCore(obj, format, out value);
        }

        private static bool ConvertToDateTimeOffsetCore(this object? obj, out DateTimeOffset value)
        {
            return ConvertToDateTimeOffsetCore(obj, format: null, out value);
        }

        private static bool ConvertToDateTimeOffsetCore(this object? obj, string? format, out DateTimeOffset value)
        {
            var text = (string?)obj;
            if (string.IsNullOrEmpty(text))
            {
                value = default;
                return false;
            }

            if (format != null && DateTimeOffset.TryParseExact(
                text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var converted))
            {
                value = converted;
                return true;
            }

            if (format == null && DateTimeOffset.TryParse(
                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
            {
                value = converted;
                return true;
            }

            value = default;
            return false;
        }

        private static bool ConvertToNullableDateTimeOffsetCore(this object? obj, out DateTimeOffset? value)
        {
            return ConvertToNullableDateTimeOffsetCore(obj, format: null, out value);
        }

        private static bool ConvertToNullableDateTimeOffsetCore(
                this object? obj, string? format, out DateTimeOffset? value)
        {
            var text = (string?)obj;
            if (string.IsNullOrEmpty(text))
            {
                value = default;
                return true;
            }

            if (format != null && DateTimeOffset.TryParseExact(
                text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var converted))
            {
                value = converted;
                return true;
            }

            if (format == null && DateTimeOffset.TryParse(
                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
            {
                value = converted;
                return true;
            }

            value = default;
            return false;
        }

        private static string FormatDateTimeValueCore(this DateTime value, string? format)
        {
            if (format != null)
            {
                return value.ToString(format, CultureInfo.InvariantCulture);
            }

            return value.ToString(CultureInfo.InvariantCulture);
        }

        private static string? FormatNullableDateTimeValueCore(this DateTime? value, string? format)
        {
            if (value == null)
            {
                return null;
            }

            if (format != null)
            {
                return value.Value.ToString(format, CultureInfo.InvariantCulture);
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        private static string FormatDateTimeOffsetValueCore(this DateTimeOffset value, string? format)
        {
            if (format != null)
            {
                return value.ToString(format, CultureInfo.InvariantCulture);
            }

            return value.ToString(CultureInfo.InvariantCulture);
        }

        private static string? FormatNullableDateTimeOffsetValueCore(this DateTimeOffset? value, string? format)
        {
            if (value == null)
            {
                return null;
            }

            if (format != null)
            {
                return value.Value.ToString(format, CultureInfo.InvariantCulture);
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        private static bool ConvertToDateTimeCore(this object? obj, out DateTime value)
        {
            return ConvertToDateTimeCore(obj, format: null, out value);
        }

        private static bool ConvertToDateTimeCore(this object? obj, string? format, out DateTime value)
        {
            var text = (string?)obj;
            if (string.IsNullOrEmpty(text))
            {
                value = default;
                return false;
            }

            if (format != null && DateTime.TryParseExact(
                text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var converted))
            {
                value = converted;
                return true;
            }

            if (format == null && DateTime.TryParse(
                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
            {
                value = converted;
                return true;
            }

            value = default;
            return false;
        }

        private static bool ConvertToNullableDateTimeCore(this object? obj, out DateTime? value)
        {
            return ConvertToNullableDateTimeCore(obj, format: null, out value);
        }

        private static bool ConvertToNullableDateTimeCore(this object? obj, string? format, out DateTime? value)
        {
            var text = (string?)obj;
            if (string.IsNullOrEmpty(text))
            {
                value = default;
                return true;
            }

            if (format != null && DateTime.TryParseExact(
                text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var converted))
            {
                value = converted;
                return true;
            }

            if (format == null && DateTime.TryParse(
                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
            {
                value = converted;
                return true;
            }

            value = default;
            return false;
        }
    }
}
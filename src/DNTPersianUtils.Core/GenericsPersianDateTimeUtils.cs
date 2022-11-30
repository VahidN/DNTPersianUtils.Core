using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DNTPersianUtils.Core;

/// <summary>
///     Working with a generic version of DateTime related utilities
/// </summary>
public static class GenericsPersianDateTimeUtils
{
    /// <summary>
    ///     display a numeric value using the equivalent text
    /// </summary>
    /// <param name="number">input number</param>
    /// <param name="language">local language</param>
    /// <returns>the equivalent text</returns>
    public static string ConvertNumberToText<TValue>(this TValue? number, Language language)
    {
        return number switch
               {
                   short shortValue => shortValue.NumberToText(language),
                   ushort ushortValue => ushortValue.NumberToText(language),
                   int intValue => intValue.NumberToText(language),
                   uint uintValue => uintValue.NumberToText(language),
                   byte byteValue => byteValue.NumberToText(language),
                   sbyte sbyteValue => sbyteValue.NumberToText(language),
                   decimal decimalValue => decimalValue.NumberToText(language),
                   double doubleValue => doubleValue.NumberToText(language),
                   float floatValue => floatValue.NumberToText(language),
                   long longValue => longValue.NumberToText(language),
                   ulong ulongValue => ulongValue.NumberToText(language),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset to PersianDay
    /// </summary>
    public static PersianDay? ConvertToPersianDay<TValue>(
        this TValue? value,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? null : dateTimeValue.ToPersianYearMonthDay(convertToIranTimeZone),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? null : dateOnlyValue.ToPersianYearMonthDay(convertToIranTimeZone),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default
                           ? null
                           : dateTimeOffsetValue.ToPersianYearMonthDay(dateTimeOffsetPart),
                   _ => null,
               };
    }

    /// <summary>
    ///     Updates the time part of the input DateOnly?/DateTime?, DateTimeOffset?, DateTimeOffset or DateOnly/DateTime
    /// </summary>
    public static TValue? UpdateTimeOfDayPart<TValue>(this TValue? value, TimeSpan timeSpan)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? default : (TValue)(object)dateTimeValue.Date.Add(timeSpan),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? default : (TValue)(object)dateOnlyValue.AddDays(timeSpan.Days),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default
                           ? default
                           : (TValue)(object)new DateTimeOffset(dateTimeOffsetValue.Date.Add(timeSpan),
                                                                dateTimeOffsetValue.Offset),
                   _ => default,
               };
    }

    /// <summary>
    ///     Gets the TimeOfDay of the input DateOnly?/DateTime?, DateTimeOffset?, DateTimeOffset or DateOnly/DateTime
    /// </summary>
    public static TimeSpan? GetTimeOfDayPart<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? default : dateTimeValue.TimeOfDay,
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? default : dateOnlyValue.ToDateTime().TimeOfDay,
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default ? default : dateTimeOffsetValue.TimeOfDay,
                   _ => default,
               };
    }

    /// <summary>
    ///     Is this date value null or default?
    /// </summary>
    public static bool IsNullOrDefaultDateTimeOrDateTimeOffset<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue => dateTimeValue == default,
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue => dateOnlyValue == default,
#endif
                   DateTimeOffset dateTimeOffsetValue => dateTimeOffsetValue == default,
                   _ => true,
               };
    }

    /// <summary>
    ///     Determines the type of T, which can be DateOnly?/DateTime?, DateTimeOffset?, DateTimeOffset or DateOnly/DateTime.
    /// </summary>
    public static bool IsDateTimeOrDateTimeOffsetType<T>()
    {
        var targetType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
        return targetType == typeof(DateTime) || targetType == typeof(DateTimeOffset)
#if NET6_0 || NET7_0
                                              || targetType == typeof(DateOnly)
#endif
            ;
    }

    /// <summary>
    ///     Determines the type of T, which can be DateTime?, DateTimeOffset?, DateTimeOffset or DateTime.
    /// </summary>
    public static bool IsDateTimeOrDateTimeOffsetType<T>(this T? _) => IsDateTimeOrDateTimeOffsetType<T>();

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset to an string
    /// </summary>
    public static string FormatDateValue<TValue>(this TValue? value, string dateFormat)
    {
        return value switch
               {
                   DateTime dateTimeValue => FormatValue(dateTimeValue, dateFormat),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue => FormatValue(dateOnlyValue, dateFormat),
#endif
                   DateTimeOffset dateTimeOffsetValue => FormatValue(dateTimeOffsetValue, dateFormat),
                   _ => string.Empty, // Handles null for Nullable<DateTime>, etc.
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset ToShortPersianDateString
    ///     تبدیل تاریخ میلادی به شمسی با قالبی مانند 1395/10/21
    /// </summary>
    public static string FormatDateToShortPersianDate<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? string.Empty : dateTimeValue.ToShortPersianDateString(),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? string.Empty : dateOnlyValue.ToShortPersianDateString(),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToShortPersianDateString(),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset ToPersianDateTimeString
    /// </summary>
    public static string FormatDateToPersianDateTime<TValue>(
        this TValue? value,
        string format,
        bool convertToIranTimeZone = true,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default
                           ? string.Empty
                           : dateTimeValue.ToPersianDateTimeString(format, convertToIranTimeZone),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default
                           ? string.Empty
                           : dateOnlyValue.ToPersianDateTimeString(format, convertToIranTimeZone),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default
                           ? string.Empty
                           : dateTimeOffsetValue.ToPersianDateTimeString(format, convertToIranTimeZone,
                                                                         dateTimeOffsetPart),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset ToLongPersianDateString
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
    /// </summary>
    public static string FormatDateToLongPersianDate<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? string.Empty : dateTimeValue.ToLongPersianDateString(),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? string.Empty : dateOnlyValue.ToLongPersianDateString(),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default ? string.Empty : dateTimeOffsetValue.ToLongPersianDateString(),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset ToLongPersianDateTimeString
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 21 دی 1395، 10:20:02 ق.ظ
    /// </summary>
    public static string FormatDateToLongPersianDateTime<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? string.Empty : dateTimeValue.ToLongPersianDateTimeString(),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? string.Empty : dateOnlyValue.ToLongPersianDateTimeString(),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default
                           ? string.Empty
                           : dateTimeOffsetValue.ToLongPersianDateTimeString(),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Converts an instance of DateTime or DateTimeOffset ToShortPersianDateTimeString
    ///     تبدیل تاریخ میلادی به شمسی
    ///     با قالبی مانند 1395/10/21 10:20
    /// </summary>
    public static string FormatDateToShortPersianDateTime<TValue>(this TValue? value)
    {
        return value switch
               {
                   DateTime dateTimeValue =>
                       dateTimeValue == default ? string.Empty : dateTimeValue.ToShortPersianDateTimeString(),
#if NET6_0 || NET7_0
                   DateOnly dateOnlyValue =>
                       dateOnlyValue == default ? string.Empty : dateOnlyValue.ToShortPersianDateTimeString(),
#endif
                   DateTimeOffset dateTimeOffsetValue =>
                       dateTimeOffsetValue == default
                           ? string.Empty
                           : dateTimeOffsetValue.ToShortPersianDateTimeString(),
                   _ => string.Empty,
               };
    }

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateTime value)
        => FormatDateTimeValueCore(value, null);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateOnly value)
        => FormatDateOnlyValueCore(value, null);
#endif

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateTime value, string format)
        => FormatDateTimeValueCore(value, format);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateOnly value, string format)
        => value.ToDateTime().FormatValue(format);
#endif

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateTime? value)
        => FormatNullableDateTimeValueCore(value, null);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateOnly? value)
        => FormatNullableDateOnlyValueCore(value, null);
#endif

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTime.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateTime? value, string? format)
        => FormatNullableDateTimeValueCore(value, format);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTime.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateOnly? value, string? format)
        => value.ToDateTime().FormatValue(format);
#endif

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateTimeOffset value)
        => FormatDateTimeOffsetValueCore(value, null);

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string FormatValue(this DateTimeOffset value, string format)
        => FormatDateTimeOffsetValueCore(value, format);

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateTimeOffset? value)
        => FormatNullableDateTimeOffsetValueCore(value, null);

    /// <summary>
    ///     Formats the provided <paramref name="value" /> as a <see cref="string" />.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <param name="format">The format to use. Provided to <see cref="DateTimeOffset.ToString(string, IFormatProvider)" />.</param>
    /// <returns>The formatted value.</returns>
    public static string? FormatValue(this DateTimeOffset? value, string format)
        => FormatNullableDateTimeOffsetValueCore(value, format);

    /// <summary>
    ///     Attempts to convert a Persian value to a DateTime/DateOnly or DateTimeOffset.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="persianDate">A Persian date</param>
    /// <param name="result"></param>
    /// <param name="beginningOfCentury">سال شروع قرن، اگر سال وارد شده دو رقمی است</param>
    /// <param name="throwOnException"></param>
    /// <returns>true if conversion is successful, otherwise false.</returns>
    public static bool TryParsePersianDateToDateTimeOrDateTimeOffset<TValue>(
        this string? persianDate,
#if NET5_0 || NETSTANDARD2_1 || NET6_0 || NET7_0
        [MaybeNullWhen(false)]
#endif
        out TValue? result,
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

                result = (TValue)(object)dt;
                return true;
            }

            if (targetType == typeof(DateTimeOffset))
            {
                var dt = persianDate.ToGregorianDateTimeOffset(beginningOfCentury: beginningOfCentury);
                if (dt is null)
                {
                    result = default;
                    return false;
                }

                result = (TValue)(object)dt;
                return true;
            }
#if NET6_0 || NET7_0

            if (targetType == typeof(DateOnly))
            {
                var dt = persianDate.ToGregorianDateOnly(beginningOfCentury: beginningOfCentury);
                if (dt is null)
                {
                    result = default;
                    return false;
                }

                result = (TValue)(object)dt;
                return true;
            }
#endif

            result = default;
            return false;
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
    ///     Attempts to convert a Gregorian value to a DateTime/DateOnly or DateTimeOffset.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value">A Gregorian date</param>
    /// <param name="format"></param>
    /// <param name="result"></param>
    /// <returns>true if conversion is successful, otherwise false.</returns>
    public static bool TryParseDateTimeOrDateTimeOffset<TValue>(
        this string? value,
        string format,
#if NET5_0 || NETSTANDARD2_1 || NET6_0 || NET7_0
        [MaybeNullWhen(false)]
#endif
        out TValue? result)
    {
        var targetType = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);

        if (targetType == typeof(DateTime))
        {
            return TryParseDateTime(value, format, out result);
        }

        if (targetType == typeof(DateTimeOffset))
        {
            return TryParseDateTimeOffset(value, format, out result);
        }
#if NET6_0 || NET7_0

        if (targetType == typeof(DateOnly))
        {
            return TryParseDateOnly(value, format, out result);
        }
#endif

        result = default;
        return false;
    }

    /// <summary>
    ///     Attempts to convert a value to a DateTime.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value"></param>
    /// <param name="format"></param>
    /// <param name="result"></param>
    /// <returns>true if conversion is successful, otherwise false.</returns>
    private static bool TryParseDateTime<TValue>(
        this string? value,
        string format,
#if NET5_0 || NETSTANDARD2_1 || NET6_0 || NET7_0
        [MaybeNullWhen(false)]
#endif
        out TValue? result)
    {
        var success = TryConvertToDateTime(value, format, out var parsedValue);
        if (success)
        {
            result = (TValue)(object)parsedValue;
            return true;
        }

        result = default;
        return false;
    }

#if NET6_0 || NET7_0
    /// <summary>
    ///     Attempts to convert a value to a DateOnly.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value"></param>
    /// <param name="format"></param>
    /// <param name="result"></param>
    /// <returns>true if conversion is successful, otherwise false.</returns>
    private static bool TryParseDateOnly<TValue>(
        this string? value,
        string format,
        [MaybeNullWhen(false)] out TValue? result)
    {
        var success = TryConvertToDateOnly(value, format, out var parsedValue);
        if (success)
        {
            result = (TValue)(object)parsedValue;
            return true;
        }

        result = default;
        return false;
    }
#endif

    /// <summary>
    ///     Attempts to convert a value to a DateTimeOffset.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="value"></param>
    /// <param name="format"></param>
    /// <param name="result"></param>
    /// <returns>true if conversion is successful, otherwise false.</returns>
    private static bool TryParseDateTimeOffset<TValue>(
        this string? value,
        string format,
#if NET5_0 || NETSTANDARD2_1 || NET6_0 || NET7_0
        [MaybeNullWhen(false)]
#endif
        out TValue? result)
    {
        var success = TryConvertToDateTimeOffset(value, format, out var parsedValue);
        if (success)
        {
            result = (TValue)(object)parsedValue;
            return true;
        }

        result = default;
        return false;
    }

    /// <summary>
    ///     Attempts to convert a value to a <see cref="System.DateTime" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateTime(this object? obj, out DateTime value) =>
        ConvertToDateTimeCore(obj, out value);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Attempts to convert a value to a <see cref="DateOnly" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateOnly(this object? obj, out DateOnly value) =>
        ConvertToDateOnlyCore(obj, out value);
#endif

    /// <summary>
    ///     Attempts to convert a value to a <see cref="System.DateTime" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateTime(this object? obj, string format, out DateTime value) =>
        ConvertToDateTimeCore(obj, format, out value);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Attempts to convert a value to a <see cref="DateOnly" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateOnly(this object? obj, string format, out DateOnly value) =>
        ConvertToDateOnlyCore(obj, format, out value);
#endif

    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="System.DateTime" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateTime(this object? obj, out DateTime? value) =>
        ConvertToNullableDateTimeCore(obj, out value);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="DateOnly" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateOnly(this object? obj, out DateOnly? value) =>
        ConvertToNullableDateOnlyCore(obj, out value);
#endif

    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="System.DateTime" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateTime(this object? obj, string format, out DateTime? value) =>
        ConvertToNullableDateTimeCore(obj, format, out value);

#if NET6_0 || NET7_0
    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="DateOnly" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateOnly(this object? obj, string format, out DateOnly? value) =>
        ConvertToNullableDateOnlyCore(obj, format, out value);
#endif

    /// <summary>
    ///     Attempts to convert a value to a <see cref="System.DateTimeOffset" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateTimeOffset(this object? obj, out DateTimeOffset value) =>
        ConvertToDateTimeOffsetCore(obj, out value);

    /// <summary>
    ///     Attempts to convert a value to a <see cref="System.DateTimeOffset" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToDateTimeOffset(this object? obj, string format, out DateTimeOffset value) =>
        ConvertToDateTimeOffsetCore(obj, format, out value);

    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="System.DateTimeOffset" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateTimeOffset(this object? obj, out DateTimeOffset? value) =>
        ConvertToNullableDateTimeOffsetCore(obj, out value);

    /// <summary>
    ///     Attempts to convert a value to a nullable <see cref="System.DateTimeOffset" />.
    /// </summary>
    /// <param name="obj">The object to convert.</param>
    /// <param name="format">The format string to use in conversion.</param>
    /// <param name="value">The converted value.</param>
    /// <returns><c>true</c> if conversion is successful, otherwise <c>false</c>.</returns>
    public static bool TryConvertToNullableDateTimeOffset(this object? obj, string format, out DateTimeOffset? value) =>
        ConvertToNullableDateTimeOffsetCore(obj, format, out value);

    private static bool ConvertToDateTimeOffsetCore(this object? obj, out DateTimeOffset value) =>
        ConvertToDateTimeOffsetCore(obj, null, out value);

    private static bool ConvertToDateTimeOffsetCore(this object? obj, string? format, out DateTimeOffset value)
    {
        var text = (string?)obj;
        if (string.IsNullOrEmpty(text))
        {
            value = default;
            return false;
        }

        if (format != null && DateTimeOffset.TryParseExact(
                                                           text, format, CultureInfo.InvariantCulture,
                                                           DateTimeStyles.None, out var converted))
        {
            value = converted;
            return true;
        }

        if (format == null && DateTimeOffset.TryParse(
                                                      text, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                      out converted))
        {
            value = converted;
            return true;
        }

        value = default;
        return false;
    }

    private static bool ConvertToNullableDateTimeOffsetCore(this object? obj, out DateTimeOffset? value) =>
        ConvertToNullableDateTimeOffsetCore(obj, null, out value);

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
                                                           text, format, CultureInfo.InvariantCulture,
                                                           DateTimeStyles.None, out var converted))
        {
            value = converted;
            return true;
        }

        if (format == null && DateTimeOffset.TryParse(
                                                      text, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                      out converted))
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

#if NET6_0 || NET7_0
    private static string FormatDateOnlyValueCore(this DateOnly value, string? format) =>
        value.ToDateTime().FormatDateTimeValueCore(format);
#endif

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

#if NET6_0 || NET7_0
    private static string? FormatNullableDateOnlyValueCore(this DateOnly? value, string? format) =>
        value.ToDateTime().FormatNullableDateTimeValueCore(format);
#endif

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

    private static bool ConvertToDateTimeCore(this object? obj, out DateTime value) =>
        ConvertToDateTimeCore(obj, null, out value);

#if NET6_0 || NET7_0
    private static bool ConvertToDateOnlyCore(this object? obj, out DateOnly value) =>
        ConvertToDateOnlyCore(obj, null, out value);
#endif

    private static bool ConvertToDateTimeCore(this object? obj, string? format, out DateTime value)
    {
        var text = (string?)obj;
        if (string.IsNullOrEmpty(text))
        {
            value = default;
            return false;
        }

        if (format != null && DateTime.TryParseExact(
                                                     text, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                     out var converted))
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

#if NET6_0 || NET7_0
    private static bool ConvertToDateOnlyCore(this object? obj, string? format, out DateOnly value)
    {
        var text = (string?)obj;
        if (string.IsNullOrEmpty(text))
        {
            value = default;
            return false;
        }

        if (format != null && DateOnly.TryParseExact(
                                                     text, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                     out var converted))
        {
            value = converted;
            return true;
        }

        if (format == null && DateOnly.TryParse(
                                                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
        {
            value = converted;
            return true;
        }

        value = default;
        return false;
    }
#endif

    private static bool ConvertToNullableDateTimeCore(this object? obj, out DateTime? value) =>
        ConvertToNullableDateTimeCore(obj, null, out value);

#if NET6_0 || NET7_0
    private static bool ConvertToNullableDateOnlyCore(this object? obj, out DateOnly? value) =>
        ConvertToNullableDateOnlyCore(obj, null, out value);
#endif

    private static bool ConvertToNullableDateTimeCore(this object? obj, string? format, out DateTime? value)
    {
        var text = (string?)obj;
        if (string.IsNullOrEmpty(text))
        {
            value = default;
            return true;
        }

        if (format != null && DateTime.TryParseExact(
                                                     text, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                     out var converted))
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

#if NET6_0 || NET7_0
    private static bool ConvertToNullableDateOnlyCore(this object? obj, string? format, out DateOnly? value)
    {
        var text = (string?)obj;
        if (string.IsNullOrEmpty(text))
        {
            value = default;
            return true;
        }

        if (format != null && DateOnly.TryParseExact(
                                                     text, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
                                                     out var converted))
        {
            value = converted;
            return true;
        }

        if (format == null && DateOnly.TryParse(
                                                text, CultureInfo.InvariantCulture, DateTimeStyles.None, out converted))
        {
            value = converted;
            return true;
        }

        value = default;
        return false;
    }
#endif
}
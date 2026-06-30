using System;
using System.Globalization;
using System.Linq;
using System.Text;
#if NET7_0 || NET8_0 || NET9_0 || NET10_0 || NETSTANDARD2_1 || NET5_0 || NET6_0
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
#endif

namespace DNTPersianUtils.Core;

/// <summary>
///     رشتهٔ ورودی را نرمال‌سازی کرده و در صورت معتبر بودن، آن را به نوع عددی موردنظر تبدیل می‌کند.
/// </summary>
public static class NumberNormalizer
{
#if NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     رشتهٔ ورودی را نرمال‌سازی کرده و در صورت معتبر بودن، آن را به نوع عددی موردنظر تبدیل می‌کند.
    /// </summary>
    /// <typeparam name="T">
    ///     نوع عددی مقصد که از <see cref="INumber{TSelf}" /> پشتیبانی می‌کند؛
    ///     مانند <see cref="int" />, <see cref="long" />, <see cref="float" />,
    ///     <see cref="double" />, <see cref="decimal" /> و <see cref="System.Numerics.BigInteger" />.
    /// </typeparam>
    /// <param name="value">
    ///     رشتهٔ ورودی که ممکن است شامل قالب‌های متداول ورود اعداد توسط کاربران باشد.
    /// </param>
    /// <param name="number">
    ///     در صورت موفقیت، مقدار عددی تبدیل‌شده؛
    ///     در غیر این صورت مقدار پیش‌فرض نوع <typeparamref name="T" />.
    /// </param>
    /// <returns>
    ///     اگر نرمال‌سازی و تبدیل با موفقیت انجام شود مقدار <see langword="true" />؛
    ///     در غیر این صورت مقدار <see langword="false" />.
    /// </returns>
    public static bool TryNormalizeAndParseNumberString<T>([NotNullWhen(returnValue: true)] this string? value,
        [MaybeNullWhen(returnValue: false)] out T number)
        where T : INumber<T>
    {
        number = default;

        var normalized = value.ToNormalizedNumberString();

        return normalized is not null &&
               T.TryParse(normalized, NumberStyles.Number, CultureInfo.InvariantCulture, out number);
    }
#endif

    /// <summary>
    ///     رشتهٔ ورودی را نرمال‌سازی کرده و در صورت معتبر بودن، آن را به نوع عددی موردنظر تبدیل می‌کند.
    /// </summary>
    /// <param name="value">
    ///     رشتهٔ ورودی که ممکن است شامل قالب‌های متداول ورود اعداد توسط کاربران باشد.
    /// </param>
    /// <param name="number">
    ///     در صورت موفقیت، مقدار عددی تبدیل‌شده؛
    ///     در غیر این صورت مقدار پیش‌فرض نوع decimal.
    /// </param>
    /// <returns>
    ///     اگر نرمال‌سازی و تبدیل با موفقیت انجام شود مقدار <see langword="true" />؛
    ///     در غیر این صورت مقدار <see langword="false" />.
    /// </returns>
    public static bool TryNormalizeAndParseNumberString(
#if NET7_0 || NET8_0 || NET9_0 || NET10_0
        [NotNullWhen(returnValue: true)]
#endif
        this string? value,
        out decimal number)
    {
        number = 0;

        var normalized = value.ToNormalizedNumberString();

        return normalized is not null &&
               decimal.TryParse(normalized, NumberStyles.Number, CultureInfo.InvariantCulture, out number);
    }

    /// <summary>
    ///     رشتهٔ ورودی را با اعمال نرمال‌سازی روی اعداد و علائم، به قالب استاندارد قابل پردازش تبدیل می‌کند.
    /// </summary>
    /// <param name="value">
    ///     رشتهٔ ورودی که ممکن است شامل ارقام فارسی یا عربی، جداکننده‌های اعشار یا هزارگان،
    ///     علائم مثبت یا منفی یونیکد، فاصله‌ها یا سایر قالب‌های رایج ورود عدد توسط کاربران باشد.
    /// </param>
    /// <returns>
    ///     در صورت موفقیت، رشتهٔ نرمال‌شده را برمی‌گرداند؛
    ///     در غیر این صورت (در صورت نامعتبر یا مبهم بودن ورودی) مقدار <see langword="null" /> برگردانده می‌شود.
    /// </returns>
    public static string? ToNormalizedNumberString(this string? value)
    {
        value = value?.Trim();

        if (IsNullOrEmptyOrSign(value))
        {
            return null;
        }

        if (TryNormalizeDecimalAndThousandsSeparators(value, out var normalizedValue))
        {
            value = normalizedValue;
        }

        var sb = new StringBuilder(value.Length + 2);

        var signCount = 0;
        var decimalSeparatorCount = 0;

        for (var i = 0; i < value.Length; i++)
        {
            var ch = value[i];

            if (ch.TryConvertPersianDigit(out var digit) || ch.TryConvertArabicDigit(out digit))
            {
                sb.Append(digit);

                continue;
            }

            if (char.IsDigit(ch))
            {
                sb.Append(ch);

                continue;
            }

            if (ch.IsDecimalSeparator())
            {
                decimalSeparatorCount++;

                if (decimalSeparatorCount > 1)
                {
                    return null;
                }

                sb.Append(value: '.');

                continue;
            }

            if (ch.IsSign())
            {
                if (i != 0)
                {
                    return null;
                }

                signCount++;

                if (signCount > 1)
                {
                    return null;
                }

                sb.Append(ch.IsPlusSign() ? '+' : '-');

                continue;
            }

            if (ch.IsSpace() || ch.IsThousandsSeparator())
            {
                continue;
            }

            return null;
        }

        var result = sb.ToString();

        if (IsNullOrEmptyOrSign(result))
        {
            return null;
        }

        result = NormalizeIncompleteNumbers(result);

        return result;
    }

    private static bool IsNullOrEmptyOrSign(
#if NET7_0 || NET8_0 || NET9_0 || NET10_0 || NETSTANDARD2_1 || NET5_0 || NET6_0
        [NotNullWhen(returnValue: false)]
#endif
        string? value)
        => string.IsNullOrEmpty(value) || string.Equals(value, b: "-", StringComparison.Ordinal) ||
           string.Equals(value, b: "+", StringComparison.Ordinal);

    private static string NormalizeIncompleteNumbers(string result)
    {
        if (result.StartsWith(value: ".", StringComparison.Ordinal))
        {
            result = $"0{result}";
        }
        else if (result.StartsWith(value: "-.", StringComparison.Ordinal))
        {
            result = $"-0{result.Substring(startIndex: 1)}";
        }
        else if (result.StartsWith(value: "+.", StringComparison.Ordinal))
        {
            result = $"+0{result.Substring(startIndex: 1)}";
        }

        if (result.EndsWith(value: ".", StringComparison.Ordinal))
        {
            result += "0";
        }

        return result;
    }

    private static bool TryNormalizeDecimalAndThousandsSeparators(string value, out string result)
    {
        var hasDotsThousandsSeparator = value.HasThousandsSeparator(separator: '.');
        var hasCommasThousandsSeparator = value.HasThousandsSeparator(separator: ',');

        var lastDot = value.LastIndexOf(value: '.');
        var lastComma = value.LastIndexOf(value: ',');

        // فقط رقم
        if (lastDot < 0 && lastComma < 0)
        {
            result = value;

            return true;
        }

        // فقط نقطه
        if (lastComma < 0)
        {
            // بیش از یک نقطه؟
            if (value.Where(c => c == '.').Skip(count: 1).Any())
            {
                // آیا همه به صورت هزارگان هستند؟
                if (hasDotsThousandsSeparator)
                {
                    result = value.Replace(oldValue: ".", newValue: "", StringComparison.Ordinal);

                    return true;
                }

                result = value;

                return false;
            }

            result = value;

            return true;
        }

        // فقط کاما
        if (lastDot < 0)
        {
            if (value.Where(c => c == ',').Skip(count: 1).Any())
            {
                if (hasCommasThousandsSeparator)
                {
                    result = value.Replace(oldValue: ",", newValue: "", StringComparison.Ordinal);

                    return true;
                }

                result = value;

                return false;
            }

            // فقط یک کاما

            var digitsAfter = value.Length - lastComma - 1;

            if (digitsAfter == 3 && hasCommasThousandsSeparator)
            {
                // 1,000
                result = value.Replace(oldValue: ",", newValue: "", StringComparison.Ordinal);

                return true;
            }

            // یک کاما
            result = value.Replace(oldChar: ',', newChar: '.');

            return true;
        }

        // هر دو وجود دارند

        if (lastDot > lastComma)
        {
            // US
            result = value.Replace(oldValue: ",", newValue: "", StringComparison.Ordinal);

            return true;
        }

        // European
        result = value.Replace(oldValue: ".", newValue: "", StringComparison.Ordinal)
            .Replace(oldChar: ',', newChar: '.');

        return true;
    }

    /// <summary>
    ///     آيا يك كاراكتر جداكننده هزارگان متداول دارد؟
    /// </summary>
    public static bool HasThousandsSeparator(this string? value, char separator)
    {
        var parts = value?.Split(separator) ?? [];

        if (parts.Length < 2)
        {
            return false;
        }

        // قسمت اول: 1 تا 3 رقم
        if (parts[0].Length is < 1 or > 3)
        {
            return false;
        }

        if (!parts[0].All(char.IsDigit))
        {
            return false;
        }

        // بقیه دقیقاً سه رقم
        for (var i = 1; i < parts.Length; i++)
        {
            if (parts[i].Length != 3)
            {
                return false;
            }

            if (!parts[i].All(char.IsDigit))
            {
                return false;
            }
        }

        return true;
    }
}
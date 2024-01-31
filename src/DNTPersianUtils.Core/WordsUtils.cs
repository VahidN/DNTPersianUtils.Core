using System;
using System.Globalization;

namespace DNTPersianUtils.Core;

/// <summary>
///     Words extensions
/// </summary>
public static class WordsUtils
{
    private static readonly char[] _separator =
    [
        ' ', ',', ';', '.', '!', '"', '(', ')', '?', ':', '\'', '«', '»', '+', '-'
    ];

    /// <summary>
    ///     تعداد كلمه‌ي موجود در يك رشته را مشخص مي‌كند
    /// </summary>
    public static int WordsCount(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        text = text.CleanTags().Trim();
        text = text.Replace("\t", " ", StringComparison.Ordinal);
        text = text.Replace("\n", " ", StringComparison.Ordinal);
        text = text.Replace("\r", " ", StringComparison.Ordinal);

        var words = text.Split(_separator, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    private static string CleanTags(this string data)
        => data.Replace("\n", "\n ", StringComparison.Ordinal).StripHtmlTags();

    /// <summary>
    ///     خواندن يك متن چند دقيقه طول مي‌كشد؟
    /// </summary>
    public static int MinReadTime(this string? text, int wordsPerMinute = 180)
    {
        var wordsCount = text.WordsCount();
        var minReadTime = wordsCount / wordsPerMinute;

        return minReadTime;
    }

    /// <summary>
    ///     خواندن يك متن چقدر طول مي‌كشد؟
    /// </summary>
    public static string MinReadTimeToString(this int minutes)
        => minutes == 0 ? "کمتر از یک دقیقه" : TimeSpan.FromMinutes(minutes).ToReadableString();

    /// <summary>
    ///     خواندن يك متن چند دقيقه طول مي‌كشد؟
    /// </summary>
    public static string MinReadTimeToString(this string? text, int wordsPerMinute = 180)
        => text.MinReadTime(wordsPerMinute).MinReadTimeToString();

    private static string ToReadableString(this TimeSpan span)
    {
        var formatted = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}",
            span.Duration().Days > 0 ? $"{span.Days.NumberToText(Language.Persian)} روز و " : string.Empty,
            span.Duration().Hours > 0 ? $"{span.Hours.NumberToText(Language.Persian)} ساعت و " : string.Empty,
            span.Duration().Minutes > 0 ? $"{span.Minutes.NumberToText(Language.Persian)} دقیقه و " : string.Empty,
            span.Duration().Seconds > 0 ? $"{span.Seconds.NumberToText(Language.Persian)} ثانیه" : string.Empty);

        if (formatted.EndsWith("و ", StringComparison.Ordinal))
        {
            formatted = formatted.Substring(0, formatted.Length - 2);
        }

        if (string.IsNullOrEmpty(formatted))
        {
            formatted = "0 ثانیه";
        }

        return formatted.Trim();
    }
}
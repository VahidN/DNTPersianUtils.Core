using System;

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
        text = text.Replace(oldValue: "\t", newValue: " ", StringComparison.Ordinal);
        text = text.Replace(oldValue: "\n", newValue: " ", StringComparison.Ordinal);
        text = text.Replace(oldValue: "\r", newValue: " ", StringComparison.Ordinal);

        var words = text.Split(_separator, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    private static string CleanTags(this string data)
        => data.Replace(oldValue: "\n", newValue: "\n ", StringComparison.Ordinal).StripHtmlTags();

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
        => minutes == 0 ? "کمتر از یک دقیقه" : TimeSpan.FromMinutes(minutes).ToFriendlyPersianTimeSpanString();

    /// <summary>
    ///     خواندن يك متن چند دقيقه طول مي‌كشد؟
    /// </summary>
    public static string MinReadTimeToString(this string? text, int wordsPerMinute = 180)
        => text.MinReadTime(wordsPerMinute).MinReadTimeToString();

    /// <summary>
    ///     اگر متن خالي است، سه نقطه را بازگشت مي‌دهد
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static string ReturnDotsIfEmpty(this string? data) => string.IsNullOrWhiteSpace(data) ? "..." : data;

    /// <summary>
    ///     خلاصه ابتدايي يك متن را به طول مشخص شده بازگشت مي‌دهد
    /// </summary>
    /// <param name="data"></param>
    /// <param name="charLength"></param>
    /// <returns></returns>
    public static string GetBriefDescription(this string? data, int charLength)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            return "...";
        }

        if (data.Length < charLength)
        {
            return ReturnDotsIfEmpty(data.StripHtmlTags());
        }

        data = data.StripHtmlTags();

        return data.Length < charLength
            ? data.ReturnDotsIfEmpty()
#if NET6_0 || NET7_0 || NET8_0 || NET9_0
            : string.Concat(data.AsSpan(start: 0, charLength - 7), str1: " ...");
#else
            : string.Concat(data.Substring(0, charLength - 7), " ...");
#endif
    }
}
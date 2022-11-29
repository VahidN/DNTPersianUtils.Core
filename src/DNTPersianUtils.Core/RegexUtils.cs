﻿using System;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core;

/// <summary>
///     متدهای کمکی مبتنی بر عبارات باقاعده
/// </summary>
public static class RegexUtils
{
    /// <summary>
    ///     زمان انقضای پردازش عبارت باقاعده
    /// </summary>
    public static readonly TimeSpan MatchTimeout = TimeSpan.FromMinutes(1);

    private static readonly Regex _matchAllTags =
        new(@"<(.|\n)*?>", RegexOptions.Compiled | RegexOptions.IgnoreCase, MatchTimeout);

    private static readonly Regex _matchArabicHebrew =
        new(@"[\u0600-\u06FF,\u0590-\u05FF,«,»]", RegexOptions.Compiled | RegexOptions.IgnoreCase, MatchTimeout);

    private static readonly Regex _matchOnlyPersianNumbersRange =
        new(@"^[\u06F0-\u06F9]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase, MatchTimeout);

    private static readonly Regex _matchOnlyPersianLetters =
        new(@"^[\\s,\u06A9\u06AF\u06C0\u06CC\u060C,\u062A\u062B\u062C\u062D\u062E\u062F,\u063A\u064A\u064B\u064C\u064D\u064E,\u064F\u067E\u0670\u0686\u0698\u200C,\u0621-\u0629\u0630-\u0639\u0641-\u0654]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase, MatchTimeout);

    internal static readonly Regex _hasHalfSpaces =
        new(@"\u200B|\u200C|\u200E|\u200F",
            RegexOptions.Compiled | RegexOptions.IgnoreCase, MatchTimeout);

    /// <summary>
    ///     آیا عبارت مدنظر حاوی حروف و اعداد فارسی است؟
    /// </summary>
    public static bool ContainsFarsi(this string? txt, bool allowWhitespace = false)
    {
        if (string.IsNullOrEmpty(txt))
        {
            return false;
        }

        var input = txt.StripHtmlTags().Replace(",", "", StringComparison.OrdinalIgnoreCase);
        if (allowWhitespace)
        {
            input = input.RemoveAllWhitespaces();
        }

        return _matchArabicHebrew.IsMatch(input);
    }

    /// <summary>
    ///     آیا عبارت مدنظر فقط حاوی حروف فارسی است؟
    /// </summary>
    public static bool ContainsOnlyFarsiLetters(this string? txt, bool allowWhitespace = false)
    {
        if (string.IsNullOrEmpty(txt))
        {
            return false;
        }

        var input = txt.StripHtmlTags().Replace(",", "", StringComparison.OrdinalIgnoreCase);
        if (allowWhitespace)
        {
            input = input.RemoveAllWhitespaces();
        }

        return _matchOnlyPersianLetters.IsMatch(input);
    }

    /// <summary>
    ///     حذف تمام فواصل خالی از یک رشته
    /// </summary>
    public static string RemoveAllWhitespaces(this string? txt)
    {
        if (txt is null)
        {
            return string.Empty;
        }

        return string.Join("", txt.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }

    /// <summary>
    ///     حذف تگ‌های یک عبارت
    /// </summary>
    public static string StripHtmlTags(this string? text) =>
        string.IsNullOrEmpty(text)
            ? string.Empty
            : _matchAllTags.Replace(text, " ").Replace("&nbsp;", " ", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    ///     اگر متن شما حاوی یک عبارت فارسی باشد آن‌را داخل یک بلاک اچ تی ام ال راست به چپ محصور می‌کند
    ///     <div style='text-align: right; font-family:{fontFamily}; font-size:{fontSize};' dir='rtl'>{body}</div>
    ///     در غیراینصورت در
    ///     <div style='text-align: left; font-family:{fontFamily}; font-size:{fontSize};' dir='ltr'>{body}</div>
    /// </summary>
    public static string WrapInDirectionalDiv(this string? body, string fontFamily = "tahoma", string fontSize = "9pt")
    {
        if (string.IsNullOrWhiteSpace(body))
        {
            return string.Empty;
        }

        if (ContainsFarsi(body, true))
        {
            return
                $"<div style='text-align: right; font-family:{fontFamily}; font-size:{fontSize};' dir='rtl'>{body}</div>";
        }

        return $"<div style='text-align: left; font-family:{fontFamily}; font-size:{fontSize};' dir='ltr'>{body}</div>";
    }

    /// <summary>
    ///     آیا عبارت مدنظر فقط حاوی اعداد فارسی است؟
    /// </summary>
    public static bool ContainsOnlyPersianNumbers(this string? text, bool allowWhitespace = false)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }

        var input = text.StripHtmlTags();
        if (allowWhitespace)
        {
            input = input.RemoveAllWhitespaces();
        }

        return _matchOnlyPersianNumbersRange.IsMatch(input);
    }

    /// <summary>
    ///     آیا عبارت مدنظر شامل نیم فاصله است؟
    /// </summary>
    public static bool ContainsHalfSpace(this string text)
        => _hasHalfSpaces.IsMatch(text);

    /// <summary>
    ///     آیا عبارت مدنظر شامل نیم فاصله است؟
    /// </summary>
    public static bool ContainsThinSpace(this string text)
        => ContainsHalfSpace(text);
}
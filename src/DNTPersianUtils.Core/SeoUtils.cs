using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DNTPersianUtils.Core.Normalizer;

namespace DNTPersianUtils.Core;

/// <summary>
///     متدهای کمکی مخصوص موتورهاي جستجو
/// </summary>
public static class SeoUtils
{
    /// <summary>
    ///     ليستي از حروفي كه عموما در عناوين مقالات فارسي حضور دارند و بايد تبديل شوند
    /// </summary>
    public static readonly ISet<char> PersianSlugReplacements = new HashSet<char>
    {
        '"',
        '\'',
        '%',
        '=',
        ':',
        '&',
        '?',
        '/',
        '\\',
        '(',
        ')',
        ';',
        '*',
        '؟',
        '!',
        '،',
        '؛',
        '«',
        '»',
        '|',
        '.',
        '#',
        ' ',
        '+',
        ',',
        '<',
        '>',
        '$',
        '@'
    };

    /// <summary>
    ///     ليستي از حروفي كه عموما در عناوين برچسب‌ها فارسي حضور دارند و بايد تبديل شوند
    /// </summary>
    public static readonly ISet<char> PersianTagReplacements = new HashSet<char>
    {
        '"',
        '\'',
        '%',
        '=',
        ':',
        '&',
        '?',
        '/',
        '\\',
        '(',
        ')',
        ';',
        '*',
        '؟',
        '!',
        '،',
        '؛',
        '«',
        '»',
        '|',
        ',',
        '<',
        '>'
    };

    /// <summary>
    ///     عموما عنوان يك مطلب را با حذف زوائد آن تبديل به رشته‌اي مي‌كنيم كه اگر در انتهاي آدرس‌ها قرار گيرد، مطلوب موتورهاي
    ///     جستجو است.
    ///     در اينجا ليستي از حروف خاص، با - جايگزين خواهند شد.
    ///     اگر حروف ديگري مدنظر است، آن‌را به ليست اضافه كنيد.
    ///     حروفي كه در اينجا به صورت پيش‌فرض استفاده مي‌شوند، مخصوص عناوين فارسي هستند.
    ///     در اين متد، اصلاح ي و ك، حذف اعراب و كوچك شدن حروف به صورت خودكار انجام مي‌شود.
    /// </summary>
    /// <param name="postTitle">عنوان مقاله</param>
    /// <param name="replacements">
    ///     اگر مقدار دهي نشود از مقدار پيش‌فرض همين كلاس استفاده خواهد شد يعني
    ///     SeoUtils.PersianSlugReplacements
    /// </param>
    /// <param name="convertToLower">آيا تبديل به حروف كوچك شود؟</param>
    /// <param name="replacementChar">در اينجا ليستي از حروف خاص، با - جايگزين خواهند شد</param>
    /// <param name="charsWhiteList">اين ليست اختياري از ليست جايگزين‌ها حذف مي‌شود</param>
    /// <returns></returns>
    public static string? GetPostSlug(
#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
        [NotNullIfNotNull(nameof(postTitle))]
#endif
        this string? postTitle,
        ISet<char>? replacements = null,
        bool convertToLower = true,
        char replacementChar = '-',
        params IEnumerable<char>? charsWhiteList)
    {
        if (string.IsNullOrWhiteSpace(postTitle))
        {
            return postTitle;
        }

        replacements ??= PersianSlugReplacements;

        ApplyWhiteList(replacements, charsWhiteList);

        postTitle = postTitle.Trim();

        if (convertToLower)
        {
            postTitle = postTitle.ToLowerInvariant();
        }

        postTitle = postTitle.RemoveDiacritics().RemoveHexadecimalSymbols().ApplyCorrectYeKe();

        var dataChars = postTitle.ToCharArray();

        for (var i = 0; i < dataChars.Length; i++)
        {
            foreach (var item in replacements)
            {
                if (dataChars[i] == item)
                {
                    dataChars[i] = replacementChar;
                }
            }
        }

        var result = new string(dataChars);

        // remove duplicate dashes
        result = string.Join(replacementChar.ToString(), result.Split(new[]
        {
            replacementChar
        }, StringSplitOptions.RemoveEmptyEntries));

        return result.Trim(replacementChar);
    }

    /// <summary>
    ///     عموما عنوان يك تگ را با حذف زوائد آن تبديل به رشته‌اي مي‌كنيم كه اگر در انتهاي آدرس‌ها قرار گيرد، مطلوب موتورهاي
    ///     جستجو است.
    ///     در اينجا ليستي از حروف خاص، با _ جايگزين خواهند شد.
    ///     اگر حروف ديگري مدنظر است، آن‌را به ليست اضافه كنيد.
    ///     حروفي كه در اينجا به صورت پيش‌فرض استفاده مي‌شوند، مخصوص عناوين فارسي هستند.
    ///     در اين متد، اصلاح ي و ك، حذف اعراب و كوچك شدن حروف به صورت خودكار انجام مي‌شود.
    /// </summary>
    /// <param name="tag">عنوان تگ</param>
    /// <param name="replacements">
    ///     اگر مقدار دهي نشود از مقدار پيش‌فرض همين كلاس استفاده خواهد شد يعني
    ///     SeoUtils.PersianTagReplacements
    /// </param>
    /// <param name="convertToLower">آيا تبديل به حروف كوچك شود؟</param>
    /// <param name="replacementChar">در اينجا ليستي از حروف خاص، با _ جايگزين خواهند شد</param>
    /// <param name="charsWhiteList">اين ليست اختياري از ليست جايگزين‌ها حذف مي‌شود</param>
    /// <returns></returns>
    public static string? GetCleanedTag(
#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
        [NotNullIfNotNull(nameof(tag))]
#endif
        this string? tag,
        ISet<char>? replacements = null,
        bool convertToLower = false,
        char replacementChar = '_',
        params IEnumerable<char>? charsWhiteList)
    {
        replacements ??= PersianTagReplacements;

        ApplyWhiteList(replacements, charsWhiteList);

        return tag.GetPostSlug(replacements, convertToLower, replacementChar);
    }

    private static void ApplyWhiteList(ISet<char> replacements, IEnumerable<char>? charsWhiteList)
    {
        if (charsWhiteList is null)
        {
            return;
        }

        foreach (var character in charsWhiteList)
        {
            replacements.Remove(character);
        }
    }
}
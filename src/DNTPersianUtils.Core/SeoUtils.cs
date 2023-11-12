using System;
using System.Collections.Generic;
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
                                                                    '@',
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
    /// <returns></returns>
    public static string GetPostSlug(this string postTitle, ISet<char>? replacements = null)
    {
        if (string.IsNullOrWhiteSpace(postTitle))
        {
            return string.Empty;
        }

        replacements ??= PersianSlugReplacements;

        postTitle = postTitle.Trim()
                             .ToLowerInvariant()
                             .RemoveDiacritics()
                             .RemoveHexadecimalSymbols()
                             .ApplyCorrectYeKe();

        var dataChars = postTitle.ToCharArray();
        for (var i = 0; i < dataChars.Length; i++)
        {
            foreach (var item in replacements)
            {
                if (dataChars[i] == item)
                {
                    dataChars[i] = '-';
                }
            }
        }

        var result = new string(dataChars);

        // remove duplicate dashes
        result = string.Join("-", result.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries));
        return result.Trim('-');
    }
}
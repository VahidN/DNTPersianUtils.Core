using System;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// متدهای کمکی مبتنی بر عبارات باقاعده
    /// </summary>
    public static class RegexUtils
    {
        /// <summary>
        /// زمان انقضای پردازش عبارت باقاعده
        /// </summary>
        public static readonly TimeSpan MatchTimeout = TimeSpan.FromSeconds(3);

        private static readonly Regex _matchAllTags =
            new Regex(@"<(.|\n)*?>", options: RegexOptions.Compiled | RegexOptions.IgnoreCase
#if !NET40
                , matchTimeout: MatchTimeout
#endif
                );

        private static readonly Regex _matchArabicHebrew =
            new Regex(@"[\u0600-\u06FF,\u0590-\u05FF]", options: RegexOptions.Compiled | RegexOptions.IgnoreCase
#if !NET40
                , matchTimeout: MatchTimeout
#endif
                );

        /// <summary>
        /// آیا عبارت مدنظر حاوی حروف فارسی است؟
        /// </summary>
        public static bool ContainsFarsi(this string txt)
        {
            return !string.IsNullOrEmpty(txt) &&
                _matchArabicHebrew.IsMatch(txt.StripHtmlTags().Replace(",", ""));
        }

        /// <summary>
        /// حذف تگ‌های یک عبارت
        /// </summary>
        public static string StripHtmlTags(this string text)
        {
            return string.IsNullOrEmpty(text) ?
                        string.Empty :
                        _matchAllTags.Replace(text, " ").Replace("&nbsp;", " ");
        }
    }
}
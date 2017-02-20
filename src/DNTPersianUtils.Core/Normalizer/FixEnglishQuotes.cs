using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core.Normalizer
{
    /// <summary>
    /// Replaces English quotes with their Persian equivalent
    /// </summary>
    public static class FixEnglishQuotes
    {
        private static readonly Regex _matchConvertEnglishQuotes =
            new Regex(@"([""'`]+)(.+?)(\1)", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Replaces English quotes with their Persian equivalent.
        /// It converts 'تست' to «تست»
        /// </summary>
        /// <param name="text">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string NormalizeEnglishQuotes(this string text)
        {
            return _matchConvertEnglishQuotes.Replace(text, @"«$2»");
        }
    }
}
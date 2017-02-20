namespace DNTPersianUtils.Core
{
    /// <summary>
    /// YeKe
    /// </summary>
    public static class YeKe
    {
        /// <summary>
        /// Arabic Ke Char \u0643 = ARABIC LETTER KAF
        /// </summary>
        public const char ArabicKeChar = (char)1603;

        /// <summary>
        /// Arabic Ye Char \u0649 = ARABIC LETTER ALEF MAKSURA
        /// </summary>
        public const char ArabicYeChar1 = (char)1609;

        /// <summary>
        /// Arabic Ye Char \u064A = ARABIC LETTER YEH
        /// </summary>
        public const char ArabicYeChar2 = (char)1610;

        /// <summary>
        /// Persian Ke Char \u06A9 = ARABIC LETTER KEHEH
        /// </summary>
        public const char PersianKeChar = (char)1705;

        /// <summary>
        /// Persian Ye Char \u06CC = 'ARABIC LETTER FARSI YEH
        /// </summary>
        public const char PersianYeChar = (char)1740;

        /// <summary>
        /// Fixes common writing mistakes caused by using a bad keyboard layout,
        /// such as replacing Arabic Ye with Persian one and so on ...
        /// </summary>
        /// <param name="data">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string ApplyCorrectYeKe(this string data)
        {
            return string.IsNullOrWhiteSpace(data) ?
                        string.Empty :
                        data.Replace(ArabicYeChar1, PersianYeChar)
                            .Replace(ArabicYeChar2, PersianYeChar)
                            .Replace(ArabicKeChar, PersianKeChar)
                            .Trim();
        }
    }
}
namespace DNTPersianUtils.Core
{
    /// <summary>
    ///
    /// </summary>
    public static class YeKe
    {
        /// <summary>
        ///
        /// </summary>
        public const char ArabicYeChar = (char)1610;

        /// <summary>
        ///
        /// </summary>
        public const char PersianYeChar = (char)1740;

        /// <summary>
        ///
        /// </summary>
        public const char ArabicKeChar = (char)1603;

        /// <summary>
        ///
        /// </summary>
        public const char PersianKeChar = (char)1705;


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
                        data.Replace(ArabicYeChar, PersianYeChar)
                            .Replace(ArabicKeChar, PersianKeChar)
                            .Trim();
        }
    }
}
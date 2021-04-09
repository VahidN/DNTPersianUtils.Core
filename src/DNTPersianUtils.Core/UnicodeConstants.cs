namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Unicode Constants
    /// </summary>
    public static class UnicodeConstants
    {
        /// <summary>
        /// RLE Char = 0x202B
        /// </summary>
        public const char RleChar = (char)0x202B;

        /// <summary>
        ///  Applies RLE to the text if it contains Persian words.
        /// </summary>
        public static string ApplyRle(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            return text.ContainsFarsi(allowWhitespace: true) ? $"{RleChar}{text}" : text;
        }
    }
}
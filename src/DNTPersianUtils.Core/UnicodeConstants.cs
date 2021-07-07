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
        /// Pop Directional Formatting Char, 0x202C.
        /// </summary>
        public const char PopDirectionalFormatting = (char)0x202C;

        /// <summary>
        ///  Applies RLE to the text if it contains Persian words.
        /// </summary>
        public static string ApplyRle(this string? text)
        {
            if (text is null)
            {
                return string.Empty;
            }

            return text.ContainsFarsi(allowWhitespace: true) ? $"{RleChar}{text}" : text;
        }

        /// <summary>
        /// If you see dd/mm/yyy instead of yyyy/mm/dd in your RTL reports, use this method to fix it.
        /// </summary>
        /// <param name="data">string data</param>
        /// <returns>A fixed string</returns>
        public static string FixWeakCharacters(this string? data)
        {
            if (data is null)
            {
                return string.Empty;
            }

            var weakCharacters = new[] { @"\", "/", "+", "-", "=", ";", "$", ":", "*" };
            foreach (var weakCharacter in weakCharacters)
            {
                data = data.Replace(weakCharacter, $"{RleChar}{weakCharacter}{PopDirectionalFormatting}", System.StringComparison.Ordinal);
            }
            return data;
        }
    }
}
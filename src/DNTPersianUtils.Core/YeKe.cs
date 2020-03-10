using System;
using System.Globalization;

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
        /// ؠ
        /// </summary>
        public const char ArabicYeWithOneDotBelow = (char)1568;

        /// <summary>
        /// ئ
        /// </summary>
        public const char ArabicYeWithHighHamze = (char)1574;

        /// <summary>
        /// ؽ
        /// </summary>
        public const char ArabicYeWithInvertedV = (char)1597;

        /// <summary>
        /// ؾ
        /// </summary>
        public const char ArabicYeWithTwoDotsAbove = (char)1598;

        /// <summary>
        /// ؿ
        /// </summary>
        public const char ArabicYeWithThreeDotsAbove = (char)1599;

        /// <summary>
        /// ٸ
        /// </summary>
        public const char ArabicYeWithHighHamzeYeh = (char)1656;

        /// <summary>
        /// ې
        /// </summary>
        public const char ArabicYeWithFinalForm = (char)1744;

        /// <summary>
        /// ۑ
        /// </summary>
        public const char ArabicYeWithThreeDotsBelow = (char)1745;

        /// <summary>
        /// ۍ
        /// </summary>
        public const char ArabicYeWithTail = (char)1741;

        /// <summary>
        /// ێ
        /// </summary>
        public const char ArabicYeSmallV = (char)1742;

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
                            .Replace(ArabicYeWithOneDotBelow, PersianYeChar)
                            .Replace(ArabicYeWithHighHamze, PersianYeChar)
                            .Replace(ArabicYeWithInvertedV, PersianYeChar)
                            .Replace(ArabicYeWithTwoDotsAbove, PersianYeChar)
                            .Replace(ArabicYeWithThreeDotsAbove, PersianYeChar)
                            .Replace(ArabicYeWithHighHamzeYeh, PersianYeChar)
                            .Replace(ArabicYeWithFinalForm, PersianYeChar)
                            .Replace(ArabicYeWithThreeDotsBelow, PersianYeChar)
                            .Replace(ArabicYeWithTail, PersianYeChar)
                            .Replace(ArabicYeSmallV, PersianYeChar)
                            .Replace(ArabicKeChar, PersianKeChar)
                            .Trim();
        }

        /// <summary>
        /// Fixes common writing mistakes caused by using a bad keyboard layout,
        /// such as replacing Arabic Ye with Persian one and so on ...
        /// </summary>
        /// <param name="data">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string ApplyCorrectYeKe(this object data)
        {
            return data == null ?
                        string.Empty :
                        Convert.ToString(data, CultureInfo.InvariantCulture).ApplyCorrectYeKe();
        }
    }
}
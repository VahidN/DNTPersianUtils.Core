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
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var dataChars = data.ToCharArray();
            for (var i = 0; i < dataChars.Length; i++)
            {
                switch (dataChars[i])
                {
                    case ArabicYeChar1:
                    case ArabicYeChar2:
                    case ArabicYeWithOneDotBelow:                    
                    case ArabicYeWithInvertedV:
                    case ArabicYeWithTwoDotsAbove:
                    case ArabicYeWithThreeDotsAbove:
                    case ArabicYeWithHighHamzeYeh:
                    case ArabicYeWithFinalForm:
                    case ArabicYeWithThreeDotsBelow:
                    case ArabicYeWithTail:
                    case ArabicYeSmallV:
                        dataChars[i] = PersianYeChar;
                        break;

                    case ArabicKeChar:
                        dataChars[i] = PersianKeChar;
                        break;

                    default:
                        dataChars[i] = dataChars[i];
                        break;
                }
            }

            return new string(dataChars);
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
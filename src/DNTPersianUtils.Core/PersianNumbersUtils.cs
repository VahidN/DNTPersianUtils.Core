using System.Globalization;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Converts English digits of a given number to their equivalent Persian digits.
    /// </summary>
    public static class PersianNumbersUtils
    {
        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this int number, string format = "")
        {
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                    number.ToString(format) : number.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this long number, string format = "")
        {
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                    number.ToString(format) : number.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this int? number, string format = "")
        {
            if (!number.HasValue) number = 0;
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                    number.Value.ToString(format) : number.Value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this long? number, string format = "")
        {
            if (!number.HasValue) number = 0;
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                number.Value.ToString(format) : number.Value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given string to their equivalent Persian digits.
        /// </summary>
        /// <param name="data">English number</param>
        /// <returns></returns>
        public static string ToPersianNumbers(this string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;
            return
               data
                .ToEnglishNumbers()
                .Replace("0", "\u06F0")
                .Replace("1", "\u06F1")
                .Replace("2", "\u06F2")
                .Replace("3", "\u06F3")
                .Replace("4", "\u06F4")
                .Replace("5", "\u06F5")
                .Replace("6", "\u06F6")
                .Replace("7", "\u06F7")
                .Replace("8", "\u06F8")
                .Replace("9", "\u06F9")
                .Replace(".", ",");
        }

        /// <summary>
        /// Converts Persian and Arabic digits of a given string to their equivalent English digits.
        /// </summary>
        /// <param name="data">Persian number</param>
        /// <returns></returns>
        public static string ToEnglishNumbers(this string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;
            return
               data.Replace("\u0660", "0") //٠
                   .Replace("\u06F0", "0") //۰
                   .Replace("\u0661", "1") //١
                   .Replace("\u06F1", "1") //۱
                   .Replace("\u0662", "2") //٢
                   .Replace("\u06F2", "2") //۲
                   .Replace("\u0663", "3") //٣
                   .Replace("\u06F3", "3") //۳
                   .Replace("\u0664", "4") //٤
                   .Replace("\u06F4", "4") //۴
                   .Replace("\u0665", "5") //٥
                   .Replace("\u06F5", "5") //۵
                   .Replace("\u0666", "6") //٦
                   .Replace("\u06F6", "6") //۶
                   .Replace("\u0667", "7") //٧
                   .Replace("\u06F7", "7") //۷
                   .Replace("\u0668", "8") //٨
                   .Replace("\u06F8", "8") //۸
                   .Replace("\u0669", "9") //٩
                   .Replace("\u06F9", "9") //۹
                   ;
        }
    }
}
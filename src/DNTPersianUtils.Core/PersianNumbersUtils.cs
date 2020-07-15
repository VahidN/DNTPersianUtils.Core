using System.Globalization;
using System.Text;

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

            var strBuilder = new StringBuilder(data);
            for (var i = 0; i < strBuilder.Length; i++)
            {
                switch (strBuilder[i])
                {
                    case '0':
                    case '\u0660':
                        strBuilder[i] = '\u06F0';
                        break;

                    case '1':
                    case '\u0661':
                        strBuilder[i] = '\u06F1';
                        break;

                    case '2':
                    case '\u0662':
                        strBuilder[i] = '\u06F2';
                        break;

                    case '3':
                    case '\u0663':
                        strBuilder[i] = '\u06F3';
                        break;

                    case '4':
                    case '\u0664':
                        strBuilder[i] = '\u06F4';
                        break;

                    case '5':
                    case '\u0665':
                        strBuilder[i] = '\u06F5';
                        break;

                    case '6':
                    case '\u0666':
                        strBuilder[i] = '\u06F6';
                        break;

                    case '7':
                    case '\u0667':
                        strBuilder[i] = '\u06F7';
                        break;

                    case '8':
                    case '\u0668':
                        strBuilder[i] = '\u06F8';
                        break;

                    case '9':
                    case '\u0669':
                        strBuilder[i] = '\u06F9';
                        break;

                    default:
                        strBuilder[i] = strBuilder[i];
                        break;
                }
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// Converts Persian and Arabic digits of a given string to their equivalent English digits.
        /// </summary>
        /// <param name="data">Persian number</param>
        /// <returns></returns>
        public static string ToEnglishNumbers(this string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var strBuilder = new StringBuilder(data);
            for (var i = 0; i < strBuilder.Length; i++)
            {
                switch (strBuilder[i])
                {
                    case '\u06F0':
                    case '\u0660':
                        strBuilder[i] = '0';
                        break;

                    case '\u06F1':
                    case '\u0661':
                        strBuilder[i] = '1';
                        break;

                    case '\u06F2':
                    case '\u0662':
                        strBuilder[i] = '2';
                        break;

                    case '\u06F3':
                    case '\u0663':
                        strBuilder[i] = '3';
                        break;

                    case '\u06F4':
                    case '\u0664':
                        strBuilder[i] = '4';
                        break;

                    case '\u06F5':
                    case '\u0665':
                        strBuilder[i] = '5';
                        break;

                    case '\u06F6':
                    case '\u0666':
                        strBuilder[i] = '6';
                        break;

                    case '\u06F7':
                    case '\u0667':
                        strBuilder[i] = '7';
                        break;

                    case '\u06F8':
                    case '\u0668':
                        strBuilder[i] = '8';
                        break;

                    case '\u06F9':
                    case '\u0669':
                        strBuilder[i] = '9';
                        break;

                    default:
                        strBuilder[i] = strBuilder[i];
                        break;
                }
            }

            return strBuilder.ToString();
        }
    }
}
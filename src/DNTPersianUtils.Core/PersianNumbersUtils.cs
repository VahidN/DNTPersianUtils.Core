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
                    number.ToString(format, CultureInfo.InvariantCulture) : number.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this long number, string format = "")
        {
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                    number.ToString(format, CultureInfo.InvariantCulture) : number.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this int? number, string format = "")
        {
            if (!number.HasValue) number = 0;
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                    number.Value.ToString(format, CultureInfo.InvariantCulture) : number.Value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits.
        /// </summary>
        public static string ToPersianNumbers(this long? number, string format = "")
        {
            if (!number.HasValue) number = 0;
            return ToPersianNumbers(!string.IsNullOrEmpty(format) ?
                number.Value.ToString(format, CultureInfo.InvariantCulture) : number.Value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Converts English digits of a given string to their equivalent Persian digits.
        /// </summary>
        /// <param name="data">English number</param>
        /// <returns></returns>
        public static string ToPersianNumbers(this string? data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var dataChars = data.ToCharArray();
            for (var i = 0; i < dataChars.Length; i++)
            {
                switch (dataChars[i])
                {
                    case '0':
                    case '\u0660':
                        dataChars[i] = '\u06F0';
                        break;

                    case '1':
                    case '\u0661':
                        dataChars[i] = '\u06F1';
                        break;

                    case '2':
                    case '\u0662':
                        dataChars[i] = '\u06F2';
                        break;

                    case '3':
                    case '\u0663':
                        dataChars[i] = '\u06F3';
                        break;

                    case '4':
                    case '\u0664':
                        dataChars[i] = '\u06F4';
                        break;

                    case '5':
                    case '\u0665':
                        dataChars[i] = '\u06F5';
                        break;

                    case '6':
                    case '\u0666':
                        dataChars[i] = '\u06F6';
                        break;

                    case '7':
                    case '\u0667':
                        dataChars[i] = '\u06F7';
                        break;

                    case '8':
                    case '\u0668':
                        dataChars[i] = '\u06F8';
                        break;

                    case '9':
                    case '\u0669':
                        dataChars[i] = '\u06F9';
                        break;
                }
            }

            return new string(dataChars);
        }

        /// <summary>
        /// Converts Persian and Arabic digits of a given string to their equivalent English digits.
        /// </summary>
        /// <param name="data">Persian number</param>
        /// <returns></returns>
        public static string ToEnglishNumbers(this string? data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var dataChars = data.ToCharArray();
            for (var i = 0; i < dataChars.Length; i++)
            {
                switch (dataChars[i])
                {
                    case '\u06F0':
                    case '\u0660':
                        dataChars[i] = '0';
                        break;

                    case '\u06F1':
                    case '\u0661':
                        dataChars[i] = '1';
                        break;

                    case '\u06F2':
                    case '\u0662':
                        dataChars[i] = '2';
                        break;

                    case '\u06F3':
                    case '\u0663':
                        dataChars[i] = '3';
                        break;

                    case '\u06F4':
                    case '\u0664':
                        dataChars[i] = '4';
                        break;

                    case '\u06F5':
                    case '\u0665':
                        dataChars[i] = '5';
                        break;

                    case '\u06F6':
                    case '\u0666':
                        dataChars[i] = '6';
                        break;

                    case '\u06F7':
                    case '\u0667':
                        dataChars[i] = '7';
                        break;

                    case '\u06F8':
                    case '\u0668':
                        dataChars[i] = '8';
                        break;

                    case '\u06F9':
                    case '\u0669':
                        dataChars[i] = '9';
                        break;
                }
            }

            return new string(dataChars);
        }
    }
}
namespace DNTPersianUtils.Core;

/// <summary>
/// </summary>
public static class CharExtensions
{
    extension(char ch)
    {
        /// <summary>
        ///     آيا يك كاراكتر فاصله متداول است؟
        /// </summary>
        /// <returns></returns>
        public bool IsSpace()
            => ch is ' ' or '\t' or '\r' or '\n' or '\u00A0' or '\u2009' or '\u202F' or '\u200B' or '\u200C' or
                '\u200D' or '\uFEFF';

        /// <summary>
        ///     آيا يك كاراكتر مميز متداول است؟
        /// </summary>
        /// <returns></returns>
        public bool IsDecimalSeparator() => ch is '.' or ',' or '٫' or '/';

        /// <summary>
        ///     آيا يك كاراكتر علامت متداول است؟
        /// </summary>
        /// <returns></returns>
        public bool IsSign() => ch is '+' or '＋' or '-' or '−' or '－' or '–' or '—';

        /// <summary>
        ///     آيا يك كاراكتر مثبت متداول است؟
        /// </summary>
        /// <returns></returns>
        public bool IsPlusSign() => ch is '+' or '＋';

        /// <summary>
        ///     آيا يك كاراكتر جداكننده هزارگان متداول است؟
        /// </summary>
        /// <returns></returns>
        public bool IsThousandsSeparator() => ch is '،' or '\'' or '_';

        /// <summary>
        ///     تبديل يك كاراكتر عددي ايراني به نمونه انگليسي
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public bool TryConvertPersianDigit(out char digit)
        {
            if (ch is >= '\u06F0' and <= '\u06F9')
            {
                digit = (char)('0' + (ch - '\u06F0'));

                return true;
            }

            digit = '\0';

            return false;
        }

        /// <summary>
        ///     تبديل يك كاراكتر عددي عربي به نمونه انگليسي
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public bool TryConvertArabicDigit(out char digit)
        {
            if (ch is >= '\u0660' and <= '\u0669')
            {
                digit = (char)('0' + (ch - '\u0660'));

                return true;
            }

            digit = '\0';

            return false;
        }
    }
}
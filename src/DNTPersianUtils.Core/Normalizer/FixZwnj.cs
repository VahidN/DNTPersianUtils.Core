using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core.Normalizer
{
    /// <summary>
    /// Puts zwnj char/half space between word and prefix/suffix
    /// </summary>
    public static class FixZwnj
    {
        private static readonly Regex _matchApplyHalfSpaceRule1 =
            new Regex(@"\s+(ن?می)\s+", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchApplyHalfSpaceRule2 =
            new Regex(@"\s+(تر(ی(ن)?)?|ها(ی)?)\s+", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchCleanupZwnj =
            new Regex(@"\s+‌|‌\s+", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex _matchYeHeHalfSpace =
            new Regex(@"(\S)(ه[\s‌]+[یی])(\s)", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);


        /// <summary>
        /// Adds zwnj char between word and prefix/suffix
        /// </summary>
        /// <param name="text">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string ApplyHalfSpaceRule(this string text)
        {
            text = text.NormalizeZwnj();

            //put zwnj between word and prefix (mi* nemi*)
            var phase1 = _matchApplyHalfSpaceRule1.Replace(text, @" $1‌");

            //put zwnj between word and suffix (*tar *tarin *ha *haye)
            var phase2 = _matchApplyHalfSpaceRule2.Replace(phase1,  @"‌$1 ");

            var phase3 = phase2.NormalizeYeHeHalfSpace();
            return phase3;
        }

        /// <summary>
        /// Removes unnecessary zwnj char that are succeeded/preceded by a space
        /// </summary>
        /// <param name="text">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string NormalizeZwnj(this string text)
        {
            return _matchCleanupZwnj.Replace(text,  " ");
        }

        /// <summary>
        /// Converts ه ی to ه‌ی
        /// </summary>
        /// <param name="text">Text to process</param>
        /// <returns>Processed Text</returns>
        public static string NormalizeYeHeHalfSpace(this string text)
        {
            return _matchYeHeHalfSpace.Replace(text, "$1ه‌ی‌$3"); // fix zwnj
        }
    }
}
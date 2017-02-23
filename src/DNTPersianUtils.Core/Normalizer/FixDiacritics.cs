using System;
using System.Globalization;
using System.Text;

namespace DNTPersianUtils.Core.Normalizer
{
    /// <summary>
    /// حذف اعراب از حروف و کلمات
    /// </summary>
    public static class FixDiacritics
    {
        /// <summary>
        /// حذف اعراب از حروف و کلمات
        /// </summary>
        public static string RemoveDiacritics(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            var normalizedString = text.Normalize(NormalizationForm.FormKC);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
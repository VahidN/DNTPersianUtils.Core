using System;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Persian Text Normalizers
    /// </summary>
    [Flags]
    public enum PersianNormalizers : long
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Fixes common writing mistakes caused by using a bad keyboard layout,
        /// such as replacing Arabic Ye with Persian one and so on ...
        /// </summary>
        ApplyPersianYeKe = 1 << 0,

        /// <summary>
        /// ما می توانیم --> ما می‌توانیم
        /// </summary>
        ApplyHalfSpaceRule = 1 << 1,

        /// <summary>
        /// Removes unnecessary zwnj char that are succeeded/preceded by a space
        /// </summary>
        CleanupZwnj = 1 << 2,

        /// <summary>
        /// آزمون--- to آزمون—
        /// </summary>
        FixDashes = 1 << 3,

        /// <summary>
        /// آزمون.... to آزمون…
        /// </summary>
        ConvertDotsToEllipsis = 1 << 4,

        /// <summary>
        /// 'تست' to «تست»
        /// </summary>
        ConvertEnglishQuotes = 1 << 5,

        /// <summary>
        /// Replaces more than one ! or ? mark with just one
        /// </summary>
        CleanupExtraMarks = 1 << 6,

        /// <summary>
        /// سلامـــت to سلامت
        /// </summary>
        RemoveAllKashida = 1 << 7,

        /// <summary>
        /// Replaces more than one space or line break with just a single one
        /// </summary>
        CleanupSpacingAndLineBreaks = 1 << 8,

        /// <summary>
        /// Fixes outside and inside spacing for () [] {}  “” «»
        /// </summary>
        RemoveOutsideInsideSpacing = 1 << 9,

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits
        /// </summary>
        ApplyPersianNumbers = 1 << 10,

        /// <summary>
        /// حذف اعراب از حروف و کلمات
        /// </summary>
        RemoveDiacritics = 1 << 11
    }
}
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core.Normalizer;

/// <summary>
///     Replaces more than one ! or ? marks with just one or removes all extra kashida and spaces
/// </summary>
public static class AggressiveEditing
{
    private static readonly Regex _matchCleanupExtraMarks1 =
        new(@"(!){2,}", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchCleanupExtraMarks2 =
        new("(؟){2,}", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchCleanupSpacingAndLineBreaks1 =
        new(@"[ ]+", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchCleanupSpacingAndLineBreaks2 =
        new("([\n]+)[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveAllKashida =
        new("ـ+", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing1 =
        new(@"[   ‌]*(\()\s*([^)]+?)\s*?(\))[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing10 =
        new(@"(\{)\s*([^)]+?)\s*?(\})", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing11 =
        new(@"(“)\s*([^)]+?)\s*?(”)", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing12 =
        new(@"(«)\s*([^)]+?)\s*?(»)", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing2 =
        new(@"[   ‌]*(\[)\s*([^)]+?)\s*?(\])[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing3 =
        new(@"[   ‌]*(\{)\s*([^)]+?)\s*?(\})[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing4 =
        new(@"[   ‌]*(“)\s*([^)]+?)\s*?(”)[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing5 =
        new(@"[   ‌]*(«)\s*([^)]+?)\s*?(»)[   ‌]*", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing6 =
        new(@"[ ?  ]*([:;,??.?!]{1})[ ?  ]*", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing7 =
        new(@"([0-9]+):\s+([0-9]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing8 =
        new(@"(\()\s*([^)]+?)\s*?(\))", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchRemoveOutsideInsideSpacing9 =
        new(@"(\[)\s*([^)]+?)\s*?(\])", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchHexadecimalSymbols = new("[\x00-\x08\x0B\x0C\x0E-\x1F]",
                                                                 RegexOptions.Compiled | RegexOptions.IgnoreCase,
                                                                 RegexUtils.MatchTimeout);

    /// <summary>
    ///     Removes all kashida
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeAllKashida(this string text) =>
        _matchRemoveAllKashida.Replace(text, "").NormalizeUnderLines();

    /// <summary>
    ///     Replaces more than one ! or ? mark with just one
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeExtraMarks(this string text)
    {
        var phase1 = _matchCleanupExtraMarks1.Replace(text, "$1");
        var phase2 = _matchCleanupExtraMarks2.Replace(phase1, "$1");
        return phase2;
    }

    /// <summary>
    ///     Fixes outside and inside spacing for () [] {}  “” «»
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeOutsideInsideSpacing(this string text)
    {
        //should fix outside and inside spacing for () [] {}  “” «»
        var phase1 = _matchRemoveOutsideInsideSpacing1.Replace(text, " $1$2$3 ");
        var phase2 = _matchRemoveOutsideInsideSpacing2.Replace(phase1, " $1$2$3 ");
        var phase3 = _matchRemoveOutsideInsideSpacing3.Replace(phase2, " $1$2$3 ");
        var phase4 = _matchRemoveOutsideInsideSpacing4.Replace(phase3, " $1$2$3 ");
        var phase5 = _matchRemoveOutsideInsideSpacing5.Replace(phase4, " $1$2$3 ");

        // : ; , . ! ? and their Persian equivalents should have one space after and no space before
        var phase6 = _matchRemoveOutsideInsideSpacing6.Replace(phase5, "$1 ");

        // do not put space after colon that separates time parts
        var phase7 = _matchRemoveOutsideInsideSpacing7.Replace(phase6, "$1:$2");

        //should fix inside spacing for () [] {}  “” «»
        var phase8 = _matchRemoveOutsideInsideSpacing8.Replace(phase7, "$1$2$3");
        var phase9 = _matchRemoveOutsideInsideSpacing9.Replace(phase8, "$1$2$3");
        var phase10 = _matchRemoveOutsideInsideSpacing10.Replace(phase9, "$1$2$3");
        var phase11 = _matchRemoveOutsideInsideSpacing11.Replace(phase10, "$1$2$3");
        var phase12 = _matchRemoveOutsideInsideSpacing12.Replace(phase11, "$1$2$3");

        return phase12.Trim();
    }

    /// <summary>
    ///     Replaces more than one space or line break with just a single one
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeSpacingAndLineBreaks(this string text)
    {
        var phase1 = _matchCleanupSpacingAndLineBreaks1.Replace(text, " ");
        var phase2 = _matchCleanupSpacingAndLineBreaks2.Replace(phase1, "$1");
        return phase2.Trim();
    }

    /// <summary>
    ///     Clean UnderLines
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeUnderLines(this string? text)
    {
        if (text is null)
        {
            return string.Empty;
        }

        const char chr1600 = (char)1600; //ـ=1600
        const char chr8204 = (char)8204; //‌=8204

        return text.Replace(chr1600.ToString(), "", StringComparison.OrdinalIgnoreCase)
                   .Replace(chr8204.ToString(), "", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    ///     There are a lot of symbols which can't be in xml code.
    /// </summary>
    public static string RemoveHexadecimalSymbols(this string? txt) =>
        string.IsNullOrWhiteSpace(txt) ? string.Empty : _matchHexadecimalSymbols.Replace(txt, string.Empty);

    /// <summary>
    ///     تبدیل یک متن عربی اسکی به یونیکد
    /// </summary>
    public static string ConvertArabic1256ToUtf8(this string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }

        var latin = Encoding.GetEncoding("ISO-8859-1");
        var bytes = latin.GetBytes(text); // get the bytes for your ANSI string
        var arabic = Encoding.GetEncoding("Windows-1256"); // decode it using the correct encoding
        return arabic.GetString(bytes);
    }
}
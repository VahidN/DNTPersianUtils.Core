using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core.Normalizer;

/// <summary>
///     Replaces double dash to ndash and triple dash to mdash
/// </summary>
public static class FixDash
{
    private static readonly Regex _matchFixDashes1 =
        new(@"-{3}", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchFixDashes2 =
        new(@"-{2}", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    /// <summary>
    ///     Replaces double dash to ndash and triple dash to mdash.
    ///     It converts آزمون--- to آزمون—
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeDashes(this string text)
    {
        var phase1 = _matchFixDashes1.Replace(text, "—");
        var phase2 = _matchFixDashes2.Replace(phase1, "–");
        return phase2;
    }
}
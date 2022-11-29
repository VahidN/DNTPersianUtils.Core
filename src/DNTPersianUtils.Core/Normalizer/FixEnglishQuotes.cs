using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core.Normalizer;

/// <summary>
///     Replaces English quotes with their Persian equivalent
/// </summary>
public static class FixEnglishQuotes
{
    private static readonly Regex _matchConvertEnglishQuotes =
        new(@"([""'`]+)(.+?)(\1)", RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    /// <summary>
    ///     Replaces English quotes with their Persian equivalent.
    ///     It converts 'تست' to «تست»
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <returns>Processed Text</returns>
    public static string NormalizeEnglishQuotes(this string text) => _matchConvertEnglishQuotes.Replace(text, "«$2»");
}
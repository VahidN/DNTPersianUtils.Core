namespace DNTPersianUtils.Core.Normalizer;

/// <summary>
///     Replaces thin spaces with a replacement
/// </summary>
public static class FixHalfSpace
{
    /// <summary>
    ///     Replaces thin/half spaces with the replacement provided.
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <param name="replacement">The replacement of the thin space. Default value is an empty string.</param>
    /// <returns></returns>
    public static string ReplaceThinSpaces(this string text, string replacement = "")
        => ReplaceHalfSpaces(text, replacement);

    /// <summary>
    ///     Replaces thin/half spaces with the replacement provided.
    /// </summary>
    /// <param name="text">Text to process</param>
    /// <param name="replacement">The replacement of the thin space. Default value is an empty string.</param>
    /// <returns></returns>
    public static string ReplaceHalfSpaces(this string text, string replacement = "")
    {
        var result = text;

        if (text.ContainsThinSpace())
        {
            result = RegexUtils._hasHalfSpaces.Replace(text, replacement);
        }

        return result;
    }
}
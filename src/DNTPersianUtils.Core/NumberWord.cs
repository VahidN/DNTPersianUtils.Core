using System.Collections.Generic;

namespace DNTPersianUtils.Core;

/// <summary>
///     Equivalent names of a group
/// </summary>
public class NumberWord
{
    /// <summary>
    ///     Digit's group
    /// </summary>
    public DigitGroup Group { set; get; }

    /// <summary>
    ///     Number to word language
    /// </summary>
    public Language Language { set; get; }

    /// <summary>
    ///     Equivalent names
    /// </summary>
    public IEnumerable<string> Names { get; set; } = new List<string>();
}
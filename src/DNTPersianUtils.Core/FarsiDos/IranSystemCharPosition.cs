namespace DNTPersianUtils.Core;

/// <summary>
///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
/// </summary>
public enum IranSystemCharPosition
{
    /// <summary>
    ///     حرف تكي
    /// </summary>
    Isolated = 0,

    /// <summary>
    ///     حرف آغاز كننده واژه
    /// </summary>
    Initial = 1,

    /// <summary>
    ///     حرفي در ميانه واژه
    /// </summary>
    Medial = 2,

    /// <summary>
    ///     حرف واقع در آخر واژه
    /// </summary>
    Final = 3,
}
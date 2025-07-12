namespace DNTPersianUtils.Core;

/// <summary>
///     مشخصات صادر كننده كارت بانكي
/// </summary>
public class BankCardProvider
{
    /// <summary>
    ///     Bank Identification Number - BIN
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    ///     نام خلاصه انگليسي بانك
    /// </summary>
    public string Abbreviation { get; set; } = null!;

    /// <summary>
    ///     نام خلاصه بانك
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    ///     نام رسمي كامل بانك
    /// </summary>
    public string ShortName { get; set; } = null!;

    /// <summary>
    ///     نام انگليسي
    /// </summary>
    public string EnglishName { get; set; } = null!;
}
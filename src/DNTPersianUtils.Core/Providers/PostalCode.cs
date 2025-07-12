namespace DNTPersianUtils.Core;

/// <summary>
///     مشخصات كدپستي محل
/// </summary>
public class PostalCode
{
    /// <summary>First two digits (BIN) of the postal code.</summary>
    public string Id { get; set; } = null!;

    /// <summary>نام استان</summary>
    public string ProvinceName { get; set; } = null!;
}
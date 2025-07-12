namespace DNTPersianUtils.Core;

/// <summary>
///     مشخصات شركت موبايلي
/// </summary>
public class MobileProvider
{
	/// <summary>
	///     پيش‌شماره
	/// </summary>
	public string Prefix { get; set; } = null!;

	/// <summary>
	///     e.g., IR-MCI
	/// </summary>
	public string OperatorName { get; set; } = null!;

	/// <summary>
	///     e.g., همراه اول
	/// </summary>
	public string FullName { get; set; } = null!;
}
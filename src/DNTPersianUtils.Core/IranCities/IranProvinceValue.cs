using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DNTPersianUtils.Core.IranCities;

/// <summary>
///     A custom Dictionary which returns null instead of
///     the KeyNotFoundException when accessing Dictionary value by key
/// </summary>
[SuppressMessage("Microsoft.Usage", "S3925:ISerializable should be implemented correctly",
                    Justification = "This is not an ISerializable type.")]
[SuppressMessage("Microsoft.Usage",
                    "CA2237:Add [Serializable] to IranProvinceValue as this type implements ISerializable",
                    Justification = "This is not an ISerializable type.")]
public class IranProvinceValue<TValue> : Dictionary<IranProvince, TValue?>
{
    /// <summary>
    ///     A custom indexer which returns null instead of
    ///     the KeyNotFoundException when accessing Dictionary value by key
    /// </summary>
    public new TValue? this[IranProvince key]
    {
        get => TryGetValue(key, out var value) ? value : default;
        set => base[key] = value;
    }
}
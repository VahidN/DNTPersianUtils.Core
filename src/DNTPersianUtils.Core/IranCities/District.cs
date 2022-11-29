using System;
using System.Collections.Generic;

namespace DNTPersianUtils.Core.IranCities;

/// <summary>
///     District
/// </summary>
public class District
{
    /// <summary>
    ///     District Name
    /// </summary>
    public string DistrictName { get; set; } = default!;

    /// <summary>
    ///     Cities
    /// </summary>
    public ISet<City> Cities { get; } = new HashSet<City>();

    /// <summary>
    ///     ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{DistrictName}";

    /// <summary>
    ///     Equals
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not District district)
        {
            return false;
        }

        return string.Equals(DistrictName, district.DistrictName, StringComparison.Ordinal);
    }

    /// <summary>
    ///     GetHashCode
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + StringComparer.Ordinal.GetHashCode(DistrictName);
            return hash;
        }
    }
}
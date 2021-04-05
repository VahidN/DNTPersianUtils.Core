using System.Collections.Generic;

namespace DNTPersianUtils.Core.IranCities
{
    /// <summary>
    /// Iran's Province
    /// </summary>
    public class Province
    {
        /// <summary>
        /// Province Name
        /// </summary>
        public string ProvinceName { get; set; } = default!;

        /// <summary>
        /// Counties
        /// </summary>
        public ISet<County> Counties { get; } = new HashSet<County>();

        /// <summary>
        /// ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ProvinceName}";
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Province province)
                return false;

            return string.Equals(this.ProvinceName, province.ProvinceName, System.StringComparison.Ordinal);
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + System.StringComparer.Ordinal.GetHashCode(ProvinceName);
                return hash;
            }
        }
    }
}
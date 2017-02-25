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
        public string ProvinceName { get; set; }

        /// <summary>
        /// Counties
        /// </summary>
        public ISet<County> Counties { get; set; } = new HashSet<County>();

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
        public override bool Equals(object obj)
        {
            var province = obj as Province;
            if (province == null)
                return false;

            return this.ProvinceName == province.ProvinceName;
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
                hash = hash * 23 + ProvinceName.GetHashCode();
                return hash;
            }
        }
    }
}
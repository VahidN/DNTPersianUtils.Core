using System.Collections.Generic;

namespace DNTPersianUtils.Core.IranCities
{
    /// <summary>
    /// District
    /// </summary>
    public class District
    {
        /// <summary>
        /// District Name
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// Cities
        /// </summary>
        public ISet<City> Cities { get; set; } = new HashSet<City>();

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{DistrictName}";
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var district = obj as District;
            if (district == null)
                return false;

            return this.DistrictName == district.DistrictName;
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
                hash = hash * 23 + DistrictName.GetHashCode();
                return hash;
            }
        }
    }
}
namespace DNTPersianUtils.Core.IranCities
{
    /// <summary>
    /// Iran City
    /// </summary>
    public class City
    {
        /// <summary>
        /// Province Name
        /// </summary>
        public string ProvinceName { get; set; } = default!;

        /// <summary>
        /// County Name
        /// </summary>
        public string CountyName { get; set; } = default!;

        /// <summary>
        /// District Name
        /// </summary>
        public string DistrictName { get; set; } = default!;

        /// <summary>
        /// City Name
        /// </summary>
        public string CityName { get; set; } = default!;

        /// <summary>
        /// City Division Code
        /// </summary>
        public int CityDivisionCode { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{CityName}";
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is not City city)
                return false;

            return string.Equals(this.CityName, city.CityName, System.StringComparison.Ordinal) &&
                string.Equals(this.DistrictName, city.DistrictName, System.StringComparison.Ordinal) &&
                string.Equals(this.CountyName, city.CountyName, System.StringComparison.Ordinal) &&
                string.Equals(this.ProvinceName, city.ProvinceName, System.StringComparison.Ordinal) &&
                this.CityDivisionCode == city.CityDivisionCode;
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
                hash = hash * 23 + System.StringComparer.Ordinal.GetHashCode(CityName);
                hash = hash * 23 + System.StringComparer.Ordinal.GetHashCode(DistrictName);
                hash = hash * 23 + System.StringComparer.Ordinal.GetHashCode(CountyName);
                hash = hash * 23 + System.StringComparer.Ordinal.GetHashCode(ProvinceName);
                hash = hash * 23 + CityDivisionCode.GetHashCode();
                return hash;
            }
        }
    }
}
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
        public string ProvinceName { get; set; }

        /// <summary>
        /// County Name
        /// </summary>
        public string CountyName { get; set; }

        /// <summary>
        /// District Name
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// City Name
        /// </summary>
        public string CityName { get; set; }

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
        public override bool Equals(object obj)
        {
            var city = obj as City;
            if (city == null)
                return false;

            return this.CityName == city.CityName &&
                   this.DistrictName == city.DistrictName &&
                   this.CountyName == city.CountyName &&
                   this.ProvinceName == city.ProvinceName &&
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
                hash = hash * 23 + CityName.GetHashCode();
                hash = hash * 23 + DistrictName.GetHashCode();
                hash = hash * 23 + CountyName.GetHashCode();
                hash = hash * 23 + ProvinceName.GetHashCode();
                hash = hash * 23 + CityDivisionCode.GetHashCode();
                return hash;
            }
        }
    }
}
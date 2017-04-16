using System.Linq;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Validate IR National Code
    /// </summary>
    public static class NationalCodeUtils
    {
        /// <summary>
        /// If string is a number returns true
        /// </summary>
        public static bool IsNumber(this string data)
        {
            return !string.IsNullOrWhiteSpace(data) && data.All(char.IsDigit);
        }

        /// <summary>
        /// Validate IR National Code
        /// </summary>
        /// <param name="nationalCode">National Code</param>
        /// <returns></returns>
        public static bool IsValidIranianNationalCode(this string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode))
            {
                return false;
            }

            nationalCode = nationalCode.PadLeft(10, '0');

            const int nationalCodeLength = 10;
            if (nationalCode.Length != nationalCodeLength)
            {
                return false;
            }

            if (!nationalCode.IsNumber())
            {
                return false;
            }

            var j = nationalCodeLength;
            var sum = 0;
            for (var i = 0; i < nationalCode.Length - 1; i++)
            {
                sum += (int)char.GetNumericValue(nationalCode[i]) * j--;
            }

            var remainder = sum % 11;
            var controlNumber = (int)char.GetNumericValue(nationalCode[9]);
            return remainder < 2 && controlNumber == remainder ||
                   remainder >= 2 && controlNumber == 11 - remainder;
        }
    }
}
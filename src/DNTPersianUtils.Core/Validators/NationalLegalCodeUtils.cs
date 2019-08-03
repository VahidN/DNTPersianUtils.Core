using System.Linq;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Validate IR National Legal Code
    /// </summary>
    public static class NationalLegalCodeUtils
    {
        /// <summary>
        /// Validate IR National Legal Code
        /// شناسه ملی حقوقی
        /// </summary>
        /// <param name="nationalLegalCode">National Legal Code</param>
        /// <returns></returns>
        public static bool IsValidIranianNationalLegalCode(this string nationalLegalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalLegalCode))
            {
                return false;
            }

            nationalLegalCode = nationalLegalCode.PadLeft(11, '0');
            const int nationalLegalCodeLength = 11;

            if (nationalLegalCode.Length != nationalLegalCodeLength)
            {
                return false;
            }

            if (!nationalLegalCode.IsNumber())
            {
                return false;
            }

            int beforeControlNumber = (int)char.GetNumericValue(nationalLegalCode[9]) + 2;
            int[] coefficientStatic= { 29, 27, 23, 19, 17, 29, 27, 23, 19, 17 };

            var sum = 0;
            for (var i = 0; i < nationalLegalCode.Length - 1; i++)
            {
                sum += ((int)char.GetNumericValue(nationalLegalCode[i]) + beforeControlNumber) * coefficientStatic[i];
            }

            var remainder = sum % 11;
            var controlNumber = (int)char.GetNumericValue(nationalLegalCode[10]);
            remainder = remainder == 10 ? 0 : remainder;

            return controlNumber == remainder;
        }
    }
}
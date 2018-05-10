using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Validate IBAN
    /// </summary>
    public static class IranShebaUtils
    {
        private static readonly Regex _matchIranSheba = new Regex(@"IR[0-9]{24}", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Validate IBAN (International Bank Account Number, Sheba)
        /// </summary>
        /// <param name="iban">International Bank Account Number, Sheba</param>
        public static bool IsValidIranShebaNumber(this string iban)
        {
            if (string.IsNullOrEmpty(iban))
            {
                return false;
            }


            if (iban.Length < 4 || iban[0] == ' ' || iban[1] == ' ' || iban[2] == ' ' || iban[3] == ' ')
            {
                return false;
            }

            if (iban.Length != 26)
            {
                return false;
            }

            if (!_matchIranSheba.IsMatch(iban))
            {
                return false;
            }

            var checksum = 0;
            var ibanLength = iban.Length;
            for (int charIndex = 0; charIndex < ibanLength; charIndex++)
            {
                if (iban[charIndex] == ' ')
                {
                    continue;
                }

                int value;
                var c = iban[(charIndex + 4) % ibanLength];
                if ((c >= '0') && (c <= '9'))
                {
                    value = c - '0';
                }
                else if ((c >= 'A') && (c <= 'Z'))
                {
                    value = c - 'A';
                    checksum = (checksum * 10 + (value / 10 + 1)) % 97;
                    value %= 10;
                }
                else if ((c >= 'a') && (c <= 'z'))
                {
                    value = c - 'a';
                    checksum = (checksum * 10 + (value / 10 + 1)) % 97;
                    value %= 10;
                }
                else
                {
                    return false;
                }

                checksum = (checksum * 10 + value) % 97;
            }
            return checksum == 1;
        }
    }
}
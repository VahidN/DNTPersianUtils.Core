using System.Linq;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Credit and Debit Card (Shetab) validation
    /// </summary>
    public static class IranShetabUtils
    {
        private static readonly Regex _matchIranShetab = new Regex(@"[0-9]{16}", options: RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// validate Shetab card numbers
        /// </summary>
        /// <param name="creditCardNumber">Shetab card number</param>
        public static bool IsValidIranShetabNumber(this string creditCardNumber)
        {
            if (string.IsNullOrEmpty(creditCardNumber))
            {
                return false;
            }

            creditCardNumber = creditCardNumber.Replace("-", string.Empty);

            if (creditCardNumber.Length != 16)
            {
                return false;
            }

            if (!_matchIranShetab.IsMatch(creditCardNumber))
            {
                return false;
            }

            int sumOfDigits = creditCardNumber.Where(e => e >= '0' && e <= '9')
                .Reverse()
                .Select((e, i) => (e - 48) * (i % 2 == 0 ? 1 : 2))
                .Sum(e => e / 10 + e % 10);

            return sumOfDigits % 10 == 0;
        }
    }
}
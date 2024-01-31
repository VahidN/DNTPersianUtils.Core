using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core;

/// <summary>
///     Credit and Debit Card (Shetab) validation
/// </summary>
public static class IranShetabUtils
{
    private static readonly Regex _matchIranShetab = new(@"[0-9]{16}", RegexOptions.Compiled | RegexOptions.IgnoreCase,
        RegexUtils.MatchTimeout);

    /// <summary>
    ///     validate Shetab card numbers
    /// </summary>
    /// <param name="creditCardNumber">Shetab card number</param>
    public static bool IsValidIranShetabNumber(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(true)]
#endif
        this string? creditCardNumber)
    {
        if (string.IsNullOrEmpty(creditCardNumber))
        {
            return false;
        }

        creditCardNumber = creditCardNumber.ToEnglishNumbers();

        creditCardNumber = creditCardNumber.Replace("-", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Replace(" ", string.Empty, StringComparison.OrdinalIgnoreCase);

        if (creditCardNumber.Length != 16)
        {
            return false;
        }

        if (!_matchIranShetab.IsMatch(creditCardNumber))
        {
            return false;
        }

        var sumOfDigits = creditCardNumber.Where(e => e >= '0' && e <= '9').Reverse()
            .Select((e, i) => (e - 48) * (i % 2 == 0 ? 1 : 2)).Sum(e => e / 10 + e % 10);

        return sumOfDigits % 10 == 0;
    }
}
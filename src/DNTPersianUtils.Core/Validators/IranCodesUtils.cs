using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core;

/// <summary>
///     IranCodes Utils
/// </summary>
public static class IranCodesUtils
{
    private static readonly Regex _matchIranianMobileNumber1 = new(@"^(((98)|(\+98)|(0098)|0)(9){1}[0-9]{9})+$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchIranianMobileNumber2 = new(@"^(9){1}[0-9]{9}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchIranianPhoneNumber = new("^[2-9][0-9]{7}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchIranianPostalCode = new(@"\b(?!(\d)\1{3})[13-9]{4}[1346-9][013-9]{5}\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    /// <summary>
    ///     Validate Iranian mobile number
    /// </summary>
    public static bool IsValidIranianMobileNumber(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(true)]
#endif
        this string? mobileNumber)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber))
        {
            return false;
        }

        mobileNumber = mobileNumber.ToEnglishNumbers();

        return _matchIranianMobileNumber1.IsMatch(mobileNumber) || _matchIranianMobileNumber2.IsMatch(mobileNumber);
    }

    /// <summary>
    ///     Validate Iranian phone number
    /// </summary>
    public static bool IsValidIranianPhoneNumber(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(true)]
#endif
        this string? phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            return false;
        }

        phoneNumber = phoneNumber.ToEnglishNumbers();

        return !string.IsNullOrWhiteSpace(phoneNumber) && _matchIranianPhoneNumber.IsMatch(phoneNumber);
    }

    /// <summary>
    ///     Validate Iranian postal code
    /// </summary>
    public static bool IsValidIranianPostalCode(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(true)]
#endif
        this string? postalCode)
    {
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return false;
        }

        postalCode = postalCode.ToEnglishNumbers();

        return !string.IsNullOrWhiteSpace(postalCode) && _matchIranianPostalCode.IsMatch(postalCode);
    }
}
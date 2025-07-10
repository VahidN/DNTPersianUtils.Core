using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace DNTPersianUtils.Core;

/// <summary>
///     IranCodes Utils
/// </summary>
public static class IranCodesUtils
{
    private static readonly Regex _matchIranianMobileNumber1 =
        new(pattern: @"^(((98)|(\+98)|(0098)|0)(9){1}[0-9]{9})+$", RegexOptions.Compiled | RegexOptions.IgnoreCase,
            RegexUtils.MatchTimeout);

    private static readonly Regex _matchIranianMobileNumber2 = new(pattern: @"^(9){1}[0-9]{9}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    private static readonly Regex _matchIranianPhoneNumber = new(pattern: "^[2-9][0-9]{7}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    /// <summary>
    ///     From
    ///     https://blog.tapin.ir/%D9%85%D8%B9%D8%B1%D9%81%DB%8C-%D8%B3%D8%A7%D8%AE%D8%AA%D8%A7%D8%B1-%DA%A9%D8%AF-%D8%B1%D9%87%DA%AF%DB%8C%D8%B1%DB%8C-%D9%88-%DA%A9%D8%AF%D9%BE%D8%B3%D8%AA%DB%8C/
    /// </summary>
    private static readonly Regex _matchIranianPostalCode = new(pattern: @"^(?!(\d)\1{3})[13-9]{5}\d{5}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase, RegexUtils.MatchTimeout);

    /// <summary>
    ///     Validate Iranian mobile number
    /// </summary>
    public static bool IsValidIranianMobileNumber(
#if !(NET4_6 || NETSTANDARD2_0 || NETSTANDARD1_3)
        [NotNullWhen(returnValue: true)]
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
        [NotNullWhen(returnValue: true)]
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
        [NotNullWhen(returnValue: true)]
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
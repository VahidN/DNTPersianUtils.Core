using System;
using System.Collections.Generic;
using System.Linq;

namespace DNTPersianUtils.Core;

/// <summary>
///     شركت‌هاي موبايلي ايراني
/// </summary>
public static class IranianMobileProviders
{
    /// <summary>
    ///     شركت‌هاي موبايلي ايراني
    /// </summary>
    public static IList<MobileProvider> Items => new List<MobileProvider>
    {
        new()
        {
            Prefix = "0910",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0911",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0912",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0913",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0914",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0915",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0916",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0917",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0918",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },
        new()
        {
            Prefix = "0919",
            FullName = "همراه اول",
            OperatorName = "IR-MCI"
        },

        new()
        {
            Prefix = "0930",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0933",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0935",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0936",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0937",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0938",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },
        new()
        {
            Prefix = "0939",
            FullName = "ایرانسل",
            OperatorName = "IR-MTN"
        },

        new()
        {
            Prefix = "0920",
            FullName = "رایتل",
            OperatorName = "Rightel"
        },
        new()
        {
            Prefix = "0921",
            FullName = "رایتل",
            OperatorName = "Rightel"
        },
        new()
        {
            Prefix = "0922",
            FullName = "رایتل",
            OperatorName = "Rightel"
        },

        new()
        {
            Prefix = "0998",
            FullName = "شاتل موبایل",
            OperatorName = "ShatelMobile"
        },

        new()
        {
            Prefix = "0999",
            FullName = "آپتل",
            OperatorName = "Aptel"
        },

        new()
        {
            Prefix = "0990",
            FullName = "سامانتل",
            OperatorName = "SamanTel"
        },
        new()
        {
            Prefix = "0991",
            FullName = "سامانتل",
            OperatorName = "SamanTel"
        },

        new()
        {
            Prefix = "0994",
            FullName = "آسیاتک",
            OperatorName = "Asiatech"
        }
    };

    /// <summary>
    ///     دريافت اطلاعات شركت موبايلي بر اساس شماره موبايل شخص
    /// </summary>
    public static MobileProvider? GetIranianMobileProvider(this string? mobileNumber)
    {
        mobileNumber = mobileNumber?.Trim();

        if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length < 4)
        {
            return null;
        }

        var prefix = mobileNumber.Substring(startIndex: 0, length: 4);

        return Items.FirstOrDefault(p => string.Equals(p.Prefix, prefix, StringComparison.Ordinal));
    }
}
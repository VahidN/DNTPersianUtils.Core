using System;
using System.Globalization;
using System.Text;

namespace DNTPersianUtils.Core;

/// <summary>
///     تبديلگر متون يونيكد به كدپيج ايران سيستم
/// </summary>
public static class UnicodeToIranSystem
{
#if !NET4_6
    static UnicodeToIranSystem()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }
#endif

    /// <summary>
    ///     تبديلگر يك متن فارسي يونيكد، به فارسي داس ايران سيستم
    /// </summary>
    /// <param name="unicodeString">يك متن متداول فارسي يونيكد</param>
    /// <param name="convertNumbersToIranSystem">آيا اعداد هم به ايران سيستم تبديل شوند؟</param>
    /// <returns>
    ///     خروجي اين متد، فارسي داس ايران سيستم است و نيازي به تبديل خاصي ندارد.
    ///     همچنين خروجي اين متد را تريم نكنيد؛ چون سبب تخريب و حذف كاراكترهاي داس مي‌شود.
    ///     براي مثال واژه‌ي «ماهرخ» پس از تبديل، ختم به «آ صفر» مي‌شود كه اگر آن‌را تريم كنيد، اين «آ صفر» حذف خواهد شد!
    /// </returns>
    public static string FromUnicodeToIranSystem(this string? unicodeString, bool convertNumbersToIranSystem = true) =>
        ConvertUnicodeToIranSystem(unicodeString, convertNumbersToIranSystem).Text;

    /// <summary>
    ///     تبديلگر يك متن فارسي يونيكد، به فارسي داس ايران سيستم
    /// </summary>
    /// <param name="unicodeString">يك متن متداول فارسي يونيكد</param>
    /// <param name="convertNumbersToIranSystem">آيا اعداد هم به ايران سيستم تبديل شوند؟</param>
    /// <returns>
    ///     خروجي اين متد، فارسي داس ايران سيستم است و نيازي به تبديل خاصي ندارد.
    ///     همچنين خروجي اين متد را تريم نكنيد؛ چون سبب تخريب و حذف كاراكترهاي داس مي‌شود.
    ///     براي مثال واژه‌ي «ماهرخ» پس از تبديل، ختم به «آ صفر» مي‌شود كه اگر آن‌را تريم كنيد، اين «آ صفر» حذف خواهد شد!
    /// </returns>
    public static byte[] FromUnicodeToIranSystemBytes(this string? unicodeString,
                                                      bool convertNumbersToIranSystem = true)
        => ConvertUnicodeToIranSystem(unicodeString, convertNumbersToIranSystem).Bytes;

    private static IranSystemData ConvertUnicodeToIranSystem(
        string? unicodeString,
        bool convertNumbersToIranSystem)
    {
        if (string.IsNullOrWhiteSpace(unicodeString))
        {
            return new IranSystemData();
        }

        var limit = unicodeString.Length;
        var returnValue = new StringBuilder(limit);
        var englishString = new StringBuilder();

        for (var index = 0; index < limit; index++)
        {
            var current = unicodeString[index];
            var isEnglish = current.IsLatinChar(false);
            var isEnglishNumber = current.IsEnglishNumber();
            if (isEnglish || isEnglishNumber)
            {
                var latinChar = isEnglishNumber && !convertNumbersToIranSystem ? current : current.GetLatinChar();
                englishString.Append(latinChar);
            }
            else
            {
                var previous = index - 1 < 0 ? (char?)null : unicodeString[index - 1];
                var next = index + 1 >= limit ? (char?)null : unicodeString[index + 1];
                var currentChar = MapUnicodeCharToIranSystem(previous, current, next);
                if (currentChar.IsEnglishNumber() || currentChar.IsIranSystemNumber())
                {
                    englishString.Append(currentChar);
                }
                else
                {
                    returnValue.Insert(0, englishString.ToString().ReverseStartAndEndSpaces()).Insert(0, currentChar);
                    englishString.Clear();
                }
            }
        }

        returnValue.Insert(0, englishString.ToString().ReverseStartAndEndSpaces());
        returnValue = returnValue.FixIranSystemLa();
        return returnValue.ToString().Trim(' ').ConvertCp1252StringToUnicode();
    }


    private static char? MapUnicodeCharToIranSystem(this char? previous, char current, char? next)
    {
        var beforeIsChar = false;
        var afterIsChar = false;

        if (current.IsUnicodeArabicDiacritics())
        {
            return null;
        }

        if (current.IsHalfSpace())
        {
            return null;
        }

        if (current.IsUnicodeEnglish())
        {
            return current;
        }

        if (current.IsUnicodePersianNumber())
        {
            return (char)(current - (char)0x670);
        }

        if (current.IsArabicUnicodeLa(next))
        {
            return FarsiDosExtensions.IranSystemArabicLa;
        }

        if (current == FarsiDosExtensions.UnicodeAlef && previous == FarsiDosExtensions.UnicodeLam)
        {
            return null;
        }

        if (previous.IsUnicodeFarsiOrArabic())
        {
            beforeIsChar = true;
        }

        if (next.IsUnicodeFarsiOrArabic())
        {
            afterIsChar = true;
        }

        var pos = beforeIsChar switch
                  {
                      true when afterIsChar => IranSystemCharPosition.Medial,
                      true when !afterIsChar => IranSystemCharPosition.Final,
                      false when afterIsChar => IranSystemCharPosition.Initial,
                      _ => IranSystemCharPosition.Isolated,
                  };

        if (previous.IsFinalUnicodeChar())
        {
            pos = pos switch
                  {
                      IranSystemCharPosition.Medial => IranSystemCharPosition.Initial,
                      IranSystemCharPosition.Final => IranSystemCharPosition.Isolated,
                      _ => pos,
                  };
        }

        if (current == FarsiDosExtensions.UnicodeTehMarbuta)
        {
            pos = IranSystemCharPosition.Final;
        }

        return IranSystemTables.UnicodeToIranSystemTable.TryGetValue(current, out var iranSystemTable)
                   ? iranSystemTable[(int)pos]
                   : current;
    }

    private static string FixIranSystemLa1(this string result)
    {
        const char ﺎ = (char)145;
        const char ﻟ = (char)243;
        const char ﻻ = FarsiDosExtensions.IranSystemArabicLa;
        return result.Replace((ﺎ + ﻟ).ToString(CultureInfo.InvariantCulture),
                              ﻻ.ToString(),
                              StringComparison.Ordinal);
    }

    private static StringBuilder FixIranSystemLa(this StringBuilder result)
    {
        const char ﺎ = (char)145;
        const char ﻟ = (char)243;
        const char ﻻ = FarsiDosExtensions.IranSystemArabicLa;
        return result.Replace((ﺎ + ﻟ).ToString(CultureInfo.InvariantCulture), ﻻ.ToString());
    }
}
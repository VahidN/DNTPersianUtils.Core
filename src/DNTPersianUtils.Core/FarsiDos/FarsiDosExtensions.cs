using System;
using System.Linq;
using System.Text;

namespace DNTPersianUtils.Core;

/// <summary>
///     متدها و ثوابت مفيد جهت كار با فارسي سيستم عامل داس
/// </summary>
public static class FarsiDosExtensions
{
    /// <summary>
    ///     حروفي كه به تنهايي ظاهر مي‌شوند و يا خاتمه دهنده واژه‌ها هستند.
    /// </summary>
    public const string FinalUnicodeChars = "ءآأؤإادذرزژو";

    /// <summary>
    ///     حرف نيم فاصله
    /// </summary>
    public const char ZeroWidthNonJoiner = (char)0x200C;

    /// <summary>
    ///     حرف فاصله
    /// </summary>
    public const char Space = (char)32;

    /// <summary>
    ///     كاما در كدپيج ايران سيستم
    /// </summary>
    public const char IranSystemComma = (char)138; // ،

    /// <summary>
    ///     صفر در كدپيج ايران سيستم
    /// </summary>
    public const char IranSystemZero = (char)128; // ۰

    /// <summary>
    ///     «لا» در كدپيج ايران سيستم
    /// </summary>
    public const char IranSystemArabicLa = (char)242; // لا

    /// <summary>
    ///     الف يونيكد
    /// </summary>
    public const int UnicodeAlef = 0x0627;

    /// <summary>
    ///     لام يونيكد
    /// </summary>
    public const int UnicodeLam = 0x0644;

    /// <summary>
    ///     ي يونيكد
    /// </summary>
    public const int UnicodeYe = 0x620;

    /// <summary>
    ///     ه يونيكد
    /// </summary>
    public const int UnicodeHeh = 0x6d5;

    /// <summary>
    ///     ة يونيكد
    /// </summary>
    public const int UnicodeTehMarbuta = 0x0629;

    /// <summary>
    ///     همزه يونيكد
    /// </summary>
    public const int UnicodeHamzaBelow = 0x065F;

    /// <summary>
    ///     فتحه يونيكد
    /// </summary>
    public const int UnicodeFathatan = 0x064B;

    /// <summary>
    ///     آيا حرف جاري ايران سيستم انگليسي يا عددي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <param name="changeParenthesis"></param>
    /// <returns></returns>
    public static bool IsIranSystemLatinNumericChar(this char? current, bool changeParenthesis) =>
        current is not null && IsLatinNumericChar(current.Value, changeParenthesis);

    /// <summary>
    ///     آيا حرف جاري انگليسي و عددي است؟
    /// </summary>
    /// <param name="c"></param>
    /// <param name="changeParenthesis"></param>
    /// <returns></returns>
    public static bool IsLatinNumericChar(this char c, bool changeParenthesis) =>
        !changeParenthesis
            ? c is < IranSystemComma and > (char)31
            : c is < IranSystemComma and > (char)31 && !c.IsParenthesis();

    /// <summary>
    ///     آيا حرف جاري انگليسي است؟
    /// </summary>
    /// <param name="c"></param>
    /// <param name="changeParenthesis"></param>
    /// <returns></returns>
    public static bool IsLatinChar(this char c, bool changeParenthesis) =>
        !changeParenthesis ? c is < IranSystemZero and > (char)31 : c is < IranSystemZero and > Space;


    /// <summary>
    ///     آيا حرف جاري اعراب است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsUnicodeArabicDiacritics(this char current) =>
        current >= UnicodeFathatan && current <= UnicodeHamzaBelow;

    /// <summary>
    ///     آيا حرف جاري نيم‌فاصله است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsHalfSpace(this char current) => current == ZeroWidthNonJoiner;

    /// <summary>
    ///     آيا حرف جاري فارسي يا عربي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsUnicodeFarsiOrArabic(this char? current) =>
        current >= UnicodeYe && current <= UnicodeHeh && current != ZeroWidthNonJoiner;

    /// <summary>
    ///     آيا حرف جاري انگليسي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsUnicodeEnglish(this char current) => current < 0x0600;

    /// <summary>
    ///     آيا حرف جاري و پس از آن، حرف لا را تشكيل مي‌دهند؟
    /// </summary>
    /// <param name="current"></param>
    /// <param name="next"></param>
    /// <returns></returns>
    public static bool IsArabicUnicodeLa(this char current, char? next) =>
        current == UnicodeLam && next == UnicodeAlef;

    /// <summary>
    ///     آيا حرف جاري عدد فارسي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsUnicodePersianNumber(this char current) => current >= 0x6f0 && current <= 0x6f9;

    /// <summary>
    ///     حروفي كه به تنهايي ظاهر مي‌شوند و يا خاتمه دهنده واژه‌ها هستند.
    /// </summary>
    /// <param name="previous"></param>
    /// <returns></returns>
    public static bool IsFinalUnicodeChar(this char? previous) =>
        previous != null && FinalUnicodeChars.Contains(previous.Value, StringComparison.Ordinal);

    /// <summary>
    ///     آيا حرف جاري پرانتز است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsParenthesis(this char? current) =>
        current is not null && IsParenthesis(current.Value);

    /// <summary>
    ///     آيا حرف جاري پرانتز است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsParenthesis(this char current) => IranSystemTables.Parenthesis.Contains(current);

    /// <summary>
    ///     آيا حرف جاري نامريي يا فاصله است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsWhiteChar(this char? current) =>
        current is not null && IsWhiteChar(current.Value);

    /// <summary>
    ///     آيا حرف جاري نامريي يا فاصله است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsWhiteChar(this char current) => IranSystemTables.WhiteChars.Contains(current);

    /// <summary>
    ///     بازگشت حالت آينه‌اي حروف مانند ) بجاي (
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static char GetMirroredOrChar(this char current) =>
        current switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            ')' => '(',
            '}' => '{',
            ']' => '[',
            _ => current,
        };

    /// <summary>
    ///     بازگشت معادل انگليسي يك حرف يونيكد در كدپيج ايران سيستم
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static char GetLatinChar(this char current) =>
        "0123456789".Contains(current, StringComparison.Ordinal) ? (char)(current + 80) : current.GetMirroredOrChar();

    /// <summary>
    ///     آيا حرف جاري يك عدد انگليسي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsEnglishNumber(this char current) => current >= 48 && current <= 57;

    /// <summary>
    ///     آيا حرف جاري يك عدد انگليسي است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsEnglishNumber(this char? current) =>
        current.HasValue && IsEnglishNumber(current.Value);

    /// <summary>
    ///     آيا حرف جاري يك عدد فارسي ايران سيستم است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsIranSystemNumber(this char current) => current >= 128 && current <= 137;

    /// <summary>
    ///     آيا حرف جاري يك عدد فارسي ايران سيستم است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsIranSystemNumber(this char? current) =>
        current.HasValue && IsIranSystemNumber(current.Value);

    /// <summary>
    ///     تبديل انكدينگ يك رشته با فرمت داس به رشته‌اي يونيكد
    /// </summary>
    /// <param name="farsiDosString"></param>
    /// <returns></returns>
    public static IranSystemData ConvertCp1252StringToUnicode(
        this string farsiDosString)
    {
        if (farsiDosString == null)
        {
            throw new ArgumentNullException(nameof(farsiDosString));
        }

        var dstEncoding = Encoding.Unicode;
        var srcEncoding = Encoding.GetEncoding(1252);
        var bytes = farsiDosString.ToCharArray().Select(c => (byte)c).ToArray();
        var unicodeContent = Encoding.Convert(srcEncoding, dstEncoding, bytes);
        return new IranSystemData(dstEncoding.GetString(unicodeContent), bytes);
    }

    /// <summary>
    ///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
    ///     آيا حرف جاري يك حرف آغاز كننده‌ي واژه است؟
    /// </summary>
    /// <param name="next"></param>
    /// <returns></returns>
    public static bool IsInitialIranSystemChar(this char? next) =>
        next.HasValue && IranSystemTables.InitialIranSystemChars.Contains(next.Value);

    /// <summary>
    ///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
    ///     آيا حرف جاري يك حرف پايان دهنده‌ي واژه است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsFinalIranSystemChar(this char current) =>
        IranSystemTables.FinalIranSystemChars.Contains(current);

    /// <summary>
    ///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
    ///     آيا حرف جاري يك حرف پايان دهنده‌ي واژه است؟
    /// </summary>
    /// <param name="current"></param>
    /// <returns></returns>
    public static bool IsFinalIranSystemChar(this char? current) =>
        current.HasValue && IsFinalIranSystemChar(current.Value);

    /// <summary>
    ///     در كدپيج ايران سيستم، محل قرارگيري فواصل ابتدا و انتهاي حروف بايد تغيير كند و معكوس شود!
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string ReverseStartAndEndSpaces(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return text;
        }

        var len = text.Length;
        var numberOfStartSpaces = len - text.TrimStart(' ').Length;
        var numberOfEndSpaces = len - text.TrimEnd(' ').Length;
        return $"{new string(' ', numberOfEndSpaces)}{text.Trim()}{new string(' ', numberOfStartSpaces)}";
    }
}
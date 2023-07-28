using System.Collections.Generic;
using System.Linq;

namespace DNTPersianUtils.Core;

/// <summary>
///     تعاريف جداول مورد نياز جهت تبديلات ايران سيستمي
/// </summary>
public static class IranSystemTables
{
    /// <summary>
    ///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
    ///     اين جدول چهار محل قرارگيري آن‌ها را مشخص مي‌كند.
    /// </summary>
    public static readonly IDictionary<char, char[]> UnicodeToIranSystemTable =
        new Dictionary<char, char[]>
        {
            // [UnicodeChar] =     { ISOLATED   - INITIAL  - MEDIAL   - FINAL   }
            [(char)0x0030] = new[]
                             {
                                 FarsiDosExtensions.IranSystemZero,
                                 FarsiDosExtensions.IranSystemZero,
                                 FarsiDosExtensions.IranSystemZero,
                                 FarsiDosExtensions.IranSystemZero,
                             }, // ۰
            [(char)0x0031] = new[] { (char)0x81, (char)129, (char)129, (char)129 }, // ۱
            [(char)0x0032] = new[] { (char)0x82, (char)130, (char)130, (char)130 }, // ۲
            [(char)0x0033] = new[] { (char)0x83, (char)131, (char)131, (char)131 }, // ۳
            [(char)0x0034] = new[] { (char)0x84, (char)132, (char)132, (char)132 }, // ۴
            [(char)0x0035] = new[] { (char)0x85, (char)133, (char)133, (char)133 }, // ۵
            [(char)0x0036] = new[] { (char)0x86, (char)134, (char)134, (char)134 }, // ۶
            [(char)0x0037] = new[] { (char)0x87, (char)135, (char)135, (char)135 }, // ۷
            [(char)0x0038] = new[] { (char)0x88, (char)136, (char)136, (char)136 }, // ۸
            [(char)0x0039] = new[] { (char)0x89, (char)137, (char)137, (char)137 }, // ۹
            [(char)0x060C] = new[] { (char)0x8A, (char)0x8A, (char)0x8A, (char)0x8A }, //  COMMA : ،
            [(char)0x0640] = new[] { (char)0x8B, (char)0x8B, (char)0x8B, (char)0x8B }, //  TATWEEL : ـ
            [(char)0x061F] = new[] { (char)0x8C, (char)0x8C, (char)0x8C, (char)0x8C }, //  QUESTION MARK : ؟
            [(char)0x0622] = new[] { (char)0x8D, (char)0x8D, (char)0x8D, (char)0x8D }, // ALEF WITH MADDA ABOVE : آ
            [(char)0x0626] = new[] { (char)0x8E, (char)0x8E, (char)0x8E, (char)0x8E }, // YEH WITH HAMZA ABOVE : ئ
            [(char)0x0621] = new[] { (char)0x8F, (char)0x8F, (char)0x8F, (char)0x8F }, // HAMZA : ء
            [(char)FarsiDosExtensions.UnicodeAlef] =
                new[] { (char)0x90, (char)0x90, (char)0x91, (char)0x91 }, // ALEF : ا
            [(char)0x0623] = new[] { (char)0x90, (char)0x90, (char)0x91, (char)0x91 }, // ALEF WITH HAMZA ABOVE : أ
            [(char)0x0624] = new[] { (char)0xF8, (char)0xF8, (char)0xF8, (char)0xF8 }, // ؤ
            [(char)0x0625] = new[] { (char)0x90, (char)0x90, (char)0x91, (char)0x91 }, // ALEF WITH HAMZA BELOW : إ
            [(char)0x0628] = new[] { (char)0x92, (char)0x93, (char)0x93, (char)0x92 }, // BEH : ب
            [(char)FarsiDosExtensions.UnicodeTehMarbuta] =
                new[] { (char)0xF9, (char)0xFB, (char)0xFA, (char)0xF9 }, // ﻩ
            [(char)0x067E] = new[] { (char)0x94, (char)0x95, (char)0x95, (char)0x94 }, // PEH : پ
            [(char)0x062A] = new[] { (char)0x96, (char)0x97, (char)0x97, (char)0x96 }, // TEH : ت
            [(char)0x062B] = new[] { (char)0x98, (char)0x99, (char)0x99, (char)0x98 }, // THEH : ث
            [(char)0x062C] = new[] { (char)0x9A, (char)0x9B, (char)0x9B, (char)0x9A }, // JEEM : ج
            [(char)0x0686] = new[] { (char)0x9C, (char)0x9D, (char)0x9D, (char)0x9C }, // TCHEH : چ
            [(char)0x062D] = new[] { (char)0x9E, (char)0x9F, (char)0x9F, (char)0x9E }, // HAH : ح
            [(char)0x062E] = new[] { (char)0xA0, (char)0xA1, (char)0xA1, (char)0xA0 }, // KHAH : خ
            [(char)0x062F] = new[] { (char)0xA2, (char)0xA2, (char)0xA2, (char)0xA2 }, // DAL : د
            [(char)0x0630] = new[] { (char)0xA3, (char)0xA3, (char)0xA3, (char)0xA3 }, // THAL : ذ
            [(char)0x0631] = new[] { (char)0xA4, (char)0xA4, (char)0xA4, (char)0xA4 }, // REH : ر
            [(char)0x0632] = new[] { (char)0xA5, (char)0xA5, (char)0xA5, (char)0xA5 }, // ZAIN : ز
            [(char)0x0698] = new[] { (char)0xA6, (char)0xA6, (char)0xA6, (char)0xA6 }, // JEH : ژ
            [(char)0x0633] = new[] { (char)0xA7, (char)0xA8, (char)0xA8, (char)0xA7 }, // SEEN : س
            [(char)0x0634] = new[] { (char)0xA9, (char)0xAA, (char)0xAA, (char)0xA9 }, // SHEEN : ش
            [(char)0x0635] = new[] { (char)0xAB, (char)0xAC, (char)0xAC, (char)0xAB }, // SAD : ص
            [(char)0x0636] = new[] { (char)0xAD, (char)0xAE, (char)0xAE, (char)0xAD }, // DAD : ض
            [(char)0x0637] = new[] { (char)0xAF, (char)0xAF, (char)0xAF, (char)0xAF }, // TAH : ط
            [(char)0x0638] = new[] { (char)0xE0, (char)0xE0, (char)0xE0, (char)0xE0 }, // ZAH : ظ
            [(char)0x0639] = new[] { (char)0xE1, (char)0xE4, (char)0xE3, (char)0xE2 }, // AIN : ع
            [(char)0x063A] = new[] { (char)0xE5, (char)0xE8, (char)0xE7, (char)0xE6 }, // GHAIN : غ
            [(char)0x0641] = new[] { (char)0xE9, (char)0xEA, (char)0xEA, (char)0xE9 }, // FEH : ف
            [(char)0x0642] = new[] { (char)0xEB, (char)0xEC, (char)0xEC, (char)0xEB }, // QAF : ق
            [(char)0x06A9] = new[] { (char)0xED, (char)0xEE, (char)0xEE, (char)0xED }, // KEHEH : ک
            [(char)0x0643] = new[] { (char)0xED, (char)0xEE, (char)0xEE, (char)0xED }, // KAF : ك
            [(char)0x06AF] = new[] { (char)0xEF, (char)0xF0, (char)0xF0, (char)0xEF }, // GAF : گ
            [(char)FarsiDosExtensions.UnicodeLam] = new[] { (char)0xF1, (char)0xF3, (char)0xF3, (char)0xF1 }, // LAM : ل
            [(char)0x0645] = new[] { (char)0xF4, (char)0xF5, (char)0xF5, (char)0xF4 }, // MEEM : م
            [(char)0x0646] = new[] { (char)0xF6, (char)0xF7, (char)0xF7, (char)0xF6 }, // NOON : ن
            [(char)0x0648] = new[] { (char)0xF8, (char)0xF8, (char)0xF8, (char)0xF8 }, // WAW : و
            [(char)0x0647] = new[] { (char)0xF9, (char)0xFB, (char)0xFA, (char)0xF9 }, // HEH : ه
            [(char)0x06CC] = new[] { (char)0xFD, (char)0xFE, (char)0xFE, (char)0xFC }, // FARSI YEH : ی
            [(char)0x0649] = new[] { (char)0xFD, (char)0xFE, (char)0xFE, (char)0xFC }, // ALEF MAKSURA : ى
            [(char)0x064A] = new[] { (char)0xFD, (char)0xFE, (char)0xFE, (char)0xFC }, // YEH : ي
            [(char)0x06A0] = new[] { (char)0xFF, (char)0xFF, (char)0xFF, (char)0xFF }, // AIN WITH THREE DOTS ABOVE : ڠ
        };

    /// <summary>
    ///     حرف نامرئي و يا فاصله
    /// </summary>
    public static readonly ISet<char> WhiteChars =
        new HashSet<char> { (char)8, (char)09, (char)10, (char)13, (char)27, (char)32, (char)0 };

    /// <summary>
    ///     پرانتزها
    /// </summary>
    public static readonly ISet<char> Parenthesis =
        new HashSet<char> { (char)40, (char)41, (char)91, (char)93, (char)123, (char)125 };

    /// <summary>
    ///     0 to 254
    ///     https://fa.wikipedia.org/wiki/%DA%A9%D8%AF%D8%A8%D9%86%D8%AF%DB%8C_%D8%A7%DB%8C%D8%B1%D8%A7%D9%86%E2%80%8C%D8%B3%DB%8C%D8%B3%D8%AA%D9%85
    ///     شماره حرف كدپيج ايران سيستم را تبديل به يك حرف يونيكد مي‌كند
    /// </summary>
    public static readonly string[] IranSystemIndexToUnicodeTable =
    {
        "\u0000", //  
        "\u0001", // 
        "\u0002", // 
        "\u0003", // 
        "\u0004", // 
        "\u0005", // 
        "\u0006", // 
        "\u0007", // 
        "\u0008", // 
        "\u0009", // 	
        "\u000A", //
        "\u000B", // 
        "\u000C", // 
        "\u000D", //
        "\u000E", // 
        "\u000F", // 
        "\u0010", // 
        "\u0011", // 
        "\u0012", // 
        "\u0013", // 
        "\u0014", // 
        "\u0015", // 
        "\u0016", // 
        "\u0017", // 
        "\u0018", // 
        "\u0019", // 
        "\u001A", // 
        "\u001B", // 
        "\u001C", // 
        "\u001D", // 
        "\u001E", // 
        "\u001F", // 
        "\u0020", //  
        "\u0021", // !
        "\u0022", // "
        "\u0023", // #
        "\u0024", // $
        "\u0025", // %
        "\u0026", // &
        "\u0027", // '
        "\u0028", // (
        "\u0029", // )
        "\u002A", // *
        "\u002B", // +
        "\u002C", // ,
        "\u002D", // -
        "\u002E", // .
        "\u002F", // /
        "\u0030", // 0
        "\u0031", // 1
        "\u0032", // 2
        "\u0033", // 3
        "\u0034", // 4
        "\u0035", // 5
        "\u0036", // 6
        "\u0037", // 7
        "\u0038", // 8
        "\u0039", // 9
        "\u003A", // :
        "\u003B", // ;
        "\u003C", // <
        "\u003D", // =
        "\u003E", // >
        "\u003F", // ?
        "\u0040", // @
        "\u0041", // A
        "\u0042", // B
        "\u0043", // C
        "\u0044", // D
        "\u0045", // E
        "\u0046", // F
        "\u0047", // G
        "\u0048", // H
        "\u0049", // I
        "\u004A", // J
        "\u004B", // K
        "\u004C", // L
        "\u004D", // M
        "\u004E", // N
        "\u004F", // O
        "\u0050", // P
        "\u0051", // Q
        "\u0052", // R
        "\u0053", // S
        "\u0054", // T
        "\u0055", // U
        "\u0056", // V
        "\u0057", // W
        "\u0058", // X
        "\u0059", // Y
        "\u005A", // Z
        "\u005B", // [
        "\u005C", // \
        "\u005D", // ]
        "\u005E", // ^
        "\u005F", // _
        "\u0060", // `
        "\u0061", // a
        "\u0062", // b
        "\u0063", // c
        "\u0064", // d
        "\u0065", // e
        "\u0066", // f
        "\u0067", // g
        "\u0068", // h
        "\u0069", // i
        "\u006A", // j
        "\u006B", // k
        "\u006C", // l
        "\u006D", // m
        "\u006E", // n
        "\u006F", // o
        "\u0070", // p
        "\u0071", // q
        "\u0072", // r
        "\u0073", // s
        "\u0074", // t
        "\u0075", // u
        "\u0076", // v
        "\u0077", // w
        "\u0078", // x
        "\u0079", // y
        "\u007A", // z
        "\u007B", // {
        "\u007C", // |
        "\u007D", // }
        "\u007E", // ~
        "\u007F", // 
        "\u06F0", // ۰
        "\u06F1", // ۱
        "\u06F2", // ۲
        "\u06F3", // ۳
        "\u06F4", // ۴
        "\u06F5", // ۵
        "\u06F6", // ۶
        "\u06F7", // ۷
        "\u06F8", // ۸
        "\u06F9", // ۹
        "\u060C", // ،
        "\u0640", // ـ
        "\u061F", // ؟
        "\u0622", // آ
        "\u0626", // ئ
        "\u0621", // ء
        "\u0627", // ا
        "\u0627", // ا
        "\u0628", // ب
        "\u0628", // ب
        "\u067E", // پ
        "\u067E", // پ
        "\u062A", // ت
        "\u062A", // ت
        "\u062B", // ث
        "\u062B", // ث
        "\u062C", // ج
        "\u062C", // ج
        "\u0686", // چ
        "\u0686", // چ
        "\u062D", // ح
        "\u062D", // ح
        "\u062E", // خ
        "\u062E", // خ
        "\u062F", // د
        "\u0630", // ذ
        "\u0631", // ر
        "\u0632", // ز
        "\u0698", // ژ
        "\u0633", // س
        "\u0633", // س
        "\u0634", // ش
        "\u0634", // ش
        "\u0635", // ص
        "\u0635", // ص
        "\u0636", // ض
        "\u0636", // ض
        "\u0637", // ط
        "\u00B0", // °
        "\u2593", // ▓
        "\u2502", // │
        "\u00B2", // ²
        "\u00B3", // ³
        "\u00B4", // ´
        "\u00B4", // ´
        "\u00B6", // ¶
        "\u2563", // ╣
        "\u061F", // ؟
        "\u2557", // ╗
        "\u061B", // ؛
        "\u255C", // ╜
        "\u255B", // ╛
        "\u2510", // ┐
        "\u0638", // ظ
        "\u061F", // ؟
        "\u06C1", // ہ
        "\u0621", // ء
        "\u0622", // آ
        "\u0623", // أ
        "\u0624", // ؤ
        "\u0625", // إ
        "\u0626", // ئ
        "\u0627", // ا
        "\u0628", // ب
        "\u0629", // ة
        "\u062A", // ت
        "\u062B", // ث
        "\u062C", // ج
        "\u062D", // ح
        "\u062E", // خ
        "\u062F", // د
        "\u0630", // ذ
        "\u0631", // ر
        "\u062B", // ث
        "\u0628", // ب
        "\u06C1", // ہ
        "\u0639", // ع
        "\u0629", // ة
        "\u00D7", // ×
        "\u0637", // ط
        "\u0638", // ظ
        "\u0639", // ع
        "\u063A", // غ
        "\u063A", // غ
        "\u063A", // غ
        "\u06A9", // ک
        "\u0638", // ظ
        "\u0639", // ع
        "\u0639", // ع
        "\u0639", // ع
        "\u0639", // ع
        "\u063A", // غ
        "\u063A", // غ
        "\u063A", // غ
        "\u063A", // غ
        "\u0641", // ف
        "\u0641", // ف
        "\u0642", // ق
        "\u0642", // ق
        "\u06A9", // ک
        "\u06A9", // ک
        "\u06AF", // گ
        "\u06AF", // گ
        "\u0644", // ل
        "\u0644\u0627", // لا
        "\u0644", // ل
        "\u0645", // م
        "\u0645", // م
        "\u0646", // ن
        "\u0646", // ن
        "\u0648", // و
        "\u0647", // ه
        "\u0647", // ه
        "\u0647", // ه
        "\u06CC", // ی
        "\u06CC", // ی
        "\u06CC", // ی
    };

    /// <summary>
    ///     طول آرايه تبديلگر ايران سيستم به يونيكد
    /// </summary>
    public static readonly int IranSystemIndexToUnicodeTableLenght = IranSystemIndexToUnicodeTable.Length;

    /// <summary>
    ///     شکل پایانی حروف
    /// </summary>
    public static readonly ISet<char> FinalIranSystemChars =
        new HashSet<char>
        {
            (char)0x92, // ﺏ
            (char)0x94, // ﭖ
            (char)0x96, // ﺕ
            (char)0x98, // ﺙ
            (char)0x9A, // ﺝ
            (char)0x9C, // ﭺ
            (char)0x9E, // ﺡ
            (char)0xA0, // ﺥ
            (char)0xA7, // ﺱ
            (char)0xA9, // ﺵ
            (char)0xAB, // ﺹ
            (char)0xAD, // ﺽ
            //(char)0xAF, // ط
            //(char)0xE0, // ظ
            (char)0xE1, // ﻉ
            (char)0xE2, // ﻊ
            (char)0xE5, // ﻍ
            (char)0xE6, // ﻎ
            (char)0xE9, // ﻑ
            (char)0xEB, // ﻕ
            (char)0xED, // ﮎ
            (char)0xEF, // ﮒ
            (char)0xF1, // ﻝ
            (char)0xF4, // ﻡ
            (char)0xF6, // ﻥ
            (char)0xF9, // ﻩ
            (char)0xFC, // ﯽ
            (char)0xFD, // ﯼ
        };

    /// <summary>
    ///     در كدپيج ايران سيستم، حروف بر اساس محل قرارگيري آن‌ها در واژه تعريف مي‌شوند.
    ///     اين مجموعه حاوي حروف آغاز كننده‌ي يك واژه است.
    /// </summary>
    public static readonly ISet<char> InitialIranSystemChars =
        new HashSet<char>(UnicodeToIranSystemTable.Select(item => item.Value[1]));
}
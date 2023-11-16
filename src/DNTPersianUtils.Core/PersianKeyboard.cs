namespace DNTPersianUtils.Core;

/// <summary>
///     تبديل حروف تايپ شده‌ي انگليسي به فارسي
/// </summary>
public static class PersianKeyboard
{
    private const char ZWNJ = (char)8204; // Shift-space

    /// <summary>
    ///     تبديل حروف تايپ شده‌ي انگليسي به فارسي
    ///     مناسب براي طراحي يك صفحه كليد مجازي
    /// </summary>
    /// <param name="data">متن و يا حرف تايپ شده</param>
    /// <param name="caretPosition">محل قرارگيري نشانه‌ي تايپ در ورودي</param>
    /// <param name="isShiftPressed">آيا در حين تايپ، كليد شيفت فشرده هم شده‌است؟</param>
    /// <param name="convertEnglishNumbers">آيا اعداد وارد شده نيز فارسي شوند؟</param>
    /// <returns>متن تبديل شده</returns>
    public static string ConvertTypedTextToPersian(
        this string? data,
        int caretPosition,
        bool isShiftPressed,
        bool convertEnglishNumbers)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            return string.Empty;
        }

        var dataChars = data.ToCharArray();
        for (var i = 0; i < dataChars.Length; i++)
        {
            var isShiftPressedAtCaretPosition = isShiftPressed && i == caretPosition - 1;
            switch (dataChars[i])
            {
                case ' ':
                    if (isShiftPressedAtCaretPosition)
                    {
                        dataChars[i] = ZWNJ;
                    }

                    break;

                case '[':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '}' : 'ج';
                    break;

                case ']':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '{' : 'چ';
                    break;

                case '\\':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '|' : 'ژ';
                    break;

                case '`':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ى' : 'پ';
                    break;

                case ';':                    
                    dataChars[i] = isShiftPressedAtCaretPosition ? ':' : 'ک';
                    break;

                case '\'':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '"' : 'گ'; 
                    break;

                case ',':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ؤ' : 'و';
                    break;

                case 'a':
                case 'A':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'َ' : 'ش';
                    break;

                case '?':
                    dataChars[i] = '؟';
                    break;

                case 'b':
                case 'B':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'إ' : 'ذ';
                    break;

                case 'c':
                case 'C':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '‍' : 'ز';
                    break;

                case 'd':
                case 'D':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ِ' : 'ی';
                    break;

                case 'e':
                case 'E':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ٍ' : 'ث';
                    break;

                case 'f':
                case 'F':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ّ' : 'ب';
                    break;

                case 'g':
                case 'G':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ْ' : 'ل';
                    break;

                case 'h':
                case 'H':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'آ' : 'ا';
                    break;

                case 'i':
                case 'I':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ة' : 'ه';
                    break;

                case 'j':
                case 'J':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ـ' : 'ت';
                    break;

                case 'k':
                case 'K':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '»' : 'ن';
                    break;

                case 'l':
                case 'L':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '«' : 'م';
                    break;

                case 'm':
                case 'M':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ء' : 'ئ';
                    break;

                case 'n':
                case 'N':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'أ' : 'د';
                    break;

                case 'o':
                case 'O':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '×' : 'خ';
                    break;

                case 'p':
                case 'P':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '÷' : 'ح';
                    break;

                case 'q':
                case 'Q':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ً' : 'ض';
                    break;

                case 'r':
                case 'R':
                    if (isShiftPressedAtCaretPosition)
                    {
                        // 'ريال'
                    }
                    else
                    {
                        dataChars[i] = 'ق';
                    }

                    break;

                case 's':
                case 'S':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ُ' : 'س';
                    break;

                case 't':
                case 'T':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '،' : 'ف';
                    break;

                case 'u':
                case 'U':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '\\' : 'ع';
                    break;

                case 'v':
                case 'V':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ی' : 'ر';
                    break;

                case 'w':
                case 'W':
                    dataChars[i] = isShiftPressedAtCaretPosition ? 'ٌ' : 'ص';
                    break;

                case 'x':
                case 'X':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '[' : 'ط';
                    break;

                case 'y':
                case 'Y':
                    dataChars[i] = isShiftPressedAtCaretPosition ? '؛' : 'غ';
                    break;

                case 'z':
                case 'Z':
                    dataChars[i] = isShiftPressedAtCaretPosition ? ']' : 'ظ';
                    break;

                case '0':
                case '\u0660':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F0';
                    }

                    break;

                case '1':
                case '\u0661':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F1';
                    }

                    break;

                case '2':
                case '\u0662':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F2';
                    }

                    break;

                case '3':
                case '\u0663':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F3';
                    }

                    break;

                case '4':
                case '\u0664':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F4';
                    }

                    break;

                case '5':
                case '\u0665':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F5';
                    }

                    break;

                case '6':
                case '\u0666':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F6';
                    }

                    break;

                case '7':
                case '\u0667':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F7';
                    }

                    break;

                case '8':
                case '\u0668':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F8';
                    }

                    break;

                case '9':
                case '\u0669':
                    if (convertEnglishNumbers)
                    {
                        dataChars[i] = '\u06F9';
                    }

                    break;
            }
        }

        return new string(dataChars);
    }
}
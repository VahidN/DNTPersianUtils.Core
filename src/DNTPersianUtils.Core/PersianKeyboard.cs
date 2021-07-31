namespace DNTPersianUtils.Core
{
    /// <summary>
    /// تبديل حروف تايپ شده‌ي انگليسي به فارسي
    /// </summary>
    public static class PersianKeyboard
    {
        private const char ZWNJ = (char)8204; // Shift-space

        /// <summary>
        /// تبديل حروف تايپ شده‌ي انگليسي به فارسي
        /// مناسب براي طراحي يك صفحه كليد مجازي
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
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '}';
                        }
                        else
                        {
                            dataChars[i] = 'ج';
                        }
                        break;

                    case ']':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '{';
                        }
                        else
                        {
                            dataChars[i] = 'چ';
                        }
                        break;

                    case '\\':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '|';
                        }
                        else
                        {
                            dataChars[i] = 'ژ';
                        }
                        break;

                    case '`':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ى';
                        }
                        else
                        {
                            dataChars[i] = 'پ';
                        }
                        break;

                    case ';':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = ':';
                        }
                        else
                        {
                            dataChars[i] = 'ک';
                        }
                        break;

                    case '\'':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '"';
                        }
                        else
                        {
                            dataChars[i] = 'گ';
                        }
                        break;

                    case ',':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ؤ';
                        }
                        else
                        {
                            dataChars[i] = 'و';
                        }
                        break;

                    case 'a':
                    case 'A':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'َ';
                        }
                        else
                        {
                            dataChars[i] = 'ش';
                        }
                        break;

                    case '?':
                        dataChars[i] = '؟';
                        break;

                    case 'b':
                    case 'B':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'إ';
                        }
                        else
                        {
                            dataChars[i] = 'ذ';
                        }
                        break;

                    case 'c':
                    case 'C':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '‍';
                        }
                        else
                        {
                            dataChars[i] = 'ز';
                        }
                        break;

                    case 'd':
                    case 'D':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ِ';
                        }
                        else
                        {
                            dataChars[i] = 'ی';
                        }
                        break;

                    case 'e':
                    case 'E':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ٍ';
                        }
                        else
                        {
                            dataChars[i] = 'ث';
                        }
                        break;

                    case 'f':
                    case 'F':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ّ';
                        }
                        else
                        {
                            dataChars[i] = 'ب';
                        }
                        break;

                    case 'g':
                    case 'G':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ْ';
                        }
                        else
                        {
                            dataChars[i] = 'ل';
                        }
                        break;

                    case 'h':
                    case 'H':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'آ';
                        }
                        else
                        {
                            dataChars[i] = 'ا';
                        }
                        break;

                    case 'i':
                    case 'I':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ة';
                        }
                        else
                        {
                            dataChars[i] = 'ه';
                        }
                        break;

                    case 'j':
                    case 'J':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ـ';
                        }
                        else
                        {
                            dataChars[i] = 'ت';
                        }
                        break;

                    case 'k':
                    case 'K':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '»';
                        }
                        else
                        {
                            dataChars[i] = 'ن';
                        }
                        break;

                    case 'l':
                    case 'L':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '«';
                        }
                        else
                        {
                            dataChars[i] = 'م';
                        }
                        break;

                    case 'm':
                    case 'M':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ء';
                        }
                        else
                        {
                            dataChars[i] = 'ئ';
                        }
                        break;

                    case 'n':
                    case 'N':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'أ';
                        }
                        else
                        {
                            dataChars[i] = 'د';
                        }
                        break;

                    case 'o':
                    case 'O':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '×';
                        }
                        else
                        {
                            dataChars[i] = 'خ';
                        }
                        break;

                    case 'p':
                    case 'P':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '÷';
                        }
                        else
                        {
                            dataChars[i] = 'ح';
                        }
                        break;

                    case 'q':
                    case 'Q':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ً';
                        }
                        else
                        {
                            dataChars[i] = 'ض';
                        }
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
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ُ';
                        }
                        else
                        {
                            dataChars[i] = 'س';
                        }
                        break;

                    case 't':
                    case 'T':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '،';
                        }
                        else
                        {
                            dataChars[i] = 'ف';
                        }
                        break;

                    case 'u':
                    case 'U':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '\\';
                        }
                        else
                        {
                            dataChars[i] = 'ع';
                        }
                        break;

                    case 'v':
                    case 'V':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ی';
                        }
                        else
                        {
                            dataChars[i] = 'ر';
                        }
                        break;

                    case 'w':
                    case 'W':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = 'ٌ';
                        }
                        else
                        {
                            dataChars[i] = 'ص';
                        }
                        break;

                    case 'x':
                    case 'X':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '[';
                        }
                        else
                        {
                            dataChars[i] = 'ط';
                        }
                        break;

                    case 'y':
                    case 'Y':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = '؛';
                        }
                        else
                        {
                            dataChars[i] = 'غ';
                        }
                        break;

                    case 'z':
                    case 'Z':
                        if (isShiftPressedAtCaretPosition)
                        {
                            dataChars[i] = ']';
                        }
                        else
                        {
                            dataChars[i] = 'ظ';
                        }
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
}
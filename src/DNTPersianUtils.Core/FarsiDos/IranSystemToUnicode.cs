using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DNTPersianUtils.Core;

/// <summary>
///     https://fa.wikipedia.org/wiki/%DA%A9%D8%AF%D8%A8%D9%86%D8%AF%DB%8C_%D8%A7%DB%8C%D8%B1%D8%A7%D9%86%E2%80%8C%D8%B3%DB%8C%D8%B3%D8%AA%D9%85
///     تبديلگر متون ايران سيستم به يونيكد
/// </summary>
public static class IranSystemToUnicode
{
#if !NET4_6
    static IranSystemToUnicode()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    }
#endif

    /// <summary>
    ///     تبديلگر متن فارسي داس به متن يونيكد
    /// </summary>
    /// <param name="iranSystemFilePath">مسير فايل متن فارسي داس</param>
    /// <param name="inputCodepage">
    ///     بسته به روش دريافت اطلاعات، عموما يكي از سه روش ارائه شده‌ي در اينجا براي پردازش اطلاعات
    ///     متني داس مفيد هستند
    /// </param>
    /// <param name="changeParenthesis">آيا پرانتزها هم تغيير داده شوند؟</param>
    /// <param name="reverseInput">آيا در ابتدا ورودي معكوس شود؟</param>
    /// <param name="useHalfSpace">
    ///     در محل‌هاي مناسب، بجاي فاصله، «نيم فاصله» قرار خواهد گرفت. در صورت عدم نياز به آن، آن‌را
    ///     خاموش كنيد
    /// </param>
    /// <returns></returns>
    public static string FromIranSystemFileToUnicode(this string iranSystemFilePath,
                                                     int inputCodepage,
                                                     bool changeParenthesis = false,
                                                     bool reverseInput = false,
                                                     bool useHalfSpace = true)
    {
        var dosContent = File.ReadAllText(iranSystemFilePath, Encoding.GetEncoding(inputCodepage));
        return dosContent.FromIranSystemToUnicode(inputCodepage, changeParenthesis, reverseInput, useHalfSpace);
    }

    /// <summary>
    ///     تبديلگر متن فارسي داس به متن يونيكد
    /// </summary>
    /// <param name="iranSystemFilePath">مسير فايل متن فارسي داس</param>
    /// <param name="inputCodepage">
    ///     بسته به روش دريافت اطلاعات، عموما يكي از سه روش ارائه شده‌ي در اينجا براي پردازش اطلاعات
    ///     متني داس مفيد هستند
    /// </param>
    /// <param name="changeParenthesis">آيا پرانتزها هم تغيير داده شوند؟</param>
    /// <param name="reverseInput">آيا در ابتدا ورودي معكوس شود؟</param>
    /// <param name="useHalfSpace">
    ///     در محل‌هاي مناسب، بجاي فاصله، «نيم فاصله» قرار خواهد گرفت. در صورت عدم نياز به آن، آن‌را
    ///     خاموش كنيد
    /// </param>
    /// <returns></returns>
    public static string FromIranSystemFileToUnicode(this string iranSystemFilePath,
                                                     TextEncoding inputCodepage = TextEncoding.CP1252,
                                                     bool changeParenthesis = false,
                                                     bool reverseInput = false,
                                                     bool useHalfSpace = true) =>
        FromIranSystemFileToUnicode(iranSystemFilePath,
                                    (int)inputCodepage,
                                    changeParenthesis,
                                    reverseInput,
                                    useHalfSpace);

    /// <summary>
    ///     تبديلگر متن فارسي داس به متن يونيكد
    /// </summary>
    /// <param name="iranSystemInput">
    ///     متن فارسي داس
    ///     بهتر است اين متن را تريم نكنيد؛ چون ممكن است تعدادي كاراكتر آن تخريب شوند
    /// </param>
    /// <param name="inputCodepage">
    ///     بسته به روش دريافت اطلاعات، عموما يكي از سه روش ارائه شده‌ي در اينجا براي پردازش اطلاعات
    ///     متني داس مفيد هستند
    /// </param>
    /// <param name="changeParenthesis">آيا پرانتزها هم تغيير داده شوند؟</param>
    /// <param name="reverseInput">آيا در ابتدا ورودي معكوس شود؟</param>
    /// <param name="useHalfSpace">
    ///     در محل‌هاي مناسب، بجاي فاصله، «نيم فاصله» قرار خواهد گرفت. در صورت عدم نياز به آن، آن‌را
    ///     خاموش كنيد
    /// </param>
    /// <returns></returns>
    public static string FromIranSystemToUnicode(this string? iranSystemInput,
                                                 TextEncoding inputCodepage = TextEncoding.CP1252,
                                                 bool changeParenthesis = false,
                                                 bool reverseInput = false,
                                                 bool useHalfSpace = true) =>
        FromIranSystemToUnicode(iranSystemInput,
                                (int)inputCodepage,
                                changeParenthesis,
                                reverseInput,
                                useHalfSpace);

    /// <summary>
    ///     تبديلگر متن فارسي داس به متن يونيكد
    /// </summary>
    /// <param name="iranSystemInput">
    ///     متن فارسي داس
    ///     بهتر است اين متن را تريم نكنيد؛ چون ممكن است تعدادي كاراكتر آن تخريب شوند
    /// </param>
    /// <param name="inputCodepage">
    ///     بسته به روش دريافت اطلاعات، عموما يكي از سه روش ارائه شده‌ي در اينجا براي پردازش اطلاعات
    ///     متني داس مفيد هستند
    /// </param>
    /// <param name="changeParenthesis">آيا پرانتزها هم تغيير داده شوند؟</param>
    /// <param name="reverseInput">آيا در ابتدا ورودي معكوس شود؟</param>
    /// <param name="useHalfSpace">
    ///     در محل‌هاي مناسب، بجاي فاصله، «نيم فاصله» قرار خواهد گرفت. در صورت عدم نياز به آن، آن‌را
    ///     خاموش كنيد
    /// </param>
    /// <returns></returns>
    public static string FromIranSystemToUnicode(this string? iranSystemInput,
                                                 int inputCodepage,
                                                 bool changeParenthesis = false,
                                                 bool reverseInput = false,
                                                 bool useHalfSpace = true)
    {
        if (string.IsNullOrWhiteSpace(iranSystemInput))
        {
            return string.Empty;
        }

        // NOTE: Don't Trim() the input. The Trim() method will remove some of the DOS chars such as 0xA0=خ!
        //iranSystemInput = iranSystemInput.Trim(' ');

        if (reverseInput)
        {
            iranSystemInput = new string(iranSystemInput.Reverse().ToArray());
        }

        var iranSystemStringBytes =
            inputCodepage == 0
                ? iranSystemInput.ToCharArray().Select(c => (byte)c).ToArray()
                : Encoding.GetEncoding(inputCodepage).GetBytes(iranSystemInput);

        return iranSystemStringBytes.FromIranSystemBytesToUnicode(changeParenthesis, false, useHalfSpace);
    }

    /// <summary>
    ///     تبديلگر متن فارسي داس به متن يونيكد
    /// </summary>
    /// <param name="iranSystemStringBytes">بايت‌هاي اصلي متن فارسي داس بدون هيچگونه تغييري</param>
    /// <param name="changeParenthesis">آيا پرانتزها هم تغيير داده شوند؟</param>
    /// <param name="reverseInput">آيا در ابتدا ورودي معكوس شود؟</param>
    /// <param name="useHalfSpace">
    ///     در محل‌هاي مناسب، بجاي فاصله، «نيم فاصله» قرار خواهد گرفت. در صورت عدم نياز به آن، آن‌را
    ///     خاموش كنيد
    /// </param>
    /// <returns></returns>
    public static string FromIranSystemBytesToUnicode(
        this byte[]? iranSystemStringBytes,
        bool changeParenthesis = false,
        bool reverseInput = false,
        bool useHalfSpace = true)
    {
        if (iranSystemStringBytes == null)
        {
            return string.Empty;
        }

        if (reverseInput)
        {
            iranSystemStringBytes = Enumerable.Reverse(iranSystemStringBytes).ToArray();
        }

        var limit = iranSystemStringBytes.Length;
        var returnValue = new StringBuilder(limit);
        var englishString = new StringBuilder();
        for (var index = limit - 1; index >= 0; index--)
        {
            var current = (char)iranSystemStringBytes[index];
            var nextIndex = index - 1;
            var next = nextIndex < 0 ? (char?)null : (char)iranSystemStringBytes[nextIndex];
            var unicodeChar = MapIranSystemToUnicodeChar(current, next, changeParenthesis, useHalfSpace);
            var isEnglish = current.IsLatinNumericChar(changeParenthesis);
            if (isEnglish)
            {
                englishString.Insert(0, unicodeChar);
            }
            else
            {
                returnValue.Append(englishString.ToString().ReverseStartAndEndSpaces()).Append(unicodeChar);
                englishString.Clear();
            }
        }

        returnValue.Append(englishString.ToString().ReverseStartAndEndSpaces());
        return returnValue.ToString().Trim().ApplyCorrectYeKe();
    }

    private static string MapIranSystemToUnicodeChar(char current,
                                                     char? next,
                                                     bool changeParenthesis,
                                                     bool useHalfSpace)
    {
        if (current >= IranSystemTables.IranSystemIndexToUnicodeTableLenght)
        {
            return current.ToString();
        }

        string returnValue;
        if (current.IsParenthesis())
        {
            returnValue = current.GetMirroredOrChar().ToString();
        }
        else if (current.IsLatinChar(changeParenthesis))
        {
            returnValue = current.ToString();
        }
        else
        {
            returnValue = IranSystemTables.IranSystemIndexToUnicodeTable[current];
            if (useHalfSpace && current.NeedsHalfSpace(next))
            {
                returnValue = $"{returnValue}{FarsiDosExtensions.ZeroWidthNonJoiner}";
            }
            else if (NeedsSpace(current, next, returnValue, changeParenthesis))
            {
                returnValue = $"{returnValue}{FarsiDosExtensions.Space}";
            }
        }

        return returnValue;
    }

    private static bool NeedsHalfSpace(this char current, char? next)
    {
        if (!current.IsFinalIranSystemChar())
        {
            return false;
        }

        if (next.IsWhiteChar())
        {
            return false;
        }

        if (next == FarsiDosExtensions.IranSystemArabicLa)
        {
            return true;
        }

        if (next.IsFinalIranSystemChar())
        {
            return false;
        }

        return next.IsInitialIranSystemChar();
    }

    private static bool NeedsSpace(this char current, char? next, string currentUnicode, bool changeParenthesis)
    {
        if (!current.IsFinalIranSystemChar())
        {
            return false;
        }

        if (string.Equals(currentUnicode,
                          ((char)FarsiDosExtensions.UnicodeTehMarbuta).ToString(),
                          StringComparison.Ordinal))
        {
            return true;
        }

        if (next.IsWhiteChar())
        {
            return false;
        }

        if (next.IsFinalIranSystemChar())
        {
            return false;
        }

        if (next.IsIranSystemLatinNumericChar(changeParenthesis))
        {
            return false;
        }

        if (next.IsParenthesis())
        {
            return false;
        }

        return true;
    }
}
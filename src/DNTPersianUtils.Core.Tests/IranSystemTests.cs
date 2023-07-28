using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranSystemTests
{
    [DataTestMethod]
    [DataRow("Words")]
    [DataRow("متن Words به Text")]
    [DataRow("متنWordsبهText")]
    [DataRow("متنWords بهText")]
    [DataRow("متن Text جمع 123")]
    [DataRow("This is a test")]
    [DataRow("تبدیل VGA به EGA")]
    [DataRow("این برای آزمایش 1234 است و خواهد بود. This is a Test می‌باشد.")]
    [DataRow("این برای آزمایش ۰۱۲۳۴۵۶۷۸۹ است و خواهد بود. This is a Test می‌باشد.")]
    [DataRow("This is a test می‌باشد")]
    [DataRow("آزمایش (پرانتز) است 456 البته(123) هم (abc) هست asd است.")]
    [DataRow("آن (پرانتز) است")]
    [DataRow("(پرانتز)")]
    public void Test_Multiple_Words_Can_Be_Converted(string input)
    {
        var result = input.FromUnicodeToIranSystem(false);
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(input, actual);
    }

    [DataTestMethod]
    [DataRow("ö¤ú— ë¯‘÷õ", "مناطق تهران")]
    [DataRow("( šä)¤¬ãþóø¢›¨õ", "مسجدولیعصر(عج )")]
    [DataRow("üõøõä ©¥øõ", "اموزش عمومی")]
    [DataRow("‚€", "۱۲۰")]
    [DataRow("ôø¬ãõ ù¢¤‘ú –Žþû", "هیئت چهارده معصوم")]
    [DataRow("(‘®õø¢‘“) üî¤ðþ› é÷¬", "صنف جیگرکی (بادوامضاء)")]
    [DataRow(".–¨ ù¢‘ê—¨ ñ“‘ì", "قابل استفاده است.")]
    [DataRow("ý¤“ ù¢ª éþ¤ã— –¤ø—¨¢ –¨þó", "لیست دستورات تعریف شده برای")]
    [DataRow("ü¨¤‘ê ¢¢ä ©þ‘õ÷", "نمایش اعداد فارسی")]
    [DataRow("öªø¤ ¤ðªþ‘õ÷ ùŸê¬", "صفحه نمایشگر روشن")]
    [DataRow("¤ð•‘ ù“ ôŽòä ñ‘¨¤", "ارسال علائم به چاپگر")]
    [DataRow("öªø¤ ‘û¢þóî ý¢¬", "صدای کلیدها روشن")]
    [DataRow("ü¨¤‘ê ¢¢ä ”þ‘—", "تایپ اعداد فارسی")]
    [DataRow("¤ð•‘ ñ‘¬— ù‘ð¤¢", "درگاه اتصال چاپگر")]
    [DataRow("ù÷¥ø¨  ‰¤ð•‘", "چاپگر۹  سوزنه")]
    [DataRow("ù÷¥ø¨ ‚„ ¤ð•‘", "چاپگر ۲۴ سوزنه")]
    [DataRow("EGA ù“ VGA ñþ¢“—", "تبدیل VGA به EGA")]
    [DataRow(".ôþû¢üõ ¤¤ì ùàê‘Ÿ¤¢ ¤ SEPAND.BIN ùõ‘÷¤“ LOAD ¤ø—¨¢‘“ §•¨ -‚",
                "-۲ سپس بادستور LOAD برنامه SEPAND.BIN را درحافظه قرار می‌دهیم.")]
    public void Test_Real_IranSystem_Data_Can_Be_Converted(string iranSystem, string unicode)
    {
        Assert.AreEqual(unicode, iranSystem.FromIranSystemToUnicode());
        Assert.AreEqual(iranSystem, unicode.FromUnicodeToIranSystem(false));
    }

    [DataTestMethod]
    [DataRow("آئودی")]
    [DataRow("آفریقائی")]
    [DataRow("سئوال")]
    [DataRow("فئودال")]
    [DataRow("آبخیز")]
    //[DataRow("مؤمن")]
    [DataRow("ماهرخ")]
    [DataRow("مالی")]
    [DataRow("لاله")]
    [DataRow("نازیلا")]
    [DataRow("زهرا")]
    [DataRow("خانه‌ها")]
    //[DataRow("حجةالاسلام")]
    [DataRow("یک‌لاقبا")]
    //[DataRow("حافظ‌پژوهی")]
    [DataRow("غلطگیری")]
    [DataRow("غلطی")]
    public void Test_Simple_Words_Can_be_Converted(string expected)
    {
        var result = expected.FromUnicodeToIranSystem();
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("مؤمن", "مومن")]
    [DataRow("توسّط", "توسط")]
    public void Test_Diacritics_Can_Be_Ignored(string input, string expected)
    {
        var result = input.FromUnicodeToIranSystem(false);
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("استقلال‌طلب")]
    [DataRow("یک‌لایه")]
    [DataRow("مقاطعه‌کار")]
    [DataRow("مغناطیس")]
    [DataRow("معین‌السلطنه")]
    [DataRow("معطر")]
    [DataRow("معظمی")]
    [DataRow("انزواطلب")]
    [DataRow("انتظام")]
    [DataRow("امیرانتظام")]
    [DataRow("عبدالظاهر")]
    [DataRow("سواره‌نظام")]
    [DataRow("ظالمان")]
    [DataRow("ظاهربینی")]
    [DataRow("نامنطبق")]
    public void Test_Half_Space_Items_Can_Be_Converted(string input)
    {
        var result = input.FromUnicodeToIranSystem(false);
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(input, actual);
    }

    [DataTestMethod]
    [DataRow("Rb0027")]
    [DataRow("سعید سالاری 09122222129")]
    [DataRow("سعید سالاری 09122222129 است.")]
    [DataRow("Ab123CD456")]
    [DataRow("3000000000000000000")]
    [DataRow("0.05")]
    [DataRow("۰۱۲۳۴۵۶۷۸۹")]
    [DataRow("2- نشان الف و ب")]
    [DataRow("۲- نشان الف و ب")]
    public void Test_ToIranSystem_Works_With_Mixed_English_And_Numbers(string input)
    {
        var result = input.FromUnicodeToIranSystem(false);
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(input, actual);
    }

    [DataTestMethod]
    [DataRow("¢ُںُ", "محمد")]
    [DataRow(" éٍî", "کلاف")]
    [DataRow("éٍîéٍî", "کلاف‌کلاف")]
    [DataRow("¢ّ¤،¤¨", "سرخرود")]
    [DataRow("ù÷¨ںَگ", "الحسنه")]
    [DataRow("­¤ى", "قرض")]
    [DataRow("ëّ¢÷¬", "صندوق")]
    public void Test_ArabicWindows_Can_Be_Converted(string iranSystem1256, string unicode)
    {
        Assert.AreEqual(unicode, iranSystem1256.FromIranSystemToUnicode(TextEncoding.ArabicWindows));
    }

    [DataTestMethod]
    [DataRow("سطر یک" + "\n" + "سطر دو")]
    public void Test_Multipe_Lines_Can_Be_Converted(string input)
    {
        var result = input.FromUnicodeToIranSystem(false);
        var actual = result.FromIranSystemToUnicode();
        Assert.AreEqual(input, actual);
    }

    [TestMethod]
    public void Test_Wikipedia_Sample_Works()
    {
        // https://fa.wikipedia.org/wiki/%DA%A9%D8%AF%D8%A8%D9%86%D8%AF%DB%8C_%D8%A7%DB%8C%D8%B1%D8%A7%D9%86%E2%80%8C%D8%B3%DB%8C%D8%B3%D8%AA%D9%85
        byte[] iranSystemBytes =
        {
            0xA1, // ﺧ
            0x91, // ﺎ
            0xF7, // ﻧ
            0xF9, // ﻩ
            //0xFA, // ﻬ --> This is wrong, and it shouldn't be here!
            0xFB, // ﻫ
            0x91, // ﺎ
        }; // خانه‌ها
        var actual = iranSystemBytes.FromIranSystemBytesToUnicode(reverseInput: true);
        Assert.AreEqual("خانه‌ها", actual);
    }
}
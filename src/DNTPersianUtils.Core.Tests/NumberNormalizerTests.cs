using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class NumberNormalizerTests
{
    [TestMethod]

    // حذف کاراکتر غیرمجاز $
    [DataRow("$123.45", 0, false)]
    [DataRow("12%34", 0, false)]
    [DataRow("(123)", 0, false)]
    [DataRow("50%", 0, false)]

    // Leading decimal point
    [DataRow(".5", 0.5, true)]
    [DataRow("-.5", -0.5, true)]
    [DataRow("+.5", +0.5, true)]

    // Trailing decimal point
    [DataRow("5.", 5.0, true)]
    [DataRow("-5.", -5.0, true)]
    [DataRow("+5.", +5.0, true)]

    // Persian digits
    [DataRow("۱۲۳", 123, true)]
    [DataRow("۱۲۳٫۴۵", 123.45, true)]
    [DataRow("۰٫۷۵", 0.75, true)]
    [DataRow("۱۲.۵", 12.5, true)]
    [DataRow("١٢,٥", 12.5, true)]

    // Arabic digits
    [DataRow("٣٫١٤", 3.14, true)]
    [DataRow("١٢٣٤", 1234, true)]

    // Decimal separator normalization
    [DataRow("1,25", 1.25, true)]
    [DataRow("12,0", 12.0, true)]
    [DataRow("123,45", 123.45, true)]
    [DataRow("،123،45", 12345, true)]

    //  اصلاح ممیزهای فارسی (/) به نقطه
    [DataRow("1/25", 1.25, true)]
    [DataRow("45/", 45.0, true)]
    [DataRow("1,250.75", 1250.75, true)]

    // Signs
    [DataRow("−12", -12, true)]
    [DataRow("－15", -15, true)]
    [DataRow("＋7", +7, true)]
    [DataRow("+-123", 0, false)]
    [DataRow("-+123", 0, false)]
    [DataRow("123-", 0, false)]
    [DataRow("123+", 0, false)]
    [DataRow("  -  456.78  ", -456.78, true)]

    // Remove thousands separators
    [DataRow("1_234.567", 1234.567, true)]
    [DataRow("1'234.561", 1234.561, true)]
    [DataRow("۱،۲۳۴٫۵۶", 1234.56, true)]
    [DataRow("12,345,678", 12345678, true)]
    [DataRow("12345,678", 12345.678, true)]
    [DataRow("1,234,567.89", 1234567.89, true)]
    [DataRow("1,000", 1000, true)]
    [DataRow("11,000", 11000, true)]
    [DataRow("111,000", 111000, true)]
    [DataRow("1,111,000", 1111000, true)]
    [DataRow("1,000.5", 1000.5, true)]
    [DataRow("1.234,56", 1234.56, true)]
    [DataRow("1,234.56", 1234.56, true)]
    [DataRow(" 1 2 3 . 4 ", 123.4, true)]
    [DataRow("12..5", 0, false)]
    [DataRow("1234,56", 1234.56, true)]
    [DataRow("1234.56", 1234.56, true)]
    [DataRow("1234", 1234, true)]
    [DataRow("12.345.678", 12345678, true)]
    [DataRow("12,345,678.90", 12345678.90, true)]
    [DataRow("12.345.678,90", 12345678.90, true)]
    [DataRow("1,2", 1.2, true)]
    [DataRow("100,5", 100.5, true)]
    [DataRow("1,23,456", 0, false)]

    // Remove whitespace
    [DataRow(" 123 ", 123, true)]
    [DataRow("123 456", 123456, true)]
    [DataRow("1 234", 1234, true)]
    [DataRow("۱ ۲۳۴٫۵", 1234.5, true)]

    // Mixed Persian & English
    [DataRow("۱۲3.۴۵", 123.45, true)]

    // Already normalized
    [DataRow("123.45", 123.45, true)]
    [DataRow("-123.45", -123.45, true)]

    // صفرهای ابتدایی حذف نمی‌شوند (طبق متد فعلی)
    [DataRow("000123", 123, true)]

    // Empty
    [DataRow("", 0, false)] // ورودی خالی
    [DataRow(" ", 0, false)] // ورودی فقط فاصله
    [DataRow("-", 0, false)] // فقط علامت منفی
    [DataRow("+", 0, false)] // فقط علامت مثبت

    //Bad inputs
    [DataRow("12..3", 0, false)]
    [DataRow("1.2.3", 0, false)]
    [DataRow("--5", 0, false)]
    [DataRow("++5", 0, false)]
    [DataRow("12a", 0, false)]
    [DataRow("abc", 0, false)]
    [DataRow("-.+5", 0, false)]
    [DataRow("1-2", 0, false)]
    [DataRow("1+2", 0, false)]
    [DataRow("1..2", 0, false)]
    [DataRow("1....2", 0, false)]
    [DataRow("1.23.456", 0, false)] // هزارگان اشتباه
    [DataRow("12,,5", 0, false)] // دو ممیز
    [DataRow("1,234.5.6", 0, false)] // دو ممیز اعشاری
    [DataRow("1.234,5,6", 0, false)] // دو ممیز اعشاری
    [DataRow("123,45,67", 0, false)] // الگوی نامعتبر

    // some tests
    [DataRow("1_234.56", 1234.56, true)]
    [DataRow("+.75", 0.75, true)]
    public void ToNormalizedNumberShouldProduceParsableDecimal(string input, double expected, bool success)
    {
        var result = input.TryNormalizeAndParseNumberString<decimal>(out var actual);
        Assert.AreEqual(success, result);
        Assert.AreEqual((decimal)expected, actual);
    }
}
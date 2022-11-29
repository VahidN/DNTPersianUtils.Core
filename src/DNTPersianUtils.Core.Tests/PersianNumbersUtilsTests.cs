using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class PersianNumbersUtilsTests
{
    [TestMethod]
    public void Test_English_ToPersianNumbers_Works()
    {
        var actual = 123.ToPersianNumbers();
        Assert.AreEqual("۱۲۳", actual);
    }

    [TestMethod]
    public void Test_Arabic_ToPersianNumbers_Works()
    {
        var actual = "\u06F1\u06F2\u06F3".ToPersianNumbers();
        Assert.AreEqual("۱۲۳", actual);
    }

    [TestMethod]
    public void Test_Persian_ToEnglishNumbers_Works()
    {
        var actual = "١٢٣".ToEnglishNumbers();
        Assert.AreEqual("123", actual);
    }

    [TestMethod]
    public void Test_Arabic_ToEnglishNumbers_Works()
    {
        var actual = "\u06F1\u06F2\u06F3".ToEnglishNumbers();
        Assert.AreEqual("123", actual);
    }
}
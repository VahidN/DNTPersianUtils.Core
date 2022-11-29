using DNTPersianUtils.Core.Normalizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class FixThinSpaceTests
{
    [TestMethod]
    [DataRow("دوست​ها")] // 8203    \u200B
    [DataRow("دوست‌ها")] // 8204    \u200C
    [DataRow("دوست‎ها")] // 8206    \u200E
    [DataRow("دوست‏ها")] // 8207    \u200F
    public void Test_Should_Remove_ThinSpaces(string text)
    {
        var result = text.ReplaceThinSpaces();

        Assert.AreEqual("دوستها", result);
    }

    [TestMethod]
    [DataRow("دوست​ها")] // 8203    \u200B
    [DataRow("دوست‌ها")] // 8204    \u200C
    //        [DataRow("دوست‍ها")] // 8205    \u200D
    [DataRow("دوست‎ها")] // 8206    \u200E
    [DataRow("دوست‏ها")] // 8207    \u200F
    public void Test_Should_Replace_ThinSpaces_WithSpace(string text)
    {
        var result = text.ReplaceThinSpaces(" ");

        Assert.AreEqual("دوست ها", result);
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class SeoUtilsTests
{
    [DataTestMethod]
    [DataRow("\"چگونه می\u200cتوان ریسک\u200cهای معامله را کاهش داد؟\"",
                "چگونه-می\u200cتوان-ریسک\u200cهای-معامله-را-کاهش-داد")]
    [DataRow("براي   «آزمايش»--- است!", "برای-آزمایش-است")]
    public void Test_GetPostSlug_Works(string text, string expectedSlug)
    {
        Assert.AreEqual(expectedSlug, text.GetPostSlug());
    }
}
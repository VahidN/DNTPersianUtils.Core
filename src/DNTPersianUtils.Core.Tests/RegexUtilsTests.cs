using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class RegexUtilsTests
    {
        [DataTestMethod]
        [DataRow("Abc تست")]
        [DataRow("،")]
        [DataRow("٬")]
        [DataRow("؛")]
        [DataRow("»")]
        [DataRow("«")]
        [DataRow("؟")]
        [DataRow("ی")]
        [DataRow("۹")]
        [DataRow("؛۹ی")]
        [DataRow("aaیaa")]
        [DataRow("a۹a")]
        [DataRow("؛a")]
        [DataRow("a؛۹ی")]
        public void Test_ContainsFarsi_Works(string text)
        {
            Assert.IsTrue(text.ContainsFarsi());
        }

        [DataTestMethod]
        [DataRow("this is not rtl")]
        [DataRow("this-is-not-rtl")]
        [DataRow("this,is,not,rtl")]
        public void Test_DoesNot_ContainFarsi_Works(string text)
        {
            Assert.IsFalse(text.ContainsFarsi());
        }

        [DataTestMethod]
        [DataRow("۱۲۳")]
        [DataRow("۴۵۶۷۸")]
        [DataRow("۹۹۹۹۹")]
        public void Test_ContainsOnlyPersianNumbers_Works(string text)
        {
            Assert.IsTrue(text.ContainsOnlyPersianNumbers());
        }

        [DataTestMethod]
        [DataRow("ابپ")]
        [DataRow("ا۲بپ")]
        [DataRow("1")]
        [DataRow("1234")]
        public void Test_DoesNot_ContainsOnlyPersianNumbers_Works(string text)
        {
            Assert.IsFalse(text.ContainsOnlyPersianNumbers());
        }

        [DataTestMethod]
        [DataRow("الب")]
        [DataRow("تثج")]
        [DataRow("چحخدذرز")]
        public void Test_ContainsOnlyFarsiLetters_Works(string text)
        {
            Assert.IsTrue(text.ContainsOnlyFarsiLetters());
        }

        [DataTestMethod]
        [DataRow("فارسی است")]
        [DataRow("تست")]
        public void Test_ContainsOnlyFarsiLetters_With_Whitespaces_Works(string text)
        {
            Assert.IsTrue(text.ContainsOnlyFarsiLetters(allowWhitespace: true));
        }

        [DataTestMethod]
        [DataRow("اaلب")]
        [DataRow("a")]
        [DataRow("ا۲لب")]
        [DataRow("۲")]
        [DataRow("this is not rtl")]
        [DataRow("this-is-not-rtl")]
        [DataRow("this,is,not,rtl")]
        public void Test_DoesNot_ContainsOnlyFarsiLetters_Works(string text)
        {
            Assert.IsFalse(text.ContainsOnlyFarsiLetters());
        }

        [DataTestMethod]
        [DataRow("دوست​ها")] // 8203    \u200B
        [DataRow("دوست‌ها")] // 8204    \u200C
        [DataRow("دوست‎ها")] // 8206    \u200E
        [DataRow("دوست‏ها")] // 8207    \u200F
        public void Test_Contains_Thin_Spaces(string text)
        {
            var hasThinSpace = text.ContainsThinSpace();

            Assert.IsTrue(hasThinSpace);
        }

        [DataTestMethod]
        [DataRow("دوست ها")]
        [DataRow("دوستها")]
        public void Test_DoesNot_Contains_Thin_Spaces(string text)
        {
            var hasThinSpace = text.ContainsThinSpace();

            Assert.IsFalse(hasThinSpace);
        }
    }
}
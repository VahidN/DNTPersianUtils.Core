using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class NormalizerTests
    {
        [TestMethod]
        public void ConvertEnglishQuotes_Should_Replace_English_Quotes_With_Their_Persian_Equivalent()
        {
            var test2 = "'تست'";
            var result2 = "«تست»";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));

            var test = "''تست''";
            var result = "«تست»";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));

            var test4 = "`تست`";
            var result4 = "«تست»";
            Assert.AreEqual(result4, test4.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));

            var test5 = "``تست``";
            var result5 = "«تست»";
            Assert.AreEqual(result5, test5.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));

            var test3 = "\"گفت: سلام\"";
            var result3 = "«گفت: سلام»";
            Assert.AreEqual(result3, test3.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));

            var test6 = @"""آزمون"" or ""آزمون""";
            var result6 = "«آزمون» or «آزمون»";
            Assert.AreEqual(result6, test6.NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes));
        }

        [TestMethod]
        public void ConvertDotsToEllipsis_Should_Replace_Three_Dots_With_Ellipsis()
        {
            var test = "آزمون...";
            var result = "آزمون…";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.ConvertDotsToEllipsis));

            var test2 = "آزمون....";
            var result2 = "آزمون…";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.ConvertDotsToEllipsis));

            var test3 = "خداحافظ ... به به";
            var result3 = "خداحافظ… به به";
            Assert.AreEqual(result3, test3.NormalizePersianText(PersianNormalizers.ConvertDotsToEllipsis));

            var test4 = "آزمون.........";
            var result4 = "آزمون…";
            Assert.AreEqual(result4, test4.NormalizePersianText(PersianNormalizers.ConvertDotsToEllipsis));
        }

        [TestMethod]
        public void FixDashes_Should_Replace_Double_Dash_To_Ndash_And_Triple_Dash_To_Mdash()
        {
            var test = "آزمون--";
            var result = "آزمون–";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.FixDashes));

            var test2 = "آزمون---";
            var result2 = "آزمون—";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.FixDashes));
        }

        [TestMethod]
        public void ApplyHalfSpaceRule_Should_Put_Zwnj_Between_Word_And_Prefix_Suffix()
        {
            var test = "ما می توانیم";
            var result = "ما می‌توانیم";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.ApplyHalfSpaceRule));

            var test2 = "ما نمی توانیم";
            var result2 = "ما نمی‌توانیم";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.ApplyHalfSpaceRule));

            var test3 = "این بهترین کتاب ها است";
            var result3 = "این بهترین کتاب‌ها است";
            Assert.AreEqual(result3, test3.NormalizePersianText(PersianNormalizers.ApplyHalfSpaceRule));

            var test4 = "بزرگ تری و قدرتمند ترین زبان های دنیا";
            var result4 = "بزرگ‌تری و قدرتمند‌ترین زبان‌های دنیا";
            Assert.AreEqual(result4, test4.NormalizePersianText(PersianNormalizers.ApplyHalfSpaceRule));

            var test9 = "زمانیکه نگارش";
            var result9 = "زمانیکه نگارش";
            Assert.AreEqual(result9, test9.NormalizePersianText(PersianNormalizers.ApplyHalfSpaceRule));
        }

        [TestMethod]
        public void CleanupZwnj_Should_Remove_Unnecessary_Zwnj_Chars_That_Are_Succeeded_Preceded_By_A_Space()
        {
            var test = "سلام‌ دنیا";// before space
            var result = "سلام دنیا";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.CleanupZwnj));

            var test2 = "سلام ‌دنیا"; //after space
            var result2 = "سلام دنیا";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.CleanupZwnj));
        }

        [TestMethod]
        public void CleanupExtraMarks_Should_Work()
        {
            var test = "سلام!!!";
            var result = "سلام!";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.CleanupExtraMarks));

            var test2 = "چطور؟؟؟";
            var result2 = "چطور؟";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.CleanupExtraMarks));
        }

        [TestMethod]
        public void RemoveAllKashida_Should_Work()
        {
            var test = "سلامـــت";
            var result = "سلامت";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.RemoveAllKashida));
        }

        [TestMethod]
        public void CleanupSpacingAndLineBreaks_Should_Work()
        {
            var test = "  سلام   world!  I'm virastar   ";
            var result = "سلام world! I'm virastar";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.CleanupSpacingAndLineBreaks));

            var test1 = "this is \n \n \n     \n a آزمون";
            var result1 = "this is \n\n\n\na آزمون";
            Assert.AreEqual(result1, test1.NormalizePersianText(PersianNormalizers.CleanupSpacingAndLineBreaks));

            var test3 = "this is\n\n\n\na آزمون";
            var result3 = "this is\n\n\n\na آزمون";
            Assert.AreEqual(result3, test3.NormalizePersianText(PersianNormalizers.CleanupSpacingAndLineBreaks));

            var test4 = "this is \n\n\n    a آزمون";
            var result4 = "this is \n\n\na آزمون";
            Assert.AreEqual(result4, test4.NormalizePersianText(PersianNormalizers.CleanupSpacingAndLineBreaks));

            var test5 = "this is \n  a آزمون";
            var result5 = "this is \na آزمون";
            Assert.AreEqual(result5, test5.NormalizePersianText(PersianNormalizers.CleanupSpacingAndLineBreaks));
        }

        [TestMethod]
        public void RemoveOutsideInsideSpacing_Should_Work()
        {
            //should not put space after time colon separator
            var test = "ساعت 12:34";
            var result = "ساعت 12:34";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.RemoveOutsideInsideSpacing));

            //no space before ":"
            var test1 = "گفت : سلام";
            var result1 = "گفت: سلام";
            Assert.AreEqual(result1, test1.NormalizePersianText(PersianNormalizers.RemoveOutsideInsideSpacing));

            //one space after "."
            var test2 = "سلام.\n\nkhoobi";
            var result2 = "سلام. \n\nkhoobi";
            Assert.AreEqual(result2, test2.NormalizePersianText(PersianNormalizers.RemoveOutsideInsideSpacing));

            //should fix spacing for () [] {}  “” «» (one space outside, no space inside)
            var test3 = "انجام   «   آزمون   »  ";
            var result3 = "انجام «آزمون»";
            Assert.AreEqual(result3, test3.NormalizePersianText(PersianNormalizers.RemoveOutsideInsideSpacing));
        }

        [TestMethod]
        public void ApplyPersianYeKe_Should_Replace_Arabic_Numbers_With_Their_Persian_Equivalent()
        {
            var test = "٠١٢٣٤٥٦٧٨٩";
            var result = "۰۱۲۳۴۵۶۷۸۹";
            Assert.AreEqual(result, test.NormalizePersianText(PersianNormalizers.ApplyPersianNumbers));
        }

        [TestMethod]
        public void Test_ApplyCorrectYeKe_Works()
        {
            var actual = "\u0643\u0649\u064A".NormalizePersianText(PersianNormalizers.ApplyPersianYeKe);
            var expected = "\u06A9\u06CC\u06CC";
            Assert.AreEqual(expected, actual);
        }
    }
}
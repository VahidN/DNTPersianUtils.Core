using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class HumanReadableIntegerTests
    {
        [TestMethod]
        public void Test_NumberToText_Works()
        {
            var actual = 1234567.NumberToText(Language.Persian);
            Assert.AreEqual(expected: "یک میلیون و دویست و سی و چهار هزار و پانصد و شصت و هفت", actual: actual);
        }

        [TestMethod]
        public void Test_ConvertNumberToText_Works()
        {
            var actual = 1234567.ConvertNumberToText(Language.Persian);
            Assert.AreEqual(expected: "یک میلیون و دویست و سی و چهار هزار و پانصد و شصت و هفت", actual: actual);
        }
    }
}
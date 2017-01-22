using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class PersianNumbersUtilsTests
    {
        [TestMethod]
        public void Test_ToPersianNumbers_Works()
        {
            var actual = 123.ToPersianNumbers();
            Assert.AreEqual(expected: "۱۲۳", actual: actual);
        }
    }
}
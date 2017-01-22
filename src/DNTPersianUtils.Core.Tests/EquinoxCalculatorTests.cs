using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class EquinoxCalculatorTests
    {
        [TestMethod]
        public void Test_IsStartOfNewYear_Returns_Correct_Result()
        {
            var newYearStart = "1395/12/30 14:00:00".ToGregorianDateTime();
            var actual = newYearStart.Value.IsStartOfNewYear();

            Assert.AreEqual(expected: true, actual: actual);
        }
    }
}
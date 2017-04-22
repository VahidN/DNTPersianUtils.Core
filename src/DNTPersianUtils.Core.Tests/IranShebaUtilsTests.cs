using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class IranShebaUtilsTests
    {
        [DataTestMethod]
        [DataRow("IR820540102680020817909002")]
        [DataRow("IR062960000000100324200001")]
        public void ValidIranShebaCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranShebaNumber());
        }

        [DataTestMethod]
        [DataRow("IR01234567890123456789")]
        [DataRow("IR012345678901234567890123456789")]
        [DataRow("IR01234567890123456789")]
        [DataRow("IR012345678901234567890123")]
        [DataRow("IR06296000000010032420000")]
        [DataRow("00062960000000100324200001")]
        public void InvalidIranShebaCodesTest(string code)
        {
            Assert.IsFalse(code.IsValidIranShebaNumber());
        }
    }
}
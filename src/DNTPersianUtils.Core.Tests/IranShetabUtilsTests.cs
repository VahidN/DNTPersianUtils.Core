using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class IranShetabUtilsTests
    {
        [DataTestMethod]
        [DataRow("6221061106498670")]
        [DataRow("636214-1075165358")]
        [DataRow("6274129005473742")]
        public void ValidIranShetabCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranShetabNumber());
        }

        [DataTestMethod]
        [DataRow("6274-1290-0547-3742")]
        [DataRow("6274129107473842")]
        [DataRow("6274 1290 0547 3742")]
        [DataRow("627412900742")]
        [DataRow("62741290054737423252")]
        public void InvalidIranShetabCodesTest(string code)
        {
            Assert.IsFalse(code.IsValidIranShetabNumber());
        }
    }
}
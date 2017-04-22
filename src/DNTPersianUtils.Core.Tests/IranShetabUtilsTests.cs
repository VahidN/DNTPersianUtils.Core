using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class IranShetabUtilsTests
    {
        [DataTestMethod]
        [DataRow("6221061106498670")]
        [DataRow("636214-1075165358")]
        public void ValidIranShetabCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranShetabNumber());
        }
    }
}
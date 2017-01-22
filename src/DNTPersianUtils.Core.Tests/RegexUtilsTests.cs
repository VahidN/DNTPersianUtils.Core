using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class RegexUtilsTests
    {
        [TestMethod]
        public void Test_ContainsFarsi_Works()
        {
            Assert.IsTrue("Abc تست".ContainsFarsi());
        }
    }
}